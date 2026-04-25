// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 29
// Methods: 630

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        public int MaxCoeffs;
        public float[] _weightsFuMa;
        public float[] _weightsSN3D; // 0x8

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
        public RenderHeads.Media.AVProMovieCapture.AmbisonicWavWriter _sink; // 0x20
        public UnityEngine.Transform _listener; // 0x28
        public UnityEngine.Vector3 _position; // 0x30
        public 0x665D73F0 _order; // 0x3C
        public 0x665D74A0 _channelOrder; // 0x40
        public 0x665D74F8 _normalisation; // 0x44
        public UIntPtr _sourceInstance; // 0x48
        public int _activeSampleIndex; // 0x50
        public float[] _activeSamples; // 0x58
        public System.Collections.Generic.Queue`1<float[]> _fullBuffers; // 0x60
        public System.Collections.Generic.Queue`1<float[]> _emptyBuffers; // 0x68

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
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Order; // 0x20
        public 0x665D73F0 Format; // 0x28
        public 0x665D7448 _format; // 0x2C
        public string _filename; // 0x30
        public int _bufferCount; // 0x38
        public float[] _outSamples; // 0x40
        public RenderHeads.Media.AVProMovieCapture.WavWriter _wavWriter; // 0x48
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProMovieCapture.AmbisonicSource> _sources; // 0x50
        public int _pendingSampleCount; // 0x58

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
        public string _filename; // 0x20
        public RenderHeads.Media.AVProMovieCapture.WavWriter _wavWriter; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD53E0ECB0
        public void OnDisable(){} // RVA: 0x7FFD53E0EED0
        public void OnAudioFilterRead(){} // RVA: 0x7FFD53E0EF50
        public void .ctor(){} // RVA: 0x7FFD53E0EF80
    }

    public class CameraSelector : MonoBehaviour
    {
        public 0x665D6898 Camera; // 0x20
        public 0x665D68F0 SelectBy; // 0x24
        public bool ScanFrequency; // 0x28
        public string ScanHiddenCameras; // 0x30
        public string SelectTag; // 0x38
        public UnityEngine.Camera SelectName; // 0x40
        public UnityEngine.Camera[] _cameraCache; // 0x48
        public int _cameraCount; // 0x50
        public int _cameraCacheFrame; // 0x54
        public bool _selectionDirty; // 0x58

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
        public RenderHeads.Media.AVProMovieCapture.CaptureBase _capture; // 0x20
        public UnityEngine.AudioClip _audioClip; // 0x28
        public int _videoOffsetInSamples; // 0x30
        public int _committedFrames; // 0x34
        public int _committedSamples; // 0x38
        public int _lastCommittedSample; // 0x3C
        public float[] _frameBuffer; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD53E0FF40
        public void Update(){} // RVA: 0x7FFD53E102F0
        public void GetAudioSamplesForFrame(){} // RVA: 0x7FFD53E10400
        public void .ctor(){} // RVA: 0x7FFD4E7DC840
    }

    public class CaptureAudioFromAudioListener : UnityAudioCapture
    {
        public bool Buffer; // 0x20
        public bool BufferLength; // 0x21
        public int BufferPtr;
        public float[] OverflowCount; // 0x28
        public float[] SampleRate; // 0x30
        public int ChannelCount; // 0x38
        public System.Runtime.InteropServices.GCHandle _bufferHandle; // 0x40
        public int _numChannels; // 0x48
        public int _overflowCount; // 0x4C
        public object _lockObject; // 0x50

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
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Capture; // 0x20
        public int SampleRate; // 0x28
        public bool ChannelCount; // 0x2C
        public Unity.Collections.NativeArray`1<float> _audioBuffer; // 0x30

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
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Capture; // 0x20

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
        public string OutputTarget;
        public 0x665D79C8 OutputFolder; // 0x20
        public 0x665D79C8 OutputFolderPath; // 0x28
        public 0x665D79C8 FilenamePrefix; // 0x30
        public 0x665D79C8 AppendFilenameTimestamp; // 0x38
        public 0x664DD1A8 AllowManualFileExtension; // 0x40
        public bool FilenameExtension; // 0x44
        public bool NamedPipePath; // 0x45
        public 0x665D8628 ImageSequenceStartFrame; // 0x48
        public 0x665D8680 ImageSequenceZeroDigits; // 0x4C
        public float UseMotionBlur; // 0x50
        public 0x665D85D0 MotionBlurSamples; // 0x54
        public int MotionBlurCameras; // 0x58
        public float MotionBlur; // 0x5C
        public string[] ActiveFilePaths;
        public string[] LastFilePath; // 0x8
        public string[] BeginFinalFileWritingAction; // 0x10
        public string[] CompletedFileWritingAction; // 0x18
        public string[] Stats; // 0x20
        public string[] CameraRenderResolution; // 0x28
        public string[] CameraRenderCustomResolution; // 0x30
        public string[] CameraRenderAntiAliasing; // 0x38
        public string[] IsRealTime; // 0x40
        public string[] PersistAcrossSceneLoads; // 0x48
        public string[] AudioCaptureSource; // 0x50
        public string[] ManualAudioSampleRate; // 0x60
        public string[] ManualAudioChannelCount; // 0x68
        public string[] UnityAudioCapture; // 0x70
        public string[] ForceAudioInputDeviceIndex; // 0x78
        public string[] FrameRate; // 0x80
        public string[] StartTrigger; // 0x88
        public float StartDelay; // 0x90
        public int StartDelaySeconds; // 0x94
        public 0x665D7C30 StopMode; // 0x98
        public 0x665D7B80 StopAfterFramesElapsed; // 0x9C
        public UnityEngine.Vector2 StopAfterSecondsElapsed; // 0xA0
        public int CaptureStats; // 0xA8
        public int VideoCodecPriorityWindows; // 0xAC
        public int VideoCodecPriorityMacOS; // 0xB0
        public int AudioCodecPriorityWindows; // 0xB4
        public int AudioCodecPriorityMacOS; // 0xB8
        public int TimelapseScale; // 0xBC
        public int FrameUpdate; // 0xC0
        public int ResolutionDownScale; // 0xC4
        public bool ResolutionDownscaleCustom; // 0xC8
        public bool FlipVertically; // 0xC9
        public bool UseWaitForEndOfFrame; // 0xCA
        public bool LogCaptureStartStop; // 0xCB
        public bool AllowOfflineVSyncDisable; // 0xCC
        public 0x665D84C8 SupportTextureRecreate; // 0xD0
        public RenderHeads.Media.AVProMovieCapture.UnityAudioCapture TimelineController; // 0xD8
        public int VideoPlayerController; // 0xE0
        public int SelectedVideoCodec; // 0xE4
        public int SelectedAudioCodec; // 0xE8
        public 0x665D8730 SelectedAudioInputDevice; // 0xEC
        public 0x665D7BD8 NativeForceVideoCodecIndex;
        public string NativeForceAudioCodecIndex;
        public 0x665D7BD8 NativeImageSequenceFormat; // 0xF0
        public string LastFileSaved; // 0xF8
        public string _filenamePrefix; // 0x100
        public bool _appendFilenameTimestamp; // 0x108
        public bool _allowManualFileExtension; // 0x109
        public string _filenameExtension; // 0x110
        public string _namedPipePath; // 0x118
        public int _imageSequenceStartFrame; // 0x120
        public int _imageSequenceZeroDigits; // 0x124
        public 0x665D86D8 _imageSequenceFormatWindows; // 0x128
        public 0x665D86D8 _imageSequenceFormatMacOS; // 0x12C
        public 0x665D86D8 _imageSequenceFormatIOS; // 0x130
        public 0x665D86D8 _imageSequenceFormatAndroid; // 0x134
        public 0x665D7A20 _renderResolution; // 0x138
        public UnityEngine.Vector2 _renderSize; // 0x13C
        public int _renderAntiAliasing; // 0x144
        public bool _useMotionBlur; // 0x148
        public int _motionBlurSamples; // 0x14C
        public UnityEngine.Camera[] _motionBlurCameras; // 0x150
        public RenderHeads.Media.AVProMovieCapture.MotionBlur _motionBlur; // 0x158
        public bool _allowVSyncDisable; // 0x160
        public bool _supportTextureRecreate; // 0x161
        public int _minimumDiskSpaceMB; // 0x164
        public RenderHeads.Media.AVProMovieCapture.TimelineController _timelineController; // 0x168
        public RenderHeads.Media.AVProMovieCapture.VideoPlayerController _videoPlayerController; // 0x170
        public UnityEngine.Texture2D _texture; // 0x178
        public int _handle; // 0x180
        public int _sourceWidth; // 0x184
        public int _sourceHeight; // 0x188
        public int _targetWidth; // 0x18C
        public int _targetHeight; // 0x190
        public bool _capturing; // 0x194
        public bool _paused; // 0x195
        public string _filePath; // 0x198
        public string _finalFilePath; // 0x1A0
        public System.IO.FileInfo _fileInfo; // 0x1A8
        public 0x665D75A8 _pixelFormat; // 0x1B0
        public 0x665D7F48 _selectedVideoCodec; // 0x1B8
        public 0x665D7F48 _selectedAudioCodec; // 0x1C0
        public 0x665D8100 _selectedAudioInputDevice; // 0x1C8
        public int _oldVSyncCount; // 0x1D0
        public float _oldFixedDeltaTime; // 0x1D4
        public bool _isTopDown; // 0x1D8
        public bool _isDirectX11; // 0x1D9
        public bool _queuedStartCapture; // 0x1DA
        public bool _queuedStopCapture; // 0x1DB
        public float _captureStartTime; // 0x1DC
        public float _capturePrePauseTotalTime; // 0x1E0
        public float _timeSinceLastFrame; // 0x1E4
        public UnityEngine.YieldInstruction _waitForEndOfFrame; // 0x1E8
        public long _freeDiskSpaceMB; // 0x1F0
        public float _startDelayTimer; // 0x1F8
        public bool _startPaused; // 0x1FC
        public System.Action`1<RenderHeads.Media.AVProMovieCapture.FileWritingHandler> _beginFinalFileWritingAction; // 0x200
        public System.Action`1<RenderHeads.Media.AVProMovieCapture.FileWritingHandler> _completedFileWritingAction; // 0x208
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProMovieCapture.FileWritingHandler> _pendingFileWrites; // 0x210
        public System.Collections.Generic.HashSet`1<string> _activeFilePaths; // 0x58
        public 0x665D7810 _stats; // 0x218
        public bool _isInitialised; // 0x60
        public bool _isApplicationQuiting; // 0x61
        public bool _waitingForAudioCaptureDeviceAuthorisation; // 0x62
        public bool _hasCheckedAudioCaptureDeviceAuthorisationStatus; // 0x63
        public 0x665D7C88 _audioCaptureDeviceAuthorisationStatus; // 0x64
        public bool _waitingForAuthorisationToAccessPhotos; // 0x68
        public bool _hasCheckedPhotoLibraryAuthorisationStatus; // 0x69
        public 0x665D7D90 _photoLibraryAuthorisation; // 0x6C

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
        public RenderHeads.Media.AVProMovieCapture.CameraSelector CameraSelector; // 0x220
        public UnityEngine.Camera UseContributingCameras; // 0x228
        public UnityEngine.Camera[] _contribCameras; // 0x230
        public bool _useContributingCameras; // 0x238
        public bool _supportTransparency; // 0x239
        public UnityEngine.RenderTexture _target; // 0x240
        public UnityEngine.RenderTexture _resolveTexture; // 0x248
        public UIntPtr _targetNativePointer; // 0x250
        public UnityEngine.Texture _targetNativeTexture; // 0x258
        public UnityEngine.Texture _previewTexture; // 0x260

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
        public RenderHeads.Media.AVProMovieCapture.CameraSelector CameraSelector; // 0x220
        public 0x665D7AD0 CubemapFaceResolution; // 0x228
        public 0x665D7A78 CubemapDepthResolution; // 0x22C
        public bool SupportGUI; // 0x230
        public bool SupportCameraRotation; // 0x231
        public bool OnlyLeftRightRotation; // 0x232
        public bool Render180Degrees; // 0x233
        public 0x665D8520 StereoRendering; // 0x234
        public float IPD; // 0x238
        public UnityEngine.Camera _camera; // 0x240
        public UnityEngine.RenderTexture _faceTarget; // 0x248
        public UnityEngine.Material _blitMaterial; // 0x250
        public UnityEngine.Material _cubemapToEquirectangularMaterial; // 0x258
        public UnityEngine.RenderTexture _cubeTarget; // 0x260
        public UnityEngine.RenderTexture _finalTarget; // 0x268
        public UIntPtr _targetNativePointer; // 0x270
        public int _propFlipX; // 0x278

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
        public 0x665D6D10 Setup; // 0x220
        public int _eyeWidth; // 0x228
        public int _eyeHeight; // 0x22C
        public UnityEngine.Transform _cameraGroup; // 0x230
        public UnityEngine.Camera _leftCameraTop; // 0x238
        public UnityEngine.Camera _leftCameraBot; // 0x240
        public UnityEngine.Camera _rightCameraTop; // 0x248
        public UnityEngine.Camera _rightCameraBot; // 0x250
        public UnityEngine.RenderTexture _final; // 0x258
        public UIntPtr _targetNativePointer; // 0x260
        public UnityEngine.Material _finalMaterial; // 0x268
        public int _propSliceCenter; // 0x270

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
        public bool CaptureMouseCursor; // 0x220
        public RenderHeads.Media.AVProMovieCapture.MouseCursor MouseCursor; // 0x228
        public UIntPtr _targetNativePointer; // 0x230
        public UnityEngine.RenderTexture _resolveTexture; // 0x238
        public UnityEngine.Rendering.CommandBuffer _commandBuffer; // 0x240

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
        public bool IsManualUpdate; // 0x220
        public UnityEngine.Texture _sourceTexture; // 0x228
        public UnityEngine.RenderTexture _resolveTexture; // 0x230
        public UIntPtr _targetNativePointer; // 0x238
        public bool _isSourceTextureChanged; // 0x240

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
        public RenderHeads.Media.AVProMovieCapture.CaptureBase MovieCapture; // 0x20
        public bool HideUiWhenRecording; // 0x28
        public bool ShowUI; // 0x29
        public UnityEngine.GUISkin _guiSkin; // 0x30
        public string[] CommonFrameRateNames;
        public float[] CommonFrameRateValues; // 0x8
        public 0x665D6FD0 _shownSection; // 0x38
        public string[] _videoCodecNames; // 0x40
        public string[] _audioCodecNames; // 0x48
        public bool[] _videoCodecConfigurable; // 0x50
        public bool[] _audioCodecConfigurable; // 0x58
        public string[] _audioDeviceNames; // 0x60
        public string[] _downScales; // 0x68
        public string[] _outputType; // 0x70
        public int _downScaleIndex; // 0x78
        public UnityEngine.GUIStyle _tintableBox; // 0x80
        public UnityEngine.Vector2 _videoPos; // 0x88
        public UnityEngine.Vector2 _audioPos; // 0x90
        public UnityEngine.Vector2 _audioCodecPos; // 0x98
        public UnityEngine.Vector2 _imageCodecPos; // 0xA0
        public long _lastFileSize; // 0xA8
        public uint _lastEncodedMinutes; // 0xB0
        public uint _lastEncodedSeconds; // 0xB4
        public uint _lastEncodedFrame; // 0xB8

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
        public bool VideoCodecs;
        public 0x665D7FA0 AudioCodecs; // 0x8
        public 0x665D7FA0 _audioCodecs; // 0x10

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
        public bool AudioInputDevices;
        public 0x665D8158 _audioInputDevices; // 0x8

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
        public string Status; // 0x10
        public int Path; // 0x18
        public bool CompletedFileWritingAction; // 0x1C
        public 0x665D8730 _outputTarget; // 0x20
        public 0x665D82B8 _postOptions; // 0x28
        public System.Threading.ManualResetEvent _postProcessEvent; // 0x48
        public 0x665D8208 _completionStatus; // 0x50
        public string _finalFilePath; // 0x58
        public bool _updateMediaGallery; // 0x60
        public System.Action`1<RenderHeads.Media.AVProMovieCapture.FileWritingHandler> <CompletedFileWritingAction>k__BackingField; // 0x68

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
        public int ChunkHeaderSize;
        public int ExtendedChunkHeaderSize;
        public int CopyBufferSize;
        public uint Atom_moov;
        public uint Atom_mdat; // 0x4
        public uint Atom_cmov; // 0x8
        public uint Atom_trak; // 0xC
        public uint Atom_mdia; // 0x10
        public uint Atom_hdlr; // 0x14
        public uint Atom_minf; // 0x18
        public uint Atom_stbl; // 0x1C
        public uint Atom_stco; // 0x20
        public uint Atom_co64; // 0x24
        public uint Atom_stsd; // 0x28
        public uint Atom_avc1; // 0x2C
        public uint Atom_hev1; // 0x30
        public uint Atom_hvc1; // 0x34
        public uint Atom_st3d; // 0x38
        public uint Atom_uuid; // 0x3C
        public uint Atom_sv3d; // 0x40
        public uint Atom_svhd; // 0x44
        public uint Atom_proj; // 0x48
        public uint Atom_prhd; // 0x4C
        public uint Atom_equi; // 0x50
        public 0x66442F98 _reader; // 0x10
        public System.IO.Stream _writeFile; // 0x18
        public 0x665D82B8 _options; // 0x20
        public bool _requires64BitOffsets; // 0x40
        public System.Collections.Generic.List`1<0x665D8310> _offsetChunks; // 0x48
        public System.Collections.Generic.List`1<0x665D8310> _offsetUpgradeChunks; // 0x50

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
        public 0x664DC180 IsFrameAccumulated; // 0x20
        public int NumSamples; // 0x24
        public UnityEngine.RenderTexture FrameCount; // 0x28
        public UnityEngine.RenderTexture FinalTexture; // 0x30
        public UnityEngine.Material _addMaterial; // 0x38
        public UnityEngine.Material _divMaterial; // 0x40
        public int _frameCount; // 0x48
        public int _targetWidth; // 0x4C
        public int _targetHeight; // 0x50
        public bool _isDirty; // 0x54
        public int _propNumSamples;
        public int _propWeight; // 0x4
        public bool <IsFrameAccumulated>k__BackingField; // 0x55
        public float _bias; // 0x58
        public float _total; // 0x5C

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
        public UnityEngine.Texture2D _texture; // 0x20
        public UnityEngine.Vector2 _hotspotOffset; // 0x28
        public int _sizeScale; // 0x30
        public int _depth; // 0x34
        public UnityEngine.GUIContent _content; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD53E29720
        public void SetTexture(){} // RVA: 0x7FFD53E29730
        public void OnGUI(){} // RVA: 0x7FFD53E29930
        public void .ctor(){} // RVA: 0x7FFD53E29BE0
    }

    public class NativePlugin : Object
    {
        public string RenderCaptureEventFunction;
        public string RenderFreeEventFunction;
        public string PluginName;
        public string[] PlatformNames;
        public string[] VideoCodecNamesMacOS; // 0x8
        public string[] AudioCodecNamesMacOS; // 0x10
        public string[] VideoCodecNamesIOS; // 0x18
        public string[] AudioCodecNamesIOS; // 0x20
        public string[] VideoCodecNamesAndroid; // 0x28
        public string[] AudioCodecNamesAndroid; // 0x30
        public int MaxRenderWidth;
        public int MaxRenderHeight;
        public int PluginID;
        public UIntPtr _renderEventFunction; // 0x38
        public UIntPtr _freeEventFunction; // 0x40

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
        public 0x665D7130 ScanFrequency; // 0x20
        public System.Collections.Generic.List`1<0x665D7188> _timelines; // 0x28

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
        public string[] WindowsImageSequenceFormatNames;
        public string[] MacOSImageSequenceFormatNames; // 0x8
        public string[] IOSImageSequenceFormatNames; // 0x10
        public string[] AndroidImageSequenceFormatNames; // 0x18

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
        public 0x665D7290 ScanFrequency; // 0x20
        public System.Collections.Generic.List`1<0x665D72E8> _instances; // 0x28

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
        public byte[] RIFF_HEADER;
        public byte[] FORMAT_WAVE; // 0x8
        public byte[] FORMAT_TAG; // 0x10
        public byte[] AUDIO_FORMAT_PCM; // 0x18
        public byte[] AUDIO_FORMAT_FLOAT; // 0x20
        public byte[] SUBCHUNK_ID; // 0x28
        public byte[] FACTCHUNK_ID; // 0x30
        public int BufferDuration;
        public System.IO.FileStream _stream; // 0x10
        public byte[] _outBytes; // 0x18
        public int _byteCount; // 0x20
        public int _byteCountTotal; // 0x24
        public int _channelCount; // 0x28
        public int _sampleRate; // 0x2C
        public 0x665D8838 _sampleFormat; // 0x30
        public int _headerSize; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53E46860
        public void Dispose(){} // RVA: 0x7FFD53E469F0
        public void WriteInterleaved(){} // RVA: 0x7FFD53E46AC0
        public void WriteHeader(){} // RVA: 0x7FFD53E46E40
        public void PackageInt(){} // RVA: 0x7FFD53E47510
        public void .cctor(){} // RVA: 0x7FFD53E47620
    }

}