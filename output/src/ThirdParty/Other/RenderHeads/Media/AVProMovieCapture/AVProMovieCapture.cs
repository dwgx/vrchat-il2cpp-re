// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 42
// Methods: 735

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x6CE6AA0
        public void GetCoeffCount(){} // RVA: 0x6CE6B30
        public void GetChannelOrder(){} // RVA: 0x6CE6B60
        public void GetNormalisation(){} // RVA: 0x6CE6B60
        public void .cctor(){} // RVA: 0x6CE6B70
        public void BuildWeightsFuMa(){} // RVA: 0x6CE6E20
        public void GetN(){} // RVA: 0x6CE70F0
        public void GetM(){} // RVA: 0x6CE7130
        public void Factorial(){} // RVA: 0x6CE71B0
        public void GetNormalisationSN3D(){} // RVA: 0x6CE72C0
        public void GetNormalisationN3D(){} // RVA: 0x6CE7440
        public void BuildWeightsSN3D(){} // RVA: 0x6CE74F0
    }

    public class AmbisonicSource : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6CC1220
        public void OnDisable(){} // RVA: 0x6CC15D0
        public void Setup(){} // RVA: 0x6CC1870
        public void OnDrawGizmos(){} // RVA: 0x6CC1B70
        public void LateUpdate(){} // RVA: 0x6CC1EC0
        public void SetListenerRelativePosition(){} // RVA: 0x6CC2190
        public void UpdateCoefficients(){} // RVA: 0x6CC21B0
        public void OnAudioFilterRead(){} // RVA: 0x6CC2530
        public void FlushBuffers(){} // RVA: 0x6CC2BB0
        public void GetFullBufferCount(){} // RVA: 0x6CC2F50
        public void SendSamplesToSink(){} // RVA: 0x6CC2FA0
        public void .ctor(){} // RVA: 0x6CC3220
    }

    public class AmbisonicSource[] : Array
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

    public class AmbisonicWavWriter : MonoBehaviour
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x1065D50
        public void get_Format(){} // RVA: 0x1AE5AC0
        public void AddSource(){} // RVA: 0x6CC33E0
        public void RemoveSource(){} // RVA: 0x6CC3580
        public void OnDisable(){} // RVA: 0x6CC36D0
        public void SetupSource(){} // RVA: 0x6CC36E0
        public void ToggleCapturing(){} // RVA: 0x6CC3790
        public void StartCapture(){} // RVA: 0x6CC37C0
        public void StopCapture(){} // RVA: 0x6CC3E80
        public void IsCapturing(){} // RVA: 0x6CC4080
        public void LateUpdate(){} // RVA: 0x6CC40A0
        public void ProcessSources(){} // RVA: 0x6CC41C0
        public void MixSamples(){} // RVA: 0x6CC4490
        public void FlushWavWriter(){} // RVA: 0x6CC45B0
        public void .ctor(){} // RVA: 0x6CC45F0
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6CC47F0
        public void OnDisable(){} // RVA: 0x6CC49E0
        public void OnAudioFilterRead(){} // RVA: 0x6CC4A60
        public void .ctor(){} // RVA: 0x6CC4A90
    }

    public class CameraSelector : MonoBehaviour
    {
        // ── Methods ──
        public void get_Camera(){} // RVA: 0xBC1B30
        public void set_Camera(){} // RVA: 0x6CC4B60
        public void get_SelectBy(){} // RVA: 0xFEAE90
        public void set_SelectBy(){} // RVA: 0x6CC4BD0
        public void get_ScanFrequency(){} // RVA: 0x15AF000
        public void set_ScanFrequency(){} // RVA: 0x6CC4BE0
        public void get_ScanHiddenCameras(){} // RVA: 0xF73960
        public void set_ScanHiddenCameras(){} // RVA: 0x6CC4BF0
        public void get_SelectTag(){} // RVA: 0xD33E60
        public void set_SelectTag(){} // RVA: 0x6CC4C00
        public void get_SelectName(){} // RVA: 0xD05CA0
        public void set_SelectName(){} // RVA: 0x6CC4C60
        public void Awake(){} // RVA: 0x6CC4CC0
        public void Start(){} // RVA: 0x6CC4CD0
        public void OnValidate(){} // RVA: 0x6CC4CC0
        public void Update(){} // RVA: 0x6CC4CE0
        public void OnDestroy(){} // RVA: 0x6CC4D00
        public void ResetSceneLoading(){} // RVA: 0x6CC4DA0
        public void OnSceneLoaded(){} // RVA: 0x6CC4E90
        public void ScanForCameraChange(){} // RVA: 0x6CC4EA0
        public void FindCamera(){} // RVA: 0x6CC50D0
        public void UpdateCameraCache(){} // RVA: 0x6CC5450
        public void FindCameraByHighestDepth(){} // RVA: 0x6CC55F0
        public void FindCameraByTag(){} // RVA: 0x6CC5770
        public void FindCameraByName(){} // RVA: 0x6CC5820
        public void .ctor(){} // RVA: 0x6CC5900
    }

    public class CaptureAudioFromAudioClip : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6CC5AD0
        public void Update(){} // RVA: 0x6CC5DF0
        public void GetAudioSamplesForFrame(){} // RVA: 0x6CC5F00
        public void .ctor(){} // RVA: 0x114DAE0
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0xD33E60
        public void get_BufferLength(){} // RVA: 0x18A0130
        public void get_BufferPtr(){} // RVA: 0x6CC61D0
        public void get_OverflowCount(){} // RVA: 0x1D46130
        public void get_SampleRate(){} // RVA: 0x6CC61E0
        public void get_ChannelCount(){} // RVA: 0xBE5890
        public void PrepareCapture(){} // RVA: 0x6CC6230
        public void StartCapture(){} // RVA: 0x11F4110
        public void StopCapture(){} // RVA: 0x6CC67A0
        public void ReadData(){} // RVA: 0x6CC69D0
        public void FlushBuffer(){} // RVA: 0x6CC6B20
        public void OnAudioFilterRead(){} // RVA: 0x6CC6C20
        public void .ctor(){} // RVA: 0x6CC6F40
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0xB700F0
        public void set_Capture(){} // RVA: 0xB70100
        public void get_SampleRate(){} // RVA: 0x6CC61E0
        public void get_ChannelCount(){} // RVA: 0x1065D50
        public void PrepareCapture(){} // RVA: 0x6CC70F0
        public void GetAudioBufferOfLength(){} // RVA: 0x6CC7110
        public void DisposeAudioBuffer(){} // RVA: 0xB43310
        public void StartCapture(){} // RVA: 0x6CC7330
        public void StopCapture(){} // RVA: 0x6CC75A0
        public void FlushBuffer(){} // RVA: 0x6CC7630
        public void Update(){} // RVA: 0x6CC7720
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        // ── Methods ──
        public void get_Capture(){} // RVA: 0xB700F0
        public void set_Capture(){} // RVA: 0xB70100
        public void Awake(){} // RVA: 0x6CC78E0
        public void get_SampleRate(){} // RVA: 0xDAC980
        public void get_ChannelCount(){} // RVA: 0xDAC980
        public void PrepareCapture(){} // RVA: 0xB43310
        public void FlushBuffer(){} // RVA: 0xB43310
        public void StartCapture(){} // RVA: 0xB43310
        public void StopCapture(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CaptureBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x255B920
        public void set_OutputTarget(){} // RVA: 0x6CE7A70
        public void get_OutputFolder(){} // RVA: 0x255B930
        public void set_OutputFolder(){} // RVA: 0x6CE7A80
        public void get_OutputFolderPath(){} // RVA: 0x135A7B0
        public void set_OutputFolderPath(){} // RVA: 0xEC0BB0
        public void get_FilenamePrefix(){} // RVA: 0x10B4170
        public void set_FilenamePrefix(){} // RVA: 0x15B42C0
        public void get_AppendFilenameTimestamp(){} // RVA: 0x1FDB9C0
        public void set_AppendFilenameTimestamp(){} // RVA: 0x1FDB9D0
        public void get_AllowManualFileExtension(){} // RVA: 0x2443DE0
        public void set_AllowManualFileExtension(){} // RVA: 0x2444100
        public void get_FilenameExtension(){} // RVA: 0xD9E3D0
        public void set_FilenameExtension(){} // RVA: 0xD9D290
        public void get_NamedPipePath(){} // RVA: 0xDA0520
        public void set_NamedPipePath(){} // RVA: 0xD9D570
        public void get_ImageSequenceStartFrame(){} // RVA: 0x15D7C60
        public void set_ImageSequenceStartFrame(){} // RVA: 0x6CE7A90
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x6BB0770
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x6CE7AA0
        public void get_UseMotionBlur(){} // RVA: 0x2540EB0
        public void set_UseMotionBlur(){} // RVA: 0x6CE7AD0
        public void get_MotionBlurSamples(){} // RVA: 0x6CE7AE0
        public void set_MotionBlurSamples(){} // RVA: 0x6CE7AF0
        public void get_MotionBlurCameras(){} // RVA: 0x12CDBF0
        public void set_MotionBlurCameras(){} // RVA: 0x164A230
        public void get_MotionBlur(){} // RVA: 0x1661250
        public void set_MotionBlur(){} // RVA: 0x166A5F0
        public void get_ActiveFilePaths(){} // RVA: 0x6CE7B20
        public void get_LastFilePath(){} // RVA: 0x135C160
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x165F4F0
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x164A160
        public void get_CompletedFileWritingAction(){} // RVA: 0x164EDD0
        public void set_CompletedFileWritingAction(){} // RVA: 0x1651390
        public void get_Stats(){} // RVA: 0x165F950
        public void get_CameraRenderResolution(){} // RVA: 0x6BA2C40
        public void set_CameraRenderResolution(){} // RVA: 0x6BA2C50
        public void get_CameraRenderCustomResolution(){} // RVA: 0x6CE7B80
        public void set_CameraRenderCustomResolution(){} // RVA: 0x6CE7BA0
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x1ECD740
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x1EC1C10
        public void get_IsRealTime(){} // RVA: 0x23E22A0
        public void set_IsRealTime(){} // RVA: 0x23E2270
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x2540270
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x2540280
        public void get_AudioCaptureSource(){} // RVA: 0x131DCD0
        public void set_AudioCaptureSource(){} // RVA: 0x23B1640
        public void get_ManualAudioSampleRate(){} // RVA: 0x31178C0
        public void set_ManualAudioSampleRate(){} // RVA: 0x6CE7BB0
        public void get_ManualAudioChannelCount(){} // RVA: 0x485FD30
        public void set_ManualAudioChannelCount(){} // RVA: 0x485FD40
        public void get_UnityAudioCapture(){} // RVA: 0x135D730
        public void set_UnityAudioCapture(){} // RVA: 0xBC5AD0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x25C0CD0
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x6CE7BC0
        public void get_FrameRate(){} // RVA: 0xBAB510
        public void set_FrameRate(){} // RVA: 0x6CE7BD0
        public void get_StartTrigger(){} // RVA: 0xBE5890
        public void set_StartTrigger(){} // RVA: 0xBE58A0
        public void get_StartDelay(){} // RVA: 0x1D46130
        public void set_StartDelay(){} // RVA: 0x262A680
        public void get_StartDelaySeconds(){} // RVA: 0xBAB430
        public void set_StartDelaySeconds(){} // RVA: 0x6CE7C00
        public void get_StopMode(){} // RVA: 0x15443F0
        public void set_StopMode(){} // RVA: 0x15443E0
        public void get_StopAfterFramesElapsed(){} // RVA: 0x12BB630
        public void set_StopAfterFramesElapsed(){} // RVA: 0x6CE7C10
        public void get_StopAfterSecondsElapsed(){} // RVA: 0xB6B180
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x6CE7C20
        public void get_CaptureStats(){} // RVA: 0x165F950
        public void get_VideoCodecPriorityWindows(){} // RVA: 0xBE2C60
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x6CE7C30
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0xBBFF90
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x6CE7C90
        public void get_AudioCodecPriorityWindows(){} // RVA: 0xCD3320
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x6CE7CF0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0xCD48B0
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x6CE7D50
        public void get_TimelapseScale(){} // RVA: 0xF3A940
        public void set_TimelapseScale(){} // RVA: 0x11A0AB0
        public void get_FrameUpdate(){} // RVA: 0x262A930
        public void set_FrameUpdate(){} // RVA: 0x262A900
        public void get_ResolutionDownScale(){} // RVA: 0x262A910
        public void set_ResolutionDownScale(){} // RVA: 0x262A920
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x6CE7DB0
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x6A6A810
        public void get_FlipVertically(){} // RVA: 0x1C11610
        public void set_FlipVertically(){} // RVA: 0x1C10980
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x6CE7DD0
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x6CE7DE0
        public void get_LogCaptureStartStop(){} // RVA: 0x6CE7DF0
        public void set_LogCaptureStartStop(){} // RVA: 0x6CE7E00
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x6CE7E10
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x6CE7E20
        public void get_SupportTextureRecreate(){} // RVA: 0x1B5A240
        public void set_SupportTextureRecreate(){} // RVA: 0x1B52910
        public void get_TimelineController(){} // RVA: 0x164B8E0
        public void set_TimelineController(){} // RVA: 0x16601C0
        public void get_VideoPlayerController(){} // RVA: 0x10F9C30
        public void set_VideoPlayerController(){} // RVA: 0x1659C50
        public void get_SelectedVideoCodec(){} // RVA: 0x1659CB0
        public void get_SelectedAudioCodec(){} // RVA: 0x1344890
        public void get_SelectedAudioInputDevice(){} // RVA: 0x1655DD0
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x158C700
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x158BEC0
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x215C150
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x215CA00
        public void get_NativeImageSequenceFormat(){} // RVA: 0x6CE7E30
        public void set_NativeImageSequenceFormat(){} // RVA: 0x6CE7E40
        public void GetCurrentPlatform(){} // RVA: 0xDAC980
        public void GetEncoderHints(){} // RVA: 0x6CE7E50
        public void SetEncoderHints(){} // RVA: 0x6CE7F00
        public void UpdateMediaGallery(){} // RVA: 0xB43310
        public void Awake(){} // RVA: 0x6CE8120
        public void .cctor(){} // RVA: 0x6CE85B0
        public void Start(){} // RVA: 0x6CE90D0
        public void SelectCodec(){} // RVA: 0x6CE9200
        public void SelectVideoCodec(){} // RVA: 0x6CE95E0
        public void SelectAudioCodec(){} // RVA: 0x6CE97C0
        public void SelectAudioInputDevice(){} // RVA: 0x6CE9930
        public void GetRecordingResolution(){} // RVA: 0x6CE9B90
        public void SelectRecordingResolution(){} // RVA: 0x6CE9C60
        public void OnDestroy(){} // RVA: 0x6CE9D70
        public void FreePendingFileWrites(){} // RVA: 0x6CEA0F0
        public void OnApplicationQuit(){} // RVA: 0x6CEA290
        public void OnApplicationPause(){} // RVA: 0xB43310
        public void EncodeTexture(){} // RVA: 0x6CEA2F0
        public void IsUsingUnityAudioComponent(){} // RVA: 0x6CEA440
        public void IsUsingMotionBlur(){} // RVA: 0x6CEA540
        public void EncodePointer(){} // RVA: 0x6CEA630
        public void IsPrepared(){} // RVA: 0x6CEA7C0
        public void IsCapturing(){} // RVA: 0x6CEA7D0
        public void IsPaused(){} // RVA: 0x6CEA7E0
        public void GetRecordingWidth(){} // RVA: 0x6CEA7F0
        public void GetRecordingHeight(){} // RVA: 0x6CEA800
        public void GenerateTimestampedFilename(){} // RVA: 0x6CEA810
        public void GetFolder(){} // RVA: 0x6CEAAE0
        public void GenerateFilePath(){} // RVA: 0x6CEACB0
        public void HasExtension(){} // RVA: 0x6CEAD50
        public void GenerateFilename(){} // RVA: 0x6CEAEA0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x6CEB660
        public void ValidateEditionFeatures(){} // RVA: 0x6CEBD20
        public void PrepareCapture(){} // RVA: 0x6CEC440
        public void QueueStartCapture(){} // RVA: 0x6CEE160
        public void IsStartCaptureQueued(){} // RVA: 0x6CEE200
        public void UpdateInjectionOptions(){} // RVA: 0x6CEE210
        public void StartCapture(){} // RVA: 0x6CEE2A0
        public void PauseCapture(){} // RVA: 0x6CEE750
        public void ResumeCapture(){} // RVA: 0x6CEE890
        public void CancelCapture(){} // RVA: 0x6CEE9A0
        public void DeleteCapture(){} // RVA: 0x6CEE9D0
        public void UnprepareCapture(){} // RVA: 0xB43310
        public void get_LastFileSaved(){} // RVA: 0x6CEEAE0
        public void set_LastFileSaved(){} // RVA: 0x6CEEB30
        public void RenderThreadEvent(){} // RVA: 0x6CEEB80
        public void StopCapture(){} // RVA: 0x6CEEBF0
        public void CreatePostOperationsOptions(){} // RVA: 0x6CEF920
        public void CanApplyPostOperations(){} // RVA: 0x6CEF9F0
        public void ApplyPostOperations(){} // RVA: 0x6CEFBE0
        public void ToggleCapture(){} // RVA: 0x6CEFE10
        public void IsEnoughDiskSpace(){} // RVA: 0x6CEFE50
        public void CanContinue(){} // RVA: 0x6CEFE90
        public void Update(){} // RVA: 0x6CEFFB0
        public void LateUpdate(){} // RVA: 0x6CF0020
        public void RemoveCompletedFileWrites(){} // RVA: 0x6CF0360
        public void CheckFreeDiskSpace(){} // RVA: 0x6CF0450
        public void IsStartDelayComplete(){} // RVA: 0x6CF0510
        public void IsStopTimeReached(){} // RVA: 0x6CF0540
        public void GetProgress(){} // RVA: 0x6CF0620
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x6CF06E0
        public void CanOutputFrame(){} // RVA: 0x6CF0710
        public void TickFrameTimer(){} // RVA: 0x6CF08F0
        public void RenormTimer(){} // RVA: 0x6CF0960
        public void GetPreviewTexture(){} // RVA: 0xDAC980
        public void EncodeUnityAudio(){} // RVA: 0x6CF09B0
        public void EncodeAudio(){} // RVA: 0x6CF0B00
        public void PreUpdateFrame(){} // RVA: 0x6CF0D50
        public void UpdateFrame(){} // RVA: 0x6CF0F30
        public void ResetFPS(){} // RVA: 0x6CF1260
        public void UpdateFPS(){} // RVA: 0x6CF1290
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x6CF1320
        public void GetCaptureFileSize(){} // RVA: 0x6CF14D0
        public void GetResolution(){} // RVA: 0x6CF15E0
        public void NextMultipleOf4(){} // RVA: 0x1CDC380
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x6CF1760
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x6CF1840
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0xDAC980
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x6CF18C0
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x6CF19A0
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x6CF1A20
    }

    public class CaptureFromCamera : CaptureBase
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x1667A40
        public void set_CameraSelector(){} // RVA: 0x163A9E0
        public void get_UseContributingCameras(){} // RVA: 0x6CC7940
        public void set_UseContributingCameras(){} // RVA: 0x6CC7950
        public void SetCamera(){} // RVA: 0x6CC7C80
        public void RequiresResolve(){} // RVA: 0x6CC7D40
        public void HasCamera(){} // RVA: 0x6CC7E30
        public void HasContributingCameras(){} // RVA: 0x6CC7F00
        public void UpdateFrame(){} // RVA: 0x6CC7F30
        public void FinalRenderCapture(){} // RVA: 0x6CC8220
        public void Capture(){} // RVA: 0x6CC82C0
        public void RequiresHDR(){} // RVA: 0x6CC8360
        public void UpdateTexture(){} // RVA: 0x6CC8590
        public void UnprepareCapture(){} // RVA: 0x6CC9030
        public void CreateResolveTexture(){} // RVA: 0x6CC9220
        public void GetPreviewTexture(){} // RVA: 0x16591F0
        public void PrepareCapture(){} // RVA: 0x6CC9840
        public void OnDestroy(){} // RVA: 0x6CCA510
        public void .ctor(){} // RVA: 0x6CCA880
        public void <>n__0(){} // RVA: 0x6CCA8E0
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        // ── Methods ──
        public void get_CameraSelector(){} // RVA: 0x1667A40
        public void set_CameraSelector(){} // RVA: 0x163A9E0
        public void get_CubemapFaceResolution(){} // RVA: 0x2303CF0
        public void set_CubemapFaceResolution(){} // RVA: 0x2304180
        public void get_CubemapDepthResolution(){} // RVA: 0x2304EA0
        public void set_CubemapDepthResolution(){} // RVA: 0x2304D80
        public void get_SupportGUI(){} // RVA: 0x6CCAFC0
        public void set_SupportGUI(){} // RVA: 0x6CCAFD0
        public void get_SupportCameraRotation(){} // RVA: 0x6CCAFE0
        public void set_SupportCameraRotation(){} // RVA: 0x6CCAFF0
        public void get_OnlyLeftRightRotation(){} // RVA: 0x6CCB000
        public void set_OnlyLeftRightRotation(){} // RVA: 0x6CCB010
        public void get_Render180Degrees(){} // RVA: 0x6CCB020
        public void set_Render180Degrees(){} // RVA: 0x6CCB030
        public void get_StereoRendering(){} // RVA: 0x2304A00
        public void set_StereoRendering(){} // RVA: 0x6CCB040
        public void get_IPD(){} // RVA: 0x6CCB050
        public void set_IPD(){} // RVA: 0x6CCB060
        public void .ctor(){} // RVA: 0x6CCB070
        public void GetCubemapRenderingMethod(){} // RVA: 0x6CCB100
        public void SetCamera(){} // RVA: 0x164B2D0
        public void UpdateFrame(){} // RVA: 0x6CCB120
        public void FinalRenderCapture(){} // RVA: 0x6CCB3E0
        public void Capture(){} // RVA: 0x6CCB480
        public void ClearCubemap(){} // RVA: 0x6CCB920
        public void RenderCubemapToEquiRect(){} // RVA: 0x6CCBE10
        public void UpdateTexture(){} // RVA: 0x6CCBFB0
        public void RenderCameraToCubemap(){} // RVA: 0x6CCC970
        public void AccumulateMotionBlur(){} // RVA: 0x6CCE290
        public void PrepareCapture(){} // RVA: 0x6CCE450
        public void GetPreviewTexture(){} // RVA: 0x6CCF7F0
        public void Start(){} // RVA: 0x6CCF830
        public void OnDestroy(){} // RVA: 0x6CCFBC0
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        // ── Methods ──
        public void get_Setup(){} // RVA: 0x1667A40
        public void .ctor(){} // RVA: 0x6CD0270
        public void SetCamera(){} // RVA: 0x6CD0390
        public void Start(){} // RVA: 0x6CD0400
        public void CreateEye(){} // RVA: 0x6CD05F0
        public void UpdateFrame(){} // RVA: 0x6CD1380
        public void FinalRenderCapture(){} // RVA: 0x6CD1670
        public void Capture(){} // RVA: 0x6CD1710
        public void AccumulateMotionBlur(){} // RVA: 0x6CD1B20
        public void RenderFrame(){} // RVA: 0x6CD1CF0
        public void GetPreviewTexture(){} // RVA: 0x6CD2A90
        public void PrepareCapture(){} // RVA: 0x6CD2AD0
        public void DestroyEye(){} // RVA: 0x6CD3C60
        public void OnDestroy(){} // RVA: 0x6CD3E90
    }

    public class CaptureFromScreen : CaptureBase
    {
        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x6CD4640
        public void set_CaptureMouseCursor(){} // RVA: 0x6CD4650
        public void get_MouseCursor(){} // RVA: 0x165A670
        public void set_MouseCursor(){} // RVA: 0x1661A80
        public void PrepareCapture(){} // RVA: 0x6CD4660
        public void CopyRenderTargetToTexture(){} // RVA: 0x6CD4950
        public void FreeRenderResources(){} // RVA: 0x6CD4F50
        public void UnprepareCapture(){} // RVA: 0x6CD51B0
        public void FinalRenderCapture(){} // RVA: 0x6CD52F0
        public void UpdateFrame(){} // RVA: 0x6CD5390
        public void .ctor(){} // RVA: 0x6CD5450
    }

    public class CaptureFromTexture : CaptureBase
    {
        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x6CD4640
        public void set_IsManualUpdate(){} // RVA: 0x6CD4650
        public void SetSourceTexture(){} // RVA: 0x1661A80
        public void RequiresResolve(){} // RVA: 0x6CD5680
        public void UpdateSourceTexture(){} // RVA: 0x6CD5770
        public void ShouldCaptureFrame(){} // RVA: 0x6CD5780
        public void HasSourceTextureChanged(){} // RVA: 0x6CD5870
        public void UpdateFrame(){} // RVA: 0x6CD5890
        public void FinalRenderCapture(){} // RVA: 0x6CD5960
        public void Capture(){} // RVA: 0x6CD5A00
        public void CreateResolveTexture(){} // RVA: 0x6CD5DE0
        public void AccumulateMotionBlur(){} // RVA: 0x6CD6300
        public void GetPreviewTexture(){} // RVA: 0x6CD6420
        public void PrepareCapture(){} // RVA: 0x6CD6590
        public void UnprepareCapture(){} // RVA: 0x6CD6940
        public void .ctor(){} // RVA: 0x6CD6B40
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6CD6C90
        public void .ctor(){} // RVA: 0x6CD6B40
    }

    public class CaptureGUI : MonoBehaviour
    {
        // ── Methods ──
        public void get_MovieCapture(){} // RVA: 0xB700F0
        public void set_MovieCapture(){} // RVA: 0xB70100
        public void get_HideUiWhenRecording(){} // RVA: 0x14F7430
        public void set_HideUiWhenRecording(){} // RVA: 0x21CBB70
        public void get_ShowUI(){} // RVA: 0xF73960
        public void set_ShowUI(){} // RVA: 0xF73A60
        public void Start(){} // RVA: 0x6CD6CF0
        public void CreateGUI(){} // RVA: 0x6CD6DD0
        public void OnGUI(){} // RVA: 0x6CD7A20
        public void MyWindow(){} // RVA: 0x6CD85C0
        public void GUI_RecordingStatus(){} // RVA: 0x6CDAEA0
        public void DrawPauseResumeButtons(){} // RVA: 0x6CDC8E0
        public void DrawGuiField(){} // RVA: 0x6CDD100
        public void StartCapture(){} // RVA: 0x6CDD1D0
        public void StopCapture(){} // RVA: 0x6CDD2D0
        public void CancelCapture(){} // RVA: 0x6CDD3D0
        public void ResumeCapture(){} // RVA: 0x6CDD4D0
        public void PauseCapture(){} // RVA: 0x6CDD5B0
        public void Update(){} // RVA: 0x6CDD690
        public void .ctor(){} // RVA: 0x6CDD950
        public void .cctor(){} // RVA: 0x6CDDF10
    }

    public class CaptureStats : Object
    {
        // ── Methods ──
        public void get_FPS(){} // RVA: 0xCD5510
        public void get_FramesTotal(){} // RVA: 0x6CE7780
        public void get_NumDroppedFrames(){} // RVA: 0xB8F8F0
        public void set_NumDroppedFrames(){} // RVA: 0xB460A0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x116A650
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x116BB10
        public void get_NumEncodedFrames(){} // RVA: 0xE62D00
        public void set_NumEncodedFrames(){} // RVA: 0x1033F40
        public void get_TotalEncodedSeconds(){} // RVA: 0x2244FB0
        public void set_TotalEncodedSeconds(){} // RVA: 0x22735B0
        public void get_AudioCaptureSource(){} // RVA: 0xFEAE90
        public void set_AudioCaptureSource(){} // RVA: 0x1269760
        public void get_UnityAudioSampleRate(){} // RVA: 0x15AF000
        public void set_UnityAudioSampleRate(){} // RVA: 0x1FAA840
        public void get_UnityAudioChannelCount(){} // RVA: 0x1065D50
        public void set_UnityAudioChannelCount(){} // RVA: 0x13233D0
        public void ResetFPS(){} // RVA: 0x6CE7790
        public void UpdateFPS(){} // RVA: 0x6CE77A0
        public void .ctor(){} // RVA: 0x6CE7820
    }

    public class Codec : Object
    {
        // ── Methods ──
        public void get_CodecType(){} // RVA: 0xB8F8F0
        public void get_Index(){} // RVA: 0x116A650
        public void get_Name(){} // RVA: 0xB465B0
        public void get_MediaApi(){} // RVA: 0x15AF000
        public void get_HasConfigwindow(){} // RVA: 0xC38360
        public void ShowConfigWindow(){} // RVA: 0x6CF2440
        public void .ctor(){} // RVA: 0x6CF25A0
    }

    public class CodecList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CF2620
        public void FindCodec(){} // RVA: 0x6CF2720
        public void GetFirstWithMediaApi(){} // RVA: 0x6CF27F0
        public void GetEnumerator(){} // RVA: 0x2556F20
        public void get_Codecs(){} // RVA: 0xB5DBF0
        public void get_Count(){} // RVA: 0x17F0080
    }

    public class CodecManager : Object
    {
        // ── Methods ──
        public void FindCodec(){} // RVA: 0x6CF2850
        public void GetCodecCount(){} // RVA: 0x6CF2970
        public void CheckInit(){} // RVA: 0x6CF29E0
        public void GetCodecs(){} // RVA: 0x6CF2A90
        public void EnumerateCodecs(){} // RVA: 0x6CF2B30
        public void get_VideoCodecs(){} // RVA: 0x6CF3570
        public void get_AudioCodecs(){} // RVA: 0x6CF35D0
        public void .cctor(){} // RVA: 0x6CF3630
    }

    public class Codec[] : Array
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

    public class Device : Object
    {
        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0xB8F8F0
        public void get_Index(){} // RVA: 0x116A650
        public void get_Name(){} // RVA: 0xB465B0
        public void get_MediaApi(){} // RVA: 0xFEAE90
        public void .ctor(){} // RVA: 0x6CF37F0
    }

    public class DeviceList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CF3860
        public void FindDevice(){} // RVA: 0x6CF3960
        public void GetFirstWithMediaApi(){} // RVA: 0x6CF3A30
        public void GetEnumerator(){} // RVA: 0x2556F20
        public void get_Devices(){} // RVA: 0xB5DBF0
        public void get_Count(){} // RVA: 0x17F0080
    }

    public class DeviceManager : Object
    {
        // ── Methods ──
        public void FindDevice(){} // RVA: 0x6CF3A90
        public void GetDeviceCount(){} // RVA: 0x6CF3C00
        public void CheckInit(){} // RVA: 0x6CF3CB0
        public void GetDevices(){} // RVA: 0x6CF3D60
        public void EnumerateDevices(){} // RVA: 0x6CF3DD0
        public void get_AudioInputDevices(){} // RVA: 0x6CF4150
        public void .cctor(){} // RVA: 0x6CF41B0
    }

    public class Device[] : Array
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

    public class EncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CE7900
        public void SetDefaults(){} // RVA: 0x6CE7900
    }

    public class FileWritingHandler : Object
    {
        // ── Methods ──
        public void get_Status(){} // RVA: 0xE32C80
        public void get_Path(){} // RVA: 0xB5DBF0
        public void get_CompletedFileWritingAction(){} // RVA: 0xBBFF90
        public void set_CompletedFileWritingAction(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0x6CF42B0
        public void SetFilePostProcess(){} // RVA: 0x6CF4390
        public void StartPostProcess(){} // RVA: 0x6CF43F0
        public void IsFileReady(){} // RVA: 0x6CF4530
        public void Dispose(){} // RVA: 0x6CF4730
        public void Cleanup(){} // RVA: 0x6CF49E0
    }

    public class FileWritingHandler[] : Array
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

    public class IMediaApiItem
    {
        // ── Methods ──
        public void get_Index(){} // RVA: 0x87C130
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_MediaApi(){} // RVA: 0x87C130
    }

    public class ImageEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CE78B0
        public void SetDefaults(){} // RVA: 0x6CE78B0
        public void Validate(){} // RVA: 0x6CE78D0
    }

    public class MP4FileProcessing : Object
    {
        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x6CF4AD0
        public void ProcessFile(){} // RVA: 0x6CF5110
        public void .ctor(){} // RVA: 0x6CF5510
        public void Process(){} // RVA: 0x6CF56C0
        public void Close(){} // RVA: 0x6CF6190
        public void GetFirstChunkOfType(){} // RVA: 0x6CF6390
        public void ReadChildChunks(){} // RVA: 0x6CF65F0
        public void ReadChunkHeader(){} // RVA: 0x6CF67F0
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x6CF69D0
        public void ChunkDesc(){} // RVA: 0x6CF6B40
        public void WriteChunk(){} // RVA: 0x6CF6E80
        public void CopyChunkHeader(){} // RVA: 0x6CF6F00
        public void InjectChunkHeader(){} // RVA: 0x6CF6F80
        public void CopyBytes(){} // RVA: 0x6CF7000
        public void WriteZeros(){} // RVA: 0x6CF7110
        public void WriteChunkRecursive_moov(){} // RVA: 0x6CF71C0
        public void IsVideoTrack(){} // RVA: 0x6CF78C0
        public void WriteChunk_stco(){} // RVA: 0x6CF7A10
        public void WriteChunk_co64_from_stco(){} // RVA: 0x6CF7B00
        public void WriteChunk_co64(){} // RVA: 0x6CF7C30
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x6CF7D20
        public void WriteChunk_stsd(){} // RVA: 0x6CF7E80
        public void Convert(){} // RVA: 0x6CF8390
        public void InjectChunk_st3d(){} // RVA: 0x6CF83B0
        public void InjectChunk_sv3d(){} // RVA: 0x6CF8480
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x6CF85F0
        public void InjectChunk_svhd(){} // RVA: 0x6CF8880
        public void InjectChunk_proj(){} // RVA: 0x6CF8AC0
        public void InjectChunk_prhd(){} // RVA: 0x6CF8E90
        public void InjectChunk_equi(){} // RVA: 0x6CF8FF0
        public void OverwriteChunkSize(){} // RVA: 0x6CF9160
        public void ReadUInt16(){} // RVA: 0x6CF9220
        public void ReadUInt32(){} // RVA: 0x6CF9330
        public void ReadUInt64(){} // RVA: 0x6CF9440
        public void WriteUInt16(){} // RVA: 0x6CF9550
        public void WriteChunkId(){} // RVA: 0x6CF9640
        public void WriteUInt32(){} // RVA: 0x6CF9650
        public void WriteUInt64(){} // RVA: 0x6CF9750
        public void ChunkIdToString(){} // RVA: 0x6CF9840
        public void ChunkId(){} // RVA: 0x6CF9AB0
        public void DebugLog(){} // RVA: 0x6CF9B00
        public void .cctor(){} // RVA: 0x6CF9B50
    }

    public class MotionBlur : MonoBehaviour
    {
        // ── Methods ──
        public void get_IsFrameAccumulated(){} // RVA: 0x23DB790
        public void set_IsFrameAccumulated(){} // RVA: 0x23D9930
        public void get_NumSamples(){} // RVA: 0x15AF000
        public void set_NumSamples(){} // RVA: 0x6CDE2B0
        public void get_FrameCount(){} // RVA: 0xBE5890
        public void get_FinalTexture(){} // RVA: 0xD33E60
        public void Awake(){} // RVA: 0x6CDE2C0
        public void SetTargetSize(){} // RVA: 0x6CDE360
        public void Start(){} // RVA: 0x6CDE380
        public void OnEnable(){} // RVA: 0x6CDE390
        public void Setup(){} // RVA: 0x6CDE3B0
        public void ClearAccumulation(){} // RVA: 0x6CDED20
        public void OnDestroy(){} // RVA: 0x6CDEEC0
        public void OnNumSamplesChanged(){} // RVA: 0x6CDF440
        public void LerpUnclamped(){} // RVA: 0x6CDF580
        public void ApplyWeighting(){} // RVA: 0x6CDF590
        public void Accumulate(){} // RVA: 0x6CDF670
        public void OnRenderImage(){} // RVA: 0x6CDF760
        public void .ctor(){} // RVA: 0x6CDF7E0
    }

    public class MouseCursor : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6CDF840
        public void SetTexture(){} // RVA: 0x6CDFA20
        public void OnGUI(){} // RVA: 0x6CDFBF0
        public void .ctor(){} // RVA: 0x6CDFF00
    }

    public class NativePlugin : Object
    {
        // ── Methods ──
        public void AddAmbisonicSourceInstance(){} // RVA: 0x6CE37F0
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x6CE3870
        public void UpdateAmbisonicWeights(){} // RVA: 0x6CE38F0
        public void EncodeMonoToAmbisonic(){} // RVA: 0x6CE39C0
        public void RenderThreadEvent(){} // RVA: 0x6CE3AA0
        public void get_RenderCaptureEventFunction(){} // RVA: 0x6CE3D30
        public void get_RenderFreeEventFunction(){} // RVA: 0x6CE3E40
        public void GetRenderEventFunc(){} // RVA: 0x6CE3F50
        public void GetFreeResourcesEventFunc(){} // RVA: 0x6CE3FC0
        public void Init(){} // RVA: 0x6CE4030
        public void Deinit(){} // RVA: 0x6CE40A0
        public void SetMicrophoneRecordingHint(){} // RVA: 0x6CE4110
        public void GetPluginVersionString(){} // RVA: 0x6CE41A0
        public void IsTrialVersion(){} // RVA: 0x6CE42A0
        public void IsBasicEdition(){} // RVA: 0x6CE4310
        public void GetVideoCodecCount(){} // RVA: 0x6CE4540
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x6CE45B0
        public void GetVideoCodecMediaApi(){} // RVA: 0x6CE4630
        public void ConfigureVideoCodec(){} // RVA: 0x6CE46B0
        public void GetVideoCodecName(){} // RVA: 0x6CE5E80
        public void GetAudioCodecCount(){} // RVA: 0x6CE4910
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x6CE4980
        public void GetAudioCodecMediaApi(){} // RVA: 0x6CE4A00
        public void ConfigureAudioCodec(){} // RVA: 0x6CE4A80
        public void GetAudioCodecName(){} // RVA: 0x6CE5F50
        public void GetAudioInputDeviceCount(){} // RVA: 0x6CE4CE0
        public void GetAudioInputDeviceName(){} // RVA: 0x6CE6020
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x6CE4F30
        public void GetContainerFileExtensions(){} // RVA: 0x6CE60F0
        public void CreateRecorderVideo(){} // RVA: 0x6CE5280
        public void CreateRecorderImages(){} // RVA: 0x6CE5390
        public void CreateRecorderPipe(){} // RVA: 0x6CE54A0
        public void Start(){} // RVA: 0x6CE5590
        public void IsNewFrameDue(){} // RVA: 0x6CE5610
        public void SetEncodedFrameLimit(){} // RVA: 0x6CE5690
        public void EncodeFrame(){} // RVA: 0x6CE5720
        public void EncodeAudio(){} // RVA: 0x6CE57B0
        public void EncodeFrameWithAudio(){} // RVA: 0x6CE5850
        public void Pause(){} // RVA: 0x6CE58F0
        public void Stop(){} // RVA: 0x6CE5970
        public void IsFileWritingComplete(){} // RVA: 0x6CE5A00
        public void SetTexturePointer(){} // RVA: 0x6CE5A80
        public void FreeRecorder(){} // RVA: 0x6CE5B10
        public void GetNumDroppedFrames(){} // RVA: 0x6CE5B90
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x6CE5C10
        public void GetNumEncodedFrames(){} // RVA: 0x6CE5C90
        public void GetEncodedSeconds(){} // RVA: 0x6CE5D10
        public void GetFileSize(){} // RVA: 0x6CE5D90
        public void GetPluginVersion(){} // RVA: 0x6CE5E10
        public void SetLogFunction(){} // RVA: 0x6CE61D0
        public void SetErrorHandler(){} // RVA: 0x6CE6250
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6CE62E0
    }

    public class TimelineController : MonoBehaviour
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0xFEAE90
        public void set_ScanFrequency(){} // RVA: 0x6CDFFA0
        public void Awake(){} // RVA: 0x6CDFFB0
        public void OnValidate(){} // RVA: 0x6CDFFB0
        public void UpdateFrame(){} // RVA: 0x6CDFFC0
        public void StartCapture(){} // RVA: 0x6CDFFD0
        public void StopCapture(){} // RVA: 0x6CE0140
        public void ScanForPlayableDirectors(){} // RVA: 0x6CE03E0
        public void OnDestroy(){} // RVA: 0x6CE0760
        public void ResetSceneLoading(){} // RVA: 0x6CE0810
        public void OnSceneLoaded(){} // RVA: 0x6CE0900
        public void .ctor(){} // RVA: 0x6CE0910
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0xDAC980
        public void get_SampleRate(){} // RVA: 0x87C130
        public void get_ChannelCount(){} // RVA: 0x87C130
        public void PrepareCapture(){} // RVA: 0x894290
        public void StartCapture(){} // RVA: 0x894290
        public void StopCapture(){} // RVA: 0x894290
        public void FlushBuffer(){} // RVA: 0x894290
        public void ReadData(){} // RVA: 0x6CE0E70
        public void GetUnityAudioChannelCount(){} // RVA: 0x6CE0E80
        public void GetChannelCount(){} // RVA: 0x6CE0FC0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x6CFA4F0
        public void HasAlphaChannel(){} // RVA: 0x6CFA570
        public void GetBestRenderTextureFormat(){} // RVA: 0x6CFA5E0
        public void GetUltimateRenderCamera(){} // RVA: 0x6CFA9A0
        public void HasContributingCameras(){} // RVA: 0x6CFAC00
        public void FindContributingCameras(){} // RVA: 0x6CFAD30
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x6CFB510
        public void ShowInExplorer(){} // RVA: 0x6CFB970
        public void OpenInDefaultApp(){} // RVA: 0x6CFBAD0
        public void GetFileSize(){} // RVA: 0x6CFBC10
        public void GetDiskFreeSpaceEx(){} // RVA: 0x6CFBC90
        public void DriveFreeBytes(){} // RVA: 0x6CFBD60
        public void GetImageFileExtension(){} // RVA: 0x6CFBF20
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6CFBFE0
    }

    public class VideoEncoderHints : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CE7830
        public void SetDefaults(){} // RVA: 0x6CE7830
        public void Validate(){} // RVA: 0x6CE7880
    }

    public class VideoPlayerController : MonoBehaviour
    {
        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0xFEAE90
        public void set_ScanFrequency(){} // RVA: 0x6CE1030
        public void Awake(){} // RVA: 0x6CE1040
        public void Start(){} // RVA: 0xB43310
        public void OnValidate(){} // RVA: 0x6CE1040
        public void Update(){} // RVA: 0xB43310
        public void UpdateFrame(){} // RVA: 0x6CE1050
        public void CanContinue(){} // RVA: 0x6CE12A0
        public void WaitforSeekCompletes(){} // RVA: 0x6CE1420
        public void WaitforSeekCompletes2(){} // RVA: 0xB43310
        public void StartCapture(){} // RVA: 0x6CE14C0
        public void StopCapture(){} // RVA: 0x6CE1750
        public void ScanForVideoPlayers(){} // RVA: 0x6CE19B0
        public void OnDestroy(){} // RVA: 0x6CE1DB0
        public void ResetSceneLoading(){} // RVA: 0x6CE1E60
        public void OnSceneLoaded(){} // RVA: 0x6CE1F50
        public void .ctor(){} // RVA: 0x6CE1F60
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x6CE20D0
    }

    public class WavWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CFC750
        public void Dispose(){} // RVA: 0x6CFC8F0
        public void WriteInterleaved(){} // RVA: 0x6CFC9C0
        public void WriteHeader(){} // RVA: 0x6CFCD60
        public void PackageInt(){} // RVA: 0x6CFD430
        public void .cctor(){} // RVA: 0x6CFD540
    }

}