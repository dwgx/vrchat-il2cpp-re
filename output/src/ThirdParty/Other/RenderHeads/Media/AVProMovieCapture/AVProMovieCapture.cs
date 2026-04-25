// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
// Classes: 38
// Methods: 684

namespace ThirdParty.Other.RenderHeads.Media.AVProMovieCapture
{
    public class Ambisonic : Object
    {
        public int MaxCoeffs;
        public float[] _weightsFuMa;
        public float[] _weightsSN3D; // 0x8

        // ── Methods ──
        public void GetNormalisationWeights(){} // RVA: 0x7FFAC8A10670
        public void GetCoeffCount(){} // RVA: 0x7FFAC8A10700
        public void GetChannelOrder(){} // RVA: 0x7FFAC8A10730
        public void GetNormalisation(){} // RVA: 0x7FFAC8A10730
        public void .cctor(){} // RVA: 0x7FFAC8A10740
        public void BuildWeightsFuMa(){} // RVA: 0x7FFAC8A109E0
        public void GetN(){} // RVA: 0x7FFAC8A10CB0
        public void GetM(){} // RVA: 0x7FFAC8A10CF0
        public void Factorial(){} // RVA: 0x7FFAC8A10D70
        public void GetNormalisationSN3D(){} // RVA: 0x7FFAC8A10E80 | overloaded x2
        public void GetNormalisationN3D(){} // RVA: 0x7FFAC8A11000
        public void BuildWeightsSN3D(){} // RVA: 0x7FFAC8A110B0
    }

    public class AmbisonicSource : MonoBehaviour
    {
        public RenderHeads.Media.AVProMovieCapture.AmbisonicWavWriter _sink; // 0x20
        public UnityEngine.Transform _listener; // 0x28
        public UnityEngine.Vector3 _position; // 0x30
        public 0x6B2773F0 _order; // 0x3C
        public 0x6B2774A0 _channelOrder; // 0x40
        public 0x6B2774F8 _normalisation; // 0x44
        public UIntPtr _sourceInstance; // 0x48
        public int _activeSampleIndex; // 0x50
        public float[] _activeSamples; // 0x58
        public System.Collections.Generic.Queue`1<float[]> _fullBuffers; // 0x60
        public System.Collections.Generic.Queue`1<float[]> _emptyBuffers; // 0x68

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC89EB440
        public void OnDisable(){} // RVA: 0x7FFAC89EB870
        public void Setup(){} // RVA: 0x7FFAC89EBB40
        public void OnDrawGizmos(){} // RVA: 0x7FFAC89EBE90
        public void LateUpdate(){} // RVA: 0x7FFAC89EC1A0
        public void SetListenerRelativePosition(){} // RVA: 0x7FFAC89EC430
        public void UpdateCoefficients(){} // RVA: 0x7FFAC89EC450
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC89EC810
        public void FlushBuffers(){} // RVA: 0x7FFAC89ECEC0
        public void GetFullBufferCount(){} // RVA: 0x7FFAC89ED290
        public void SendSamplesToSink(){} // RVA: 0x7FFAC89ED2E0
        public void .ctor(){} // RVA: 0x7FFAC89ED5A0
    }

    public class AmbisonicWavWriter : MonoBehaviour
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Order; // 0x20
        public 0x6B2773F0 Format; // 0x28
        public 0x6B277448 _format; // 0x2C
        public string _filename; // 0x30
        public int _bufferCount; // 0x38
        public float[] _outSamples; // 0x40
        public RenderHeads.Media.AVProMovieCapture.WavWriter _wavWriter; // 0x48
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProMovieCapture.AmbisonicSource> _sources; // 0x50
        public int _pendingSampleCount; // 0x58

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFAC32EC4C0
        public void get_Format(){} // RVA: 0x7FFAC3C891D0
        public void AddSource(){} // RVA: 0x7FFAC89ED760
        public void RemoveSource(){} // RVA: 0x7FFAC89ED930
        public void OnDisable(){} // RVA: 0x7FFAC89EDAB0
        public void SetupSource(){} // RVA: 0x7FFAC89EDAC0
        public void ToggleCapturing(){} // RVA: 0x7FFAC89EDB70
        public void StartCapture(){} // RVA: 0x7FFAC89EDBA0
        public void StopCapture(){} // RVA: 0x7FFAC89EE2D0
        public void IsCapturing(){} // RVA: 0x7FFAC89EE500
        public void LateUpdate(){} // RVA: 0x7FFAC89EE520
        public void ProcessSources(){} // RVA: 0x7FFAC89EE640
        public void MixSamples(){} // RVA: 0x7FFAC89EE950
        public void FlushWavWriter(){} // RVA: 0x7FFAC89EEA70
        public void .ctor(){} // RVA: 0x7FFAC89EEAB0
    }

    public class AudioSourceToWav : MonoBehaviour
    {
        public string _filename; // 0x20
        public RenderHeads.Media.AVProMovieCapture.WavWriter _wavWriter; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC89EECB0
        public void OnDisable(){} // RVA: 0x7FFAC89EEED0
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC89EEF50
        public void .ctor(){} // RVA: 0x7FFAC89EEF80
    }

    public class CameraSelector : MonoBehaviour
    {
        public 0x6B276898 Camera; // 0x20
        public 0x6B2768F0 SelectBy; // 0x24
        public bool ScanFrequency; // 0x28
        public string ScanHiddenCameras; // 0x30
        public string SelectTag; // 0x38
        public UnityEngine.Camera SelectName; // 0x40
        public UnityEngine.Camera[] _cameraCache; // 0x48
        public int _cameraCount; // 0x50
        public int _cameraCacheFrame; // 0x54
        public bool _selectionDirty; // 0x58

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFAC2F9E740
        public void set_Camera(){} // RVA: 0x7FFAC89EF050
        public void get_SelectBy(){} // RVA: 0x7FFAC30DBBE0
        public void set_SelectBy(){} // RVA: 0x7FFAC89EF0C0
        public void get_ScanFrequency(){} // RVA: 0x7FFAC3921980
        public void set_ScanFrequency(){} // RVA: 0x7FFAC89EF0D0
        public void get_ScanHiddenCameras(){} // RVA: 0x7FFAC30F6BA0
        public void set_ScanHiddenCameras(){} // RVA: 0x7FFAC89EF0E0
        public void get_SelectTag(){} // RVA: 0x7FFAC31D95E0
        public void set_SelectTag(){} // RVA: 0x7FFAC89EF0F0
        public void get_SelectName(){} // RVA: 0x7FFAC31D0140
        public void set_SelectName(){} // RVA: 0x7FFAC89EF150
        public void Awake(){} // RVA: 0x7FFAC89EF1B0
        public void Start(){} // RVA: 0x7FFAC89EF1C0
        public void OnValidate(){} // RVA: 0x7FFAC89EF1B0
        public void Update(){} // RVA: 0x7FFAC89EF1D0
        public void OnDestroy(){} // RVA: 0x7FFAC89EF1F0
        public void ResetSceneLoading(){} // RVA: 0x7FFAC89EF290
        public void OnSceneLoaded(){} // RVA: 0x7FFAC89EF380
        public void ScanForCameraChange(){} // RVA: 0x7FFAC89EF390
        public void FindCamera(){} // RVA: 0x7FFAC89EF5C0
        public void UpdateCameraCache(){} // RVA: 0x7FFAC89EF900
        public void FindCameraByHighestDepth(){} // RVA: 0x7FFAC89EFAA0
        public void FindCameraByTag(){} // RVA: 0x7FFAC89EFC20
        public void FindCameraByName(){} // RVA: 0x7FFAC89EFCB0
        public void .ctor(){} // RVA: 0x7FFAC89EFD70
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
        public void OnEnable(){} // RVA: 0x7FFAC89EFF40
        public void Update(){} // RVA: 0x7FFAC89F02F0
        public void GetAudioSamplesForFrame(){} // RVA: 0x7FFAC89F0400
        public void .ctor(){} // RVA: 0x7FFAC33BC840
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
        public void get_Buffer(){} // RVA: 0x7FFAC31D95E0
        public void get_BufferLength(){} // RVA: 0x7FFAC358A870
        public void get_BufferPtr(){} // RVA: 0x7FFAC89F0750
        public void get_OverflowCount(){} // RVA: 0x7FFAC3F2D3C0
        public void get_SampleRate(){} // RVA: 0x7FFAC89F0760
        public void get_ChannelCount(){} // RVA: 0x7FFAC2FC20C0
        public void PrepareCapture(){} // RVA: 0x7FFAC89F07B0
        public void StartCapture(){} // RVA: 0x7FFAC3F5BE50
        public void StopCapture(){} // RVA: 0x7FFAC89F0D30
        public void ReadData(){} // RVA: 0x7FFAC89F0F90
        public void FlushBuffer(){} // RVA: 0x7FFAC89F1120
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC89F1260
        public void .ctor(){} // RVA: 0x7FFAC89F15D0
    }

    public class CaptureAudioFromAudioRenderer : UnityAudioCapture
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Capture; // 0x20
        public int SampleRate; // 0x28
        public bool ChannelCount; // 0x2C
        public Unity.Collections.NativeArray`1<float> _audioBuffer; // 0x30

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Capture(){} // RVA: 0x7FFAC2F4F0D0
        public void get_SampleRate(){} // RVA: 0x7FFAC89F0760
        public void get_ChannelCount(){} // RVA: 0x7FFAC32EC4C0
        public void PrepareCapture(){} // RVA: 0x7FFAC89F1780
        public void GetAudioBufferOfLength(){} // RVA: 0x7FFAC89F17A0
        public void DisposeAudioBuffer(){} // RVA: 0x7FFAC2F21310
        public void StartCapture(){} // RVA: 0x7FFAC89F1970
        public void StopCapture(){} // RVA: 0x7FFAC89F1BE0
        public void FlushBuffer(){} // RVA: 0x7FFAC89F1C70
        public void Update(){} // RVA: 0x7FFAC89F1D60
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CaptureAudioFromWwise : UnityAudioCapture
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase Capture; // 0x20

        // ── Methods ──
        public void get_Capture(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Capture(){} // RVA: 0x7FFAC2F4F0D0
        public void Awake(){} // RVA: 0x7FFAC89F1F20
        public void get_SampleRate(){} // RVA: 0x7FFAC34F9180
        public void get_ChannelCount(){} // RVA: 0x7FFAC34F9180
        public void PrepareCapture(){} // RVA: 0x7FFAC2F21310
        public void FlushBuffer(){} // RVA: 0x7FFAC2F21310
        public void StartCapture(){} // RVA: 0x7FFAC2F21310
        public void StopCapture(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CaptureBase : MonoBehaviour
    {
        public string OutputTarget;
        public RenderHeads.Media.AVProMovieCapture.EncoderHints OutputFolder; // 0x20
        public RenderHeads.Media.AVProMovieCapture.EncoderHints OutputFolderPath; // 0x28
        public RenderHeads.Media.AVProMovieCapture.EncoderHints FilenamePrefix; // 0x30
        public RenderHeads.Media.AVProMovieCapture.EncoderHints AppendFilenameTimestamp; // 0x38
        public 0x6B17D1A8 AllowManualFileExtension; // 0x40
        public bool FilenameExtension; // 0x44
        public bool NamedPipePath; // 0x45
        public 0x6B278628 ImageSequenceStartFrame; // 0x48
        public 0x6B278680 ImageSequenceZeroDigits; // 0x4C
        public float UseMotionBlur; // 0x50
        public 0x6B2785D0 MotionBlurSamples; // 0x54
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
        public 0x6B277C30 StopMode; // 0x98
        public 0x6B277B80 StopAfterFramesElapsed; // 0x9C
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
        public 0x6B2784C8 SupportTextureRecreate; // 0xD0
        public RenderHeads.Media.AVProMovieCapture.UnityAudioCapture TimelineController; // 0xD8
        public int VideoPlayerController; // 0xE0
        public int SelectedVideoCodec; // 0xE4
        public int SelectedAudioCodec; // 0xE8
        public 0x6B278730 SelectedAudioInputDevice; // 0xEC
        public 0x6B277BD8 NativeForceVideoCodecIndex;
        public string NativeForceAudioCodecIndex;
        public 0x6B277BD8 NativeImageSequenceFormat; // 0xF0
        public string LastFileSaved; // 0xF8
        public string _filenamePrefix; // 0x100
        public bool _appendFilenameTimestamp; // 0x108
        public bool _allowManualFileExtension; // 0x109
        public string _filenameExtension; // 0x110
        public string _namedPipePath; // 0x118
        public int _imageSequenceStartFrame; // 0x120
        public int _imageSequenceZeroDigits; // 0x124
        public 0x6B2786D8 _imageSequenceFormatWindows; // 0x128
        public 0x6B2786D8 _imageSequenceFormatMacOS; // 0x12C
        public 0x6B2786D8 _imageSequenceFormatIOS; // 0x130
        public 0x6B2786D8 _imageSequenceFormatAndroid; // 0x134
        public 0x6B277A20 _renderResolution; // 0x138
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
        public 0x6B2775A8 _pixelFormat; // 0x1B0
        public RenderHeads.Media.AVProMovieCapture.Codec _selectedVideoCodec; // 0x1B8
        public RenderHeads.Media.AVProMovieCapture.Codec _selectedAudioCodec; // 0x1C0
        public RenderHeads.Media.AVProMovieCapture.Device _selectedAudioInputDevice; // 0x1C8
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
        public RenderHeads.Media.AVProMovieCapture.CaptureStats _stats; // 0x218
        public bool _isInitialised; // 0x60
        public bool _isApplicationQuiting; // 0x61
        public bool _waitingForAudioCaptureDeviceAuthorisation; // 0x62
        public bool _hasCheckedAudioCaptureDeviceAuthorisationStatus; // 0x63
        public 0x6B277C88 _audioCaptureDeviceAuthorisationStatus; // 0x64
        public bool _waitingForAuthorisationToAccessPhotos; // 0x68
        public bool _hasCheckedPhotoLibraryAuthorisationStatus; // 0x69
        public 0x6B277D90 _photoLibraryAuthorisation; // 0x6C

        // ── Methods ──
        public void get_OutputTarget(){} // RVA: 0x7FFAC47D3260
        public void set_OutputTarget(){} // RVA: 0x7FFAC8A11620
        public void get_OutputFolder(){} // RVA: 0x7FFAC60855D0
        public void set_OutputFolder(){} // RVA: 0x7FFAC8A11630
        public void get_OutputFolderPath(){} // RVA: 0x7FFAC3331F50
        public void set_OutputFolderPath(){} // RVA: 0x7FFAC34A4860
        public void get_FilenamePrefix(){} // RVA: 0x7FFAC34F6C80
        public void set_FilenamePrefix(){} // RVA: 0x7FFAC34F6750
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7FFAC4196030
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7FFAC4196040
        public void get_AllowManualFileExtension(){} // RVA: 0x7FFAC45CA6A0
        public void set_AllowManualFileExtension(){} // RVA: 0x7FFAC45C9FB0
        public void get_FilenameExtension(){} // RVA: 0x7FFAC354B170
        public void set_FilenameExtension(){} // RVA: 0x7FFAC39B3E10
        public void get_NamedPipePath(){} // RVA: 0x7FFAC33BC6D0
        public void set_NamedPipePath(){} // RVA: 0x7FFAC33B8580
        public void get_ImageSequenceStartFrame(){} // RVA: 0x7FFAC8A11640
        public void set_ImageSequenceStartFrame(){} // RVA: 0x7FFAC8A11650
        public void get_ImageSequenceZeroDigits(){} // RVA: 0x7FFAC88D4E90
        public void set_ImageSequenceZeroDigits(){} // RVA: 0x7FFAC8A11660
        public void get_UseMotionBlur(){} // RVA: 0x7FFAC4138670
        public void set_UseMotionBlur(){} // RVA: 0x7FFAC412E500
        public void get_MotionBlurSamples(){} // RVA: 0x7FFAC8A11690
        public void set_MotionBlurSamples(){} // RVA: 0x7FFAC8A116A0
        public void get_MotionBlurCameras(){} // RVA: 0x7FFAC354DFA0
        public void set_MotionBlurCameras(){} // RVA: 0x7FFAC39B99C0
        public void get_MotionBlur(){} // RVA: 0x7FFAC3542410
        public void set_MotionBlur(){} // RVA: 0x7FFAC39A74B0
        public void get_ActiveFilePaths(){} // RVA: 0x7FFAC8A116D0
        public void get_LastFilePath(){} // RVA: 0x7FFAC3541C80
        public void get_BeginFinalFileWritingAction(){} // RVA: 0x7FFAC3544790
        public void set_BeginFinalFileWritingAction(){} // RVA: 0x7FFAC354D230
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFAC3544780
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFAC354D290
        public void get_Stats(){} // RVA: 0x7FFAC3541470
        public void get_CameraRenderResolution(){} // RVA: 0x7FFAC3C8EC30
        public void set_CameraRenderResolution(){} // RVA: 0x7FFAC88C7220
        public void get_CameraRenderCustomResolution(){} // RVA: 0x7FFAC8A11730
        public void set_CameraRenderCustomResolution(){} // RVA: 0x7FFAC8A11750
        public void get_CameraRenderAntiAliasing(){} // RVA: 0x7FFAC40A8560
        public void set_CameraRenderAntiAliasing(){} // RVA: 0x7FFAC40A3880
        public void get_IsRealTime(){} // RVA: 0x7FFAC45A8350
        public void set_IsRealTime(){} // RVA: 0x7FFAC45A8340
        public void get_PersistAcrossSceneLoads(){} // RVA: 0x7FFAC47BA6D0
        public void set_PersistAcrossSceneLoads(){} // RVA: 0x7FFAC47BA6E0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAC3696B20
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAC4591C30
        public void get_ManualAudioSampleRate(){} // RVA: 0x7FFAC47D5FD0
        public void set_ManualAudioSampleRate(){} // RVA: 0x7FFAC67153A0
        public void get_ManualAudioChannelCount(){} // RVA: 0x7FFAC47D5FE0
        public void set_ManualAudioChannelCount(){} // RVA: 0x7FFAC8A11760
        public void get_UnityAudioCapture(){} // RVA: 0x7FFAC3540F70
        public void set_UnityAudioCapture(){} // RVA: 0x7FFAC2FA28A0
        public void get_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFAC4837F50
        public void set_ForceAudioInputDeviceIndex(){} // RVA: 0x7FFAC8A11770
        public void get_FrameRate(){} // RVA: 0x7FFAC2F89540
        public void set_FrameRate(){} // RVA: 0x7FFAC8A11780
        public void get_StartTrigger(){} // RVA: 0x7FFAC2FC20C0
        public void set_StartTrigger(){} // RVA: 0x7FFAC2FC20D0
        public void get_StartDelay(){} // RVA: 0x7FFAC3F2D3C0
        public void set_StartDelay(){} // RVA: 0x7FFAC489E500
        public void get_StartDelaySeconds(){} // RVA: 0x7FFAC2F89460
        public void set_StartDelaySeconds(){} // RVA: 0x7FFAC8A117B0
        public void get_StopMode(){} // RVA: 0x7FFAC38913D0
        public void set_StopMode(){} // RVA: 0x7FFAC3890750
        public void get_StopAfterFramesElapsed(){} // RVA: 0x7FFAC362EA40
        public void set_StopAfterFramesElapsed(){} // RVA: 0x7FFAC8A117C0
        public void get_StopAfterSecondsElapsed(){} // RVA: 0x7FFAC2F4A000
        public void set_StopAfterSecondsElapsed(){} // RVA: 0x7FFAC8A117D0
        public void get_CaptureStats(){} // RVA: 0x7FFAC3541470
        public void get_VideoCodecPriorityWindows(){} // RVA: 0x7FFAC2FBF370
        public void set_VideoCodecPriorityWindows(){} // RVA: 0x7FFAC8A117E0
        public void get_VideoCodecPriorityMacOS(){} // RVA: 0x7FFAC2F9CD50
        public void set_VideoCodecPriorityMacOS(){} // RVA: 0x7FFAC8A11840
        public void get_AudioCodecPriorityWindows(){} // RVA: 0x7FFAC30E5600
        public void set_AudioCodecPriorityWindows(){} // RVA: 0x7FFAC8A118A0
        public void get_AudioCodecPriorityMacOS(){} // RVA: 0x7FFAC32EF410
        public void set_AudioCodecPriorityMacOS(){} // RVA: 0x7FFAC8A11900
        public void get_TimelapseScale(){} // RVA: 0x7FFAC3220670
        public void set_TimelapseScale(){} // RVA: 0x7FFAC342B670
        public void get_FrameUpdate(){} // RVA: 0x7FFAC489E530
        public void set_FrameUpdate(){} // RVA: 0x7FFAC489E540
        public void get_ResolutionDownScale(){} // RVA: 0x7FFAC489E520
        public void set_ResolutionDownScale(){} // RVA: 0x7FFAC489EAA0
        public void get_ResolutionDownscaleCustom(){} // RVA: 0x7FFAC8A11960
        public void set_ResolutionDownscaleCustom(){} // RVA: 0x7FFAC878D950
        public void get_FlipVertically(){} // RVA: 0x7FFAC3D2B010
        public void set_FlipVertically(){} // RVA: 0x7FFAC3D23EE0
        public void get_UseWaitForEndOfFrame(){} // RVA: 0x7FFAC8A11980
        public void set_UseWaitForEndOfFrame(){} // RVA: 0x7FFAC8A11990
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFAC4738E90
        public void set_LogCaptureStartStop(){} // RVA: 0x7FFAC8A119A0
        public void get_AllowOfflineVSyncDisable(){} // RVA: 0x7FFAC8A119B0
        public void set_AllowOfflineVSyncDisable(){} // RVA: 0x7FFAC8A119C0
        public void get_SupportTextureRecreate(){} // RVA: 0x7FFAC8A119D0
        public void set_SupportTextureRecreate(){} // RVA: 0x7FFAC8A119E0
        public void get_TimelineController(){} // RVA: 0x7FFAC354E2F0
        public void set_TimelineController(){} // RVA: 0x7FFAC39A80B0
        public void get_VideoPlayerController(){} // RVA: 0x7FFAC336D850
        public void set_VideoPlayerController(){} // RVA: 0x7FFAC39B5DB0
        public void get_SelectedVideoCodec(){} // RVA: 0x7FFAC3544330
        public void get_SelectedAudioCodec(){} // RVA: 0x7FFAC35422B0
        public void get_SelectedAudioInputDevice(){} // RVA: 0x7FFAC39CCB10
        public void get_NativeForceVideoCodecIndex(){} // RVA: 0x7FFAC39055C0
        public void set_NativeForceVideoCodecIndex(){} // RVA: 0x7FFAC38FD010
        public void get_NativeForceAudioCodecIndex(){} // RVA: 0x7FFAC431B350
        public void set_NativeForceAudioCodecIndex(){} // RVA: 0x7FFAC431A220
        public void get_NativeImageSequenceFormat(){} // RVA: 0x7FFAC8A119F0
        public void set_NativeImageSequenceFormat(){} // RVA: 0x7FFAC8A11A00
        public void GetCurrentPlatform(){} // RVA: 0x7FFAC34F9180
        public void GetEncoderHints(){} // RVA: 0x7FFAC8A11A10
        public void SetEncoderHints(){} // RVA: 0x7FFAC8A11AC0
        public void UpdateMediaGallery(){} // RVA: 0x7FFAC2F21310
        public void Awake(){} // RVA: 0x7FFAC8A11CE0
        public void .cctor(){} // RVA: 0x7FFAC8A12310
        public void Start(){} // RVA: 0x7FFAC8A12E30
        public void SelectCodec(){} // RVA: 0x7FFAC8A12F60
        public void SelectVideoCodec(){} // RVA: 0x7FFAC8A13310
        public void SelectAudioCodec(){} // RVA: 0x7FFAC8A134F0
        public void SelectAudioInputDevice(){} // RVA: 0x7FFAC8A13660
        public void GetRecordingResolution(){} // RVA: 0x7FFAC8A138C0
        public void SelectRecordingResolution(){} // RVA: 0x7FFAC8A13990
        public void OnDestroy(){} // RVA: 0x7FFAC8A13AA0
        public void FreePendingFileWrites(){} // RVA: 0x7FFAC8A13E10
        public void OnApplicationQuit(){} // RVA: 0x7FFAC8A13FB0
        public void OnApplicationPause(){} // RVA: 0x7FFAC2F21310
        public void EncodeTexture(){} // RVA: 0x7FFAC8A14010
        public void IsUsingUnityAudioComponent(){} // RVA: 0x7FFAC8A14120
        public void IsUsingMotionBlur(){} // RVA: 0x7FFAC8A14220
        public void EncodePointer(){} // RVA: 0x7FFAC8A14310
        public void IsPrepared(){} // RVA: 0x7FFAC8A144A0
        public void IsCapturing(){} // RVA: 0x7FFAC8A144B0
        public void IsPaused(){} // RVA: 0x7FFAC8A144C0
        public void GetRecordingWidth(){} // RVA: 0x7FFAC8A144D0
        public void GetRecordingHeight(){} // RVA: 0x7FFAC8A144E0
        public void GenerateTimestampedFilename(){} // RVA: 0x7FFAC8A144F0
        public void GetFolder(){} // RVA: 0x7FFAC8A147D0
        public void GenerateFilePath(){} // RVA: 0x7FFAC8A149B0
        public void HasExtension(){} // RVA: 0x7FFAC8A14A50
        public void GenerateFilename(){} // RVA: 0x7FFAC8A14BA0
        public void FindOrCreateUnityAudioCapture(){} // RVA: 0x7FFAC8A15390
        public void ValidateEditionFeatures(){} // RVA: 0x7FFAC8A15A30
        public void PrepareCapture(){} // RVA: 0x7FFAC8A16160
        public void QueueStartCapture(){} // RVA: 0x7FFAC8A17E80
        public void IsStartCaptureQueued(){} // RVA: 0x7FFAC8A17F20
        public void UpdateInjectionOptions(){} // RVA: 0x7FFAC8A17F30
        public void StartCapture(){} // RVA: 0x7FFAC8A17FC0
        public void PauseCapture(){} // RVA: 0x7FFAC8A18480
        public void ResumeCapture(){} // RVA: 0x7FFAC8A185C0
        public void CancelCapture(){} // RVA: 0x7FFAC8A186D0
        public void DeleteCapture(){} // RVA: 0x7FFAC8A18700
        public void UnprepareCapture(){} // RVA: 0x7FFAC2F21310
        public void get_LastFileSaved(){} // RVA: 0x7FFAC8A18810
        public void set_LastFileSaved(){} // RVA: 0x7FFAC8A188C0
        public void RenderThreadEvent(){} // RVA: 0x7FFAC8A18910
        public void StopCapture(){} // RVA: 0x7FFAC8A18980
        public void CreatePostOperationsOptions(){} // RVA: 0x7FFAC8A196B0
        public void CanApplyPostOperations(){} // RVA: 0x7FFAC8A19780
        public void ApplyPostOperations(){} // RVA: 0x7FFAC8A19970
        public void ToggleCapture(){} // RVA: 0x7FFAC8A19BA0
        public void IsEnoughDiskSpace(){} // RVA: 0x7FFAC8A19BE0
        public void CanContinue(){} // RVA: 0x7FFAC8A19C20
        public void Update(){} // RVA: 0x7FFAC8A19D40
        public void LateUpdate(){} // RVA: 0x7FFAC8A19DB0
        public void RemoveCompletedFileWrites(){} // RVA: 0x7FFAC8A1A0E0
        public void CheckFreeDiskSpace(){} // RVA: 0x7FFAC8A1A1C0
        public void IsStartDelayComplete(){} // RVA: 0x7FFAC8A1A280
        public void IsStopTimeReached(){} // RVA: 0x7FFAC8A1A2B0
        public void GetProgress(){} // RVA: 0x7FFAC8A1A3A0
        public void GetSecondsPerCaptureFrame(){} // RVA: 0x7FFAC8A1A460
        public void CanOutputFrame(){} // RVA: 0x7FFAC8A1A490
        public void TickFrameTimer(){} // RVA: 0x7FFAC8A1A6C0
        public void RenormTimer(){} // RVA: 0x7FFAC8A1A730
        public void GetPreviewTexture(){} // RVA: 0x7FFAC34F9180
        public void EncodeUnityAudio(){} // RVA: 0x7FFAC8A1A780
        public void EncodeAudio(){} // RVA: 0x7FFAC8A1A8D0 | overloaded x2
        public void PreUpdateFrame(){} // RVA: 0x7FFAC8A1AB30
        public void UpdateFrame(){} // RVA: 0x7FFAC8A1AD10
        public void ResetFPS(){} // RVA: 0x7FFAC8A1B050
        public void UpdateFPS(){} // RVA: 0x7FFAC8A1B080
        public void GetCameraAntiAliasingLevel(){} // RVA: 0x7FFAC8A1B110
        public void GetCaptureFileSize(){} // RVA: 0x7FFAC8A1B380
        public void GetResolution(){} // RVA: 0x7FFAC8A1B490
        public void NextMultipleOf4(){} // RVA: 0x7FFAC3EB7160
        public void HasUserAuthorisationToCaptureAudio(){} // RVA: 0x7FFAC8A1B610
        public void RequestUserAuthorisationToCaptureAudioCallback(){} // RVA: 0x7FFAC8A1B6F0
        public void RequestAudioCaptureDeviceUserAuthorisation(){} // RVA: 0x7FFAC34F9180
        public void HasUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFAC8A1B770
        public void RequestUserAuthorisationToAccessPhotosCallback(){} // RVA: 0x7FFAC8A1B850
        public void RequestUserAuthorisationToAccessPhotos(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC8A1B8D0
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
        public void get_CameraSelector(){} // RVA: 0x7FFAC35493F0
        public void set_CameraSelector(){} // RVA: 0x7FFAC354AC80
        public void get_UseContributingCameras(){} // RVA: 0x7FFAC89F1F80
        public void set_UseContributingCameras(){} // RVA: 0x7FFAC89F1F90
        public void SetCamera(){} // RVA: 0x7FFAC89F2300 | overloaded x2
        public void RequiresResolve(){} // RVA: 0x7FFAC89F23C0
        public void HasCamera(){} // RVA: 0x7FFAC89F24F0
        public void HasContributingCameras(){} // RVA: 0x7FFAC89F25C0
        public void UpdateFrame(){} // RVA: 0x7FFAC89F25F0
        public void FinalRenderCapture(){} // RVA: 0x7FFAC89F28E0
        public void Capture(){} // RVA: 0x7FFAC89F2980
        public void RequiresHDR(){} // RVA: 0x7FFAC89F2A20
        public void UpdateTexture(){} // RVA: 0x7FFAC89F2C00
        public void UnprepareCapture(){} // RVA: 0x7FFAC89F3580
        public void CreateResolveTexture(){} // RVA: 0x7FFAC89F37B0
        public void GetPreviewTexture(){} // RVA: 0x7FFAC39CABF0
        public void PrepareCapture(){} // RVA: 0x7FFAC89F3C60
        public void OnDestroy(){} // RVA: 0x7FFAC89F47E0
        public void .ctor(){} // RVA: 0x7FFAC89F4AD0
        public void <>n__0(){} // RVA: 0x7FFAC89F4B30
    }

    public class CaptureFromCamera360 : CaptureBase
    {
        public RenderHeads.Media.AVProMovieCapture.CameraSelector CameraSelector; // 0x220
        public 0x6B277AD0 CubemapFaceResolution; // 0x228
        public 0x6B277A78 CubemapDepthResolution; // 0x22C
        public bool SupportGUI; // 0x230
        public bool SupportCameraRotation; // 0x231
        public bool OnlyLeftRightRotation; // 0x232
        public bool Render180Degrees; // 0x233
        public 0x6B278520 StereoRendering; // 0x234
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
        public void get_CameraSelector(){} // RVA: 0x7FFAC35493F0
        public void set_CameraSelector(){} // RVA: 0x7FFAC354AC80
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFAC44F99D0
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFAC44F95F0
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFAC44FA0A0
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFAC44F9B10
        public void get_SupportGUI(){} // RVA: 0x7FFAC89F5240
        public void set_SupportGUI(){} // RVA: 0x7FFAC89F5250
        public void get_SupportCameraRotation(){} // RVA: 0x7FFAC89F5260
        public void set_SupportCameraRotation(){} // RVA: 0x7FFAC89F5270
        public void get_OnlyLeftRightRotation(){} // RVA: 0x7FFAC89F5280
        public void set_OnlyLeftRightRotation(){} // RVA: 0x7FFAC89F5290
        public void get_Render180Degrees(){} // RVA: 0x7FFAC89F52A0
        public void set_Render180Degrees(){} // RVA: 0x7FFAC89F52B0
        public void get_StereoRendering(){} // RVA: 0x7FFAC44F95E0
        public void set_StereoRendering(){} // RVA: 0x7FFAC89F52C0
        public void get_IPD(){} // RVA: 0x7FFAC89F52D0
        public void set_IPD(){} // RVA: 0x7FFAC89F52E0
        public void .ctor(){} // RVA: 0x7FFAC89F52F0
        public void GetCubemapRenderingMethod(){} // RVA: 0x7FFAC89F5380
        public void SetCamera(){} // RVA: 0x7FFAC39B5A80
        public void UpdateFrame(){} // RVA: 0x7FFAC89F53A0
        public void FinalRenderCapture(){} // RVA: 0x7FFAC89F5660
        public void Capture(){} // RVA: 0x7FFAC89F5700
        public void ClearCubemap(){} // RVA: 0x7FFAC89F5BA0
        public void RenderCubemapToEquiRect(){} // RVA: 0x7FFAC89F6050
        public void UpdateTexture(){} // RVA: 0x7FFAC89F6210
        public void RenderCameraToCubemap(){} // RVA: 0x7FFAC89F6A40
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAC89F8510
        public void PrepareCapture(){} // RVA: 0x7FFAC89F86D0
        public void GetPreviewTexture(){} // RVA: 0x7FFAC89F98C0
        public void Start(){} // RVA: 0x7FFAC89F9900
        public void OnDestroy(){} // RVA: 0x7FFAC89F9CC0
    }

    public class CaptureFromCamera360ODS : CaptureBase
    {
        public Settings Setup; // 0x220
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
        public void get_Setup(){} // RVA: 0x7FFAC35493F0
        public void .ctor(){} // RVA: 0x7FFAC89FA2A0
        public void SetCamera(){} // RVA: 0x7FFAC89FA3C0
        public void Start(){} // RVA: 0x7FFAC89FA430
        public void CreateEye(){} // RVA: 0x7FFAC89FA660
        public void UpdateFrame(){} // RVA: 0x7FFAC89FB760
        public void FinalRenderCapture(){} // RVA: 0x7FFAC89FBA50
        public void Capture(){} // RVA: 0x7FFAC89FBAF0
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAC89FBD60
        public void RenderFrame(){} // RVA: 0x7FFAC89FBF30
        public void GetPreviewTexture(){} // RVA: 0x7FFAC89FCBD0
        public void PrepareCapture(){} // RVA: 0x7FFAC89FCC10
        public void DestroyEye(){} // RVA: 0x7FFAC89FDD80
        public void OnDestroy(){} // RVA: 0x7FFAC89FDFB0
    }

    public class CaptureFromScreen : CaptureBase
    {
        public bool CaptureMouseCursor; // 0x220
        public RenderHeads.Media.AVProMovieCapture.MouseCursor MouseCursor; // 0x228
        public UIntPtr _targetNativePointer; // 0x230
        public UnityEngine.RenderTexture _resolveTexture; // 0x238
        public UnityEngine.Rendering.CommandBuffer _commandBuffer; // 0x240

        // ── Methods ──
        public void get_CaptureMouseCursor(){} // RVA: 0x7FFAC89FE710
        public void set_CaptureMouseCursor(){} // RVA: 0x7FFAC89FE720
        public void get_MouseCursor(){} // RVA: 0x7FFAC3540FB0
        public void set_MouseCursor(){} // RVA: 0x7FFAC39AE720
        public void PrepareCapture(){} // RVA: 0x7FFAC89FE730
        public void CopyRenderTargetToTexture(){} // RVA: 0x7FFAC89FEA90
        public void FreeRenderResources(){} // RVA: 0x7FFAC89FF0A0
        public void UnprepareCapture(){} // RVA: 0x7FFAC89FF2C0
        public void FinalRenderCapture(){} // RVA: 0x7FFAC89FF430
        public void UpdateFrame(){} // RVA: 0x7FFAC89FF4D0
        public void .ctor(){} // RVA: 0x7FFAC89FF590
    }

    public class CaptureFromTexture : CaptureBase
    {
        public bool IsManualUpdate; // 0x220
        public UnityEngine.Texture _sourceTexture; // 0x228
        public UnityEngine.RenderTexture _resolveTexture; // 0x230
        public UIntPtr _targetNativePointer; // 0x238
        public bool _isSourceTextureChanged; // 0x240

        // ── Methods ──
        public void get_IsManualUpdate(){} // RVA: 0x7FFAC89FE710
        public void set_IsManualUpdate(){} // RVA: 0x7FFAC89FE720
        public void SetSourceTexture(){} // RVA: 0x7FFAC39AE720
        public void RequiresResolve(){} // RVA: 0x7FFAC89FF7B0
        public void UpdateSourceTexture(){} // RVA: 0x7FFAC89FF8E0
        public void ShouldCaptureFrame(){} // RVA: 0x7FFAC89FF8F0
        public void HasSourceTextureChanged(){} // RVA: 0x7FFAC89FF9E0
        public void UpdateFrame(){} // RVA: 0x7FFAC89FFA00
        public void FinalRenderCapture(){} // RVA: 0x7FFAC89FFAD0
        public void Capture(){} // RVA: 0x7FFAC89FFB70
        public void CreateResolveTexture(){} // RVA: 0x7FFAC89FFF80
        public void AccumulateMotionBlur(){} // RVA: 0x7FFAC8A00330
        public void GetPreviewTexture(){} // RVA: 0x7FFAC8A00450
        public void PrepareCapture(){} // RVA: 0x7FFAC8A005C0
        public void UnprepareCapture(){} // RVA: 0x7FFAC8A009B0
        public void .ctor(){} // RVA: 0x7FFAC8A00B80
    }

    public class CaptureFromWebCamTexture : CaptureFromTexture
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8A00CD0
        public void .ctor(){} // RVA: 0x7FFAC8A00B80
    }

    public class CaptureGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProMovieCapture.CaptureBase MovieCapture; // 0x20
        public bool HideUiWhenRecording; // 0x28
        public bool ShowUI; // 0x29
        public UnityEngine.GUISkin _guiSkin; // 0x30
        public string[] CommonFrameRateNames;
        public float[] CommonFrameRateValues; // 0x8
        public 0x6B276FD0 _shownSection; // 0x38
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
        public void get_MovieCapture(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MovieCapture(){} // RVA: 0x7FFAC2F4F0D0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFAC386C550
        public void set_HideUiWhenRecording(){} // RVA: 0x7FFAC43B4D70
        public void get_ShowUI(){} // RVA: 0x7FFAC30F6BA0
        public void set_ShowUI(){} // RVA: 0x7FFAC3C24F40
        public void Start(){} // RVA: 0x7FFAC8A00D30
        public void CreateGUI(){} // RVA: 0x7FFAC8A00E10
        public void OnGUI(){} // RVA: 0x7FFAC8A01A70
        public void MyWindow(){} // RVA: 0x7FFAC8A02550
        public void GUI_RecordingStatus(){} // RVA: 0x7FFAC8A04DD0
        public void DrawPauseResumeButtons(){} // RVA: 0x7FFAC8A06860
        public void DrawGuiField(){} // RVA: 0x7FFAC8A07080
        public void StartCapture(){} // RVA: 0x7FFAC8A07150
        public void StopCapture(){} // RVA: 0x7FFAC8A07250
        public void CancelCapture(){} // RVA: 0x7FFAC8A07350
        public void ResumeCapture(){} // RVA: 0x7FFAC8A07450
        public void PauseCapture(){} // RVA: 0x7FFAC8A07530
        public void Update(){} // RVA: 0x7FFAC8A07610
        public void .ctor(){} // RVA: 0x7FFAC8A078D0
        public void .cctor(){} // RVA: 0x7FFAC8A07E90
    }

    public class CaptureStats : Object
    {
        public uint FPS; // 0x10
        public uint FramesTotal; // 0x14
        public uint NumDroppedFrames; // 0x18
        public uint NumDroppedEncoderFrames; // 0x1C
        public 0x6B2784C8 NumEncodedFrames; // 0x20
        public int TotalEncodedSeconds; // 0x24
        public int AudioCaptureSource; // 0x28
        public float UnityAudioSampleRate; // 0x2C
        public int UnityAudioChannelCount; // 0x30
        public int _frameCount; // 0x34
        public float _startFrameTime; // 0x38

        // ── Methods ──
        public void get_FPS(){} // RVA: 0x7FFAC33EAB80
        public void get_FramesTotal(){} // RVA: 0x7FFAC8A11330
        public void get_NumDroppedFrames(){} // RVA: 0x7FFAC2F6E5C0
        public void set_NumDroppedFrames(){} // RVA: 0x7FFAC2F240C0
        public void get_NumDroppedEncoderFrames(){} // RVA: 0x7FFAC33D5A20
        public void set_NumDroppedEncoderFrames(){} // RVA: 0x7FFAC33D4990
        public void get_NumEncodedFrames(){} // RVA: 0x7FFAC3157800
        public void set_NumEncodedFrames(){} // RVA: 0x7FFAC392CD10
        public void get_TotalEncodedSeconds(){} // RVA: 0x7FFAC44357F0
        public void set_TotalEncodedSeconds(){} // RVA: 0x7FFAC44474D0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAC30DBBE0
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAC35DB7A0
        public void get_UnityAudioSampleRate(){} // RVA: 0x7FFAC3921980
        public void set_UnityAudioSampleRate(){} // RVA: 0x7FFAC41674D0
        public void get_UnityAudioChannelCount(){} // RVA: 0x7FFAC32EC4C0
        public void set_UnityAudioChannelCount(){} // RVA: 0x7FFAC369A6E0
        public void ResetFPS(){} // RVA: 0x7FFAC8A11340
        public void UpdateFPS(){} // RVA: 0x7FFAC8A11350
        public void .ctor(){} // RVA: 0x7FFAC8A113D0
    }

    public class Codec : Object
    {
        public 0x6B277EF0 CodecType; // 0x10
        public int Index; // 0x14
        public string Name; // 0x18
        public bool MediaApi; // 0x20
        public 0x6B277E98 HasConfigwindow; // 0x24

        // ── Methods ──
        public void get_CodecType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Index(){} // RVA: 0x7FFAC33D5A20
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_MediaApi(){} // RVA: 0x7FFAC3921980
        public void get_HasConfigwindow(){} // RVA: 0x7FFAC300F9D0
        public void ShowConfigWindow(){} // RVA: 0x7FFAC8A1C2F0
        public void .ctor(){} // RVA: 0x7FFAC8A1C450
    }

    public class CodecList : Object
    {
        public RenderHeads.Media.AVProMovieCapture.Codec[] Codecs; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A1C4D0
        public void FindCodec(){} // RVA: 0x7FFAC8A1C5D0
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFAC8A1C6B0
        public void GetEnumerator(){} // RVA: 0x7FFAC47D1B80
        public void get_Codecs(){} // RVA: 0x7FFAC2F3C380
        public void get_Count(){} // RVA: 0x7FFAC3510620
    }

    public class CodecManager : Object
    {
        public bool VideoCodecs;
        public RenderHeads.Media.AVProMovieCapture.CodecList AudioCodecs; // 0x8
        public RenderHeads.Media.AVProMovieCapture.CodecList _audioCodecs; // 0x10

        // ── Methods ──
        public void FindCodec(){} // RVA: 0x7FFAC8A1C710
        public void GetCodecCount(){} // RVA: 0x7FFAC8A1C820
        public void CheckInit(){} // RVA: 0x7FFAC8A1C890
        public void GetCodecs(){} // RVA: 0x7FFAC8A1C940
        public void EnumerateCodecs(){} // RVA: 0x7FFAC8A1C9E0
        public void get_VideoCodecs(){} // RVA: 0x7FFAC8A1D400
        public void get_AudioCodecs(){} // RVA: 0x7FFAC8A1D460
        public void .cctor(){} // RVA: 0x7FFAC8A1D4C0
    }

    public class Device : Object
    {
        public 0x6B278050 DeviceType; // 0x10
        public int Index; // 0x14
        public string Name; // 0x18
        public 0x6B277E98 MediaApi; // 0x20

        // ── Methods ──
        public void get_DeviceType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Index(){} // RVA: 0x7FFAC33D5A20
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_MediaApi(){} // RVA: 0x7FFAC30DBBE0
        public void .ctor(){} // RVA: 0x7FFAC8A1D680
    }

    public class DeviceList : Object
    {
        public RenderHeads.Media.AVProMovieCapture.Device[] Devices; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A1D6F0
        public void FindDevice(){} // RVA: 0x7FFAC8A1D7F0
        public void GetFirstWithMediaApi(){} // RVA: 0x7FFAC8A1D8D0
        public void GetEnumerator(){} // RVA: 0x7FFAC47D1B80
        public void get_Devices(){} // RVA: 0x7FFAC2F3C380
        public void get_Count(){} // RVA: 0x7FFAC3510620
    }

    public class DeviceManager : Object
    {
        public bool AudioInputDevices;
        public RenderHeads.Media.AVProMovieCapture.DeviceList _audioInputDevices; // 0x8

        // ── Methods ──
        public void FindDevice(){} // RVA: 0x7FFAC8A1D930
        public void GetDeviceCount(){} // RVA: 0x7FFAC8A1DA80
        public void CheckInit(){} // RVA: 0x7FFAC8A1DB30
        public void GetDevices(){} // RVA: 0x7FFAC8A1DBE0
        public void EnumerateDevices(){} // RVA: 0x7FFAC8A1DC50
        public void get_AudioInputDevices(){} // RVA: 0x7FFAC8A1DFB0
        public void .cctor(){} // RVA: 0x7FFAC8A1E010
    }

    public class EncoderHints : Object
    {
        public RenderHeads.Media.AVProMovieCapture.VideoEncoderHints videoHints; // 0x10
        public RenderHeads.Media.AVProMovieCapture.ImageEncoderHints imageHints; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A114B0
        public void SetDefaults(){} // RVA: 0x7FFAC8A114B0
    }

    public class FileWritingHandler : Object
    {
        public string Status; // 0x10
        public int Path; // 0x18
        public bool CompletedFileWritingAction; // 0x1C
        public 0x6B278730 _outputTarget; // 0x20
        public Options _postOptions; // 0x28
        public System.Threading.ManualResetEvent _postProcessEvent; // 0x48
        public 0x6B278208 _completionStatus; // 0x50
        public string _finalFilePath; // 0x58
        public bool _updateMediaGallery; // 0x60
        public System.Action`1<RenderHeads.Media.AVProMovieCapture.FileWritingHandler> <CompletedFileWritingAction>k__BackingField; // 0x68

        // ── Methods ──
        public void get_Status(){} // RVA: 0x7FFAC30F10E0
        public void get_Path(){} // RVA: 0x7FFAC2F3C380
        public void get_CompletedFileWritingAction(){} // RVA: 0x7FFAC2F9CD50
        public void set_CompletedFileWritingAction(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC8A1E110
        public void SetFilePostProcess(){} // RVA: 0x7FFAC8A1E1F0
        public void StartPostProcess(){} // RVA: 0x7FFAC8A1E250
        public void IsFileReady(){} // RVA: 0x7FFAC8A1E390
        public void Dispose(){} // RVA: 0x7FFAC8A1E590
        public void Cleanup(){} // RVA: 0x7FFAC8A1E840
    }

    public class IMediaApiItem
    {
        public object Index;
        public object Name;
        public object MediaApi;

        // ── Methods ──
        public void get_Index(){} // RVA: 0x7FFAC2C59960
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_MediaApi(){} // RVA: 0x7FFAC2C59960
    }

    public class ImageEncoderHints : Object
    {
        public float quality; // 0x10
        public bool supportTransparency; // 0x14
        public 0x6B277918 colourSpace; // 0x15
        public int sourceWidth; // 0x19
        public int sourceHeight; // 0x1D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A11460
        public void SetDefaults(){} // RVA: 0x7FFAC8A11460
        public void Validate(){} // RVA: 0x7FFAC8A11480
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
        public System.IO.BinaryReader _reader; // 0x10
        public System.IO.Stream _writeFile; // 0x18
        public Options _options; // 0x20
        public bool _requires64BitOffsets; // 0x40
        public System.Collections.Generic.List`1<Chunk> _offsetChunks; // 0x48
        public System.Collections.Generic.List`1<Chunk> _offsetUpgradeChunks; // 0x50

        // ── Methods ──
        public void ProcessFileAsync(){} // RVA: 0x7FFAC8A1E920
        public void ProcessFile(){} // RVA: 0x7FFAC8A1EF50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8A1F350
        public void Process(){} // RVA: 0x7FFAC8A1F500
        public void Close(){} // RVA: 0x7FFAC8A20000
        public void GetFirstChunkOfType(){} // RVA: 0x7FFAC8A20200
        public void ReadChildChunks(){} // RVA: 0x7FFAC8A20450 | overloaded x2
        public void ReadChunkHeader(){} // RVA: 0x7FFAC8A20650
        public void ChunkContainsChildChunkWithId(){} // RVA: 0x7FFAC8A20830
        public void ChunkDesc(){} // RVA: 0x7FFAC8A209A0
        public void WriteChunk(){} // RVA: 0x7FFAC8A20CE0
        public void CopyChunkHeader(){} // RVA: 0x7FFAC8A20D60
        public void InjectChunkHeader(){} // RVA: 0x7FFAC8A20DE0
        public void CopyBytes(){} // RVA: 0x7FFAC8A20E60
        public void WriteZeros(){} // RVA: 0x7FFAC8A20F70
        public void WriteChunkRecursive_moov(){} // RVA: 0x7FFAC8A21020
        public void IsVideoTrack(){} // RVA: 0x7FFAC8A21730
        public void WriteChunk_stco(){} // RVA: 0x7FFAC8A21880
        public void WriteChunk_co64_from_stco(){} // RVA: 0x7FFAC8A21980
        public void WriteChunk_co64(){} // RVA: 0x7FFAC8A21AB0
        public void InjectChunkStub_co64_from_stco(){} // RVA: 0x7FFAC8A21BA0
        public void WriteChunk_stsd(){} // RVA: 0x7FFAC8A21D00
        public void Convert(){} // RVA: 0x7FFAC8A22210
        public void InjectChunk_st3d(){} // RVA: 0x7FFAC8A22230
        public void InjectChunk_sv3d(){} // RVA: 0x7FFAC8A22300
        public void InjectChunk_uuid_GoogleSphericalVideoV1(){} // RVA: 0x7FFAC8A22490
        public void InjectChunk_svhd(){} // RVA: 0x7FFAC8A22730
        public void InjectChunk_proj(){} // RVA: 0x7FFAC8A22980
        public void InjectChunk_prhd(){} // RVA: 0x7FFAC8A22D80
        public void InjectChunk_equi(){} // RVA: 0x7FFAC8A22EF0
        public void OverwriteChunkSize(){} // RVA: 0x7FFAC8A23070
        public void ReadUInt16(){} // RVA: 0x7FFAC8A23130
        public void ReadUInt32(){} // RVA: 0x7FFAC8A23240
        public void ReadUInt64(){} // RVA: 0x7FFAC8A23350
        public void WriteUInt16(){} // RVA: 0x7FFAC8A23460
        public void WriteChunkId(){} // RVA: 0x7FFAC8A23550
        public void WriteUInt32(){} // RVA: 0x7FFAC8A23560
        public void WriteUInt64(){} // RVA: 0x7FFAC8A23660
        public void ChunkIdToString(){} // RVA: 0x7FFAC8A23750
        public void ChunkId(){} // RVA: 0x7FFAC8A239D0
        public void DebugLog(){} // RVA: 0x7FFAC8A23A20
        public void .cctor(){} // RVA: 0x7FFAC8A23A70
    }

    public class MotionBlur : MonoBehaviour
    {
        public 0x6B17C180 IsFrameAccumulated; // 0x20
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
        public void get_IsFrameAccumulated(){} // RVA: 0x7FFAC45A1580
        public void set_IsFrameAccumulated(){} // RVA: 0x7FFAC45A1C60
        public void get_NumSamples(){} // RVA: 0x7FFAC3921980
        public void set_NumSamples(){} // RVA: 0x7FFAC8A08230
        public void get_FrameCount(){} // RVA: 0x7FFAC2FC20C0
        public void get_FinalTexture(){} // RVA: 0x7FFAC31D95E0
        public void Awake(){} // RVA: 0x7FFAC8A08240
        public void SetTargetSize(){} // RVA: 0x7FFAC8A08360
        public void Start(){} // RVA: 0x7FFAC8A08380
        public void OnEnable(){} // RVA: 0x7FFAC8A08390
        public void Setup(){} // RVA: 0x7FFAC8A083B0
        public void ClearAccumulation(){} // RVA: 0x7FFAC8A08BD0
        public void OnDestroy(){} // RVA: 0x7FFAC8A08D20
        public void OnNumSamplesChanged(){} // RVA: 0x7FFAC8A09240
        public void LerpUnclamped(){} // RVA: 0x7FFAC8A093C0
        public void ApplyWeighting(){} // RVA: 0x7FFAC8A093D0
        public void Accumulate(){} // RVA: 0x7FFAC8A09550
        public void OnRenderImage(){} // RVA: 0x7FFAC8A09640
        public void .ctor(){} // RVA: 0x7FFAC8A096C0
    }

    public class MouseCursor : MonoBehaviour
    {
        public UnityEngine.Texture2D _texture; // 0x20
        public UnityEngine.Vector2 _hotspotOffset; // 0x28
        public int _sizeScale; // 0x30
        public int _depth; // 0x34
        public UnityEngine.GUIContent _content; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8A09720
        public void SetTexture(){} // RVA: 0x7FFAC8A09730
        public void OnGUI(){} // RVA: 0x7FFAC8A09930
        public void .ctor(){} // RVA: 0x7FFAC8A09BE0
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
        public void AddAmbisonicSourceInstance(){} // RVA: 0x7FFAC8A0D3B0
        public void RemoveAmbisonicSourceInstance(){} // RVA: 0x7FFAC8A0D430
        public void UpdateAmbisonicWeights(){} // RVA: 0x7FFAC8A0D4B0
        public void EncodeMonoToAmbisonic(){} // RVA: 0x7FFAC8A0D580
        public void RenderThreadEvent(){} // RVA: 0x7FFAC8A0D660
        public void get_RenderCaptureEventFunction(){} // RVA: 0x7FFAC8A0D8F0
        public void get_RenderFreeEventFunction(){} // RVA: 0x7FFAC8A0DA00
        public void GetRenderEventFunc(){} // RVA: 0x7FFAC8A0DB10
        public void GetFreeResourcesEventFunc(){} // RVA: 0x7FFAC8A0DB80
        public void Init(){} // RVA: 0x7FFAC8A0DBF0
        public void Deinit(){} // RVA: 0x7FFAC8A0DC60
        public void SetMicrophoneRecordingHint(){} // RVA: 0x7FFAC8A0DCD0
        public void GetPluginVersionString(){} // RVA: 0x7FFAC8A0DD60
        public void IsTrialVersion(){} // RVA: 0x7FFAC8A0DE60
        public void IsBasicEdition(){} // RVA: 0x7FFAC8A0DED0
        public void GetVideoCodecCount(){} // RVA: 0x7FFAC8A0E100
        public void IsConfigureVideoCodecSupported(){} // RVA: 0x7FFAC8A0E170
        public void GetVideoCodecMediaApi(){} // RVA: 0x7FFAC8A0E1F0
        public void ConfigureVideoCodec(){} // RVA: 0x7FFAC8A0E270
        public void GetVideoCodecName(){} // RVA: 0x7FFAC8A0FA30 | overloaded x2
        public void GetAudioCodecCount(){} // RVA: 0x7FFAC8A0E4D0
        public void IsConfigureAudioCodecSupported(){} // RVA: 0x7FFAC8A0E540
        public void GetAudioCodecMediaApi(){} // RVA: 0x7FFAC8A0E5C0
        public void ConfigureAudioCodec(){} // RVA: 0x7FFAC8A0E640
        public void GetAudioCodecName(){} // RVA: 0x7FFAC8A0FB00 | overloaded x2
        public void GetAudioInputDeviceCount(){} // RVA: 0x7FFAC8A0E8A0
        public void GetAudioInputDeviceName(){} // RVA: 0x7FFAC8A0FBD0 | overloaded x2
        public void GetAudioInputDeviceMediaApi(){} // RVA: 0x7FFAC8A0EAF0
        public void GetContainerFileExtensions(){} // RVA: 0x7FFAC8A0FCA0 | overloaded x2
        public void CreateRecorderVideo(){} // RVA: 0x7FFAC8A0EE30
        public void CreateRecorderImages(){} // RVA: 0x7FFAC8A0EF40
        public void CreateRecorderPipe(){} // RVA: 0x7FFAC8A0F050
        public void Start(){} // RVA: 0x7FFAC8A0F140
        public void IsNewFrameDue(){} // RVA: 0x7FFAC8A0F1C0
        public void SetEncodedFrameLimit(){} // RVA: 0x7FFAC8A0F240
        public void EncodeFrame(){} // RVA: 0x7FFAC8A0F2D0
        public void EncodeAudio(){} // RVA: 0x7FFAC8A0F360
        public void EncodeFrameWithAudio(){} // RVA: 0x7FFAC8A0F400
        public void Pause(){} // RVA: 0x7FFAC8A0F4A0
        public void Stop(){} // RVA: 0x7FFAC8A0F520
        public void IsFileWritingComplete(){} // RVA: 0x7FFAC8A0F5B0
        public void SetTexturePointer(){} // RVA: 0x7FFAC8A0F630
        public void FreeRecorder(){} // RVA: 0x7FFAC8A0F6C0
        public void GetNumDroppedFrames(){} // RVA: 0x7FFAC8A0F740
        public void GetNumDroppedEncoderFrames(){} // RVA: 0x7FFAC8A0F7C0
        public void GetNumEncodedFrames(){} // RVA: 0x7FFAC8A0F840
        public void GetEncodedSeconds(){} // RVA: 0x7FFAC8A0F8C0
        public void GetFileSize(){} // RVA: 0x7FFAC8A0F940
        public void GetPluginVersion(){} // RVA: 0x7FFAC8A0F9C0
        public void SetLogFunction(){} // RVA: 0x7FFAC8A0FD80
        public void SetErrorHandler(){} // RVA: 0x7FFAC8A0FE00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8A0FE90
    }

    public class TimelineController : MonoBehaviour
    {
        public 0x6B277130 ScanFrequency; // 0x20
        public System.Collections.Generic.List`1<TimelineInstance> _timelines; // 0x28

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFAC30DBBE0
        public void set_ScanFrequency(){} // RVA: 0x7FFAC8A09C80
        public void Awake(){} // RVA: 0x7FFAC8A09C90
        public void OnValidate(){} // RVA: 0x7FFAC8A09C90
        public void UpdateFrame(){} // RVA: 0x7FFAC8A09CA0
        public void StartCapture(){} // RVA: 0x7FFAC8A09CB0
        public void StopCapture(){} // RVA: 0x7FFAC8A09E10
        public void ScanForPlayableDirectors(){} // RVA: 0x7FFAC8A0A090
        public void OnDestroy(){} // RVA: 0x7FFAC8A0A410
        public void ResetSceneLoading(){} // RVA: 0x7FFAC8A0A4C0
        public void OnSceneLoaded(){} // RVA: 0x7FFAC8A0A5B0
        public void .ctor(){} // RVA: 0x7FFAC8A0A5C0
    }

    public class UnityAudioCapture : MonoBehaviour
    {
        public object OverflowCount;
        public object SampleRate;
        public object ChannelCount;

        // ── Methods ──
        public void get_OverflowCount(){} // RVA: 0x7FFAC34F9180
        public void get_SampleRate(){} // RVA: 0x7FFAC2C59960
        public void get_ChannelCount(){} // RVA: 0x7FFAC2C59960
        public void PrepareCapture(){} // RVA: 0x7FFAC2C70980
        public void StartCapture(){} // RVA: 0x7FFAC2C70980
        public void StopCapture(){} // RVA: 0x7FFAC2C70980
        public void FlushBuffer(){} // RVA: 0x7FFAC2C70980
        public void ReadData(){} // RVA: 0x7FFAC8A0AB60
        public void GetUnityAudioChannelCount(){} // RVA: 0x7FFAC8A0AB70
        public void GetChannelCount(){} // RVA: 0x7FFAC8A0ACB0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Utils : Object
    {
        public string[] WindowsImageSequenceFormatNames;
        public string[] MacOSImageSequenceFormatNames; // 0x8
        public string[] IOSImageSequenceFormatNames; // 0x10
        public string[] AndroidImageSequenceFormatNames; // 0x18

        // ── Methods ──
        public void GetNativeImageSequenceFormatNames(){} // RVA: 0x7FFAC8A24410
        public void HasAlphaChannel(){} // RVA: 0x7FFAC8A24490
        public void GetBestRenderTextureFormat(){} // RVA: 0x7FFAC8A24500
        public void GetUltimateRenderCamera(){} // RVA: 0x7FFAC8A248D0
        public void HasContributingCameras(){} // RVA: 0x7FFAC8A24BB0
        public void FindContributingCameras(){} // RVA: 0x7FFAC8A24D10
        public void URLEscapePathByPercentEncoding(){} // RVA: 0x7FFAC8A25510
        public void ShowInExplorer(){} // RVA: 0x7FFAC8A25970
        public void OpenInDefaultApp(){} // RVA: 0x7FFAC8A25AD0
        public void GetFileSize(){} // RVA: 0x7FFAC8A25C50
        public void GetDiskFreeSpaceEx(){} // RVA: 0x7FFAC8A25CD0
        public void DriveFreeBytes(){} // RVA: 0x7FFAC8A25DA0
        public void GetImageFileExtension(){} // RVA: 0x7FFAC8A25F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8A26010
    }

    public class VideoEncoderHints : Object
    {
        public uint averageBitrate; // 0x10
        public uint maximumBitrate; // 0x14
        public float quality; // 0x18
        public uint keyframeInterval; // 0x1C
        public bool allowFastStartStreamingPostProcess; // 0x20
        public bool supportTransparency; // 0x21
        public bool useHardwareEncoding; // 0x22
        public 0x6B278470 injectStereoPacking; // 0x23
        public 0x6B278520 stereoPacking; // 0x27
        public 0x6B278470 injectSphericalVideoLayout; // 0x2B
        public 0x6B278578 sphericalVideoLayout; // 0x2F
        public bool enableFragmentedWriting; // 0x33
        public double movieFragmentInterval; // 0x34
        public 0x6B277868 colourSpace; // 0x3C
        public int sourceWidth; // 0x40
        public int sourceHeight; // 0x44
        public bool androidNoCaptureRotation; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A113E0
        public void SetDefaults(){} // RVA: 0x7FFAC8A113E0
        public void Validate(){} // RVA: 0x7FFAC8A11430
    }

    public class VideoPlayerController : MonoBehaviour
    {
        public 0x6B277290 ScanFrequency; // 0x20
        public System.Collections.Generic.List`1<VideoPlayerInstance> _instances; // 0x28

        // ── Methods ──
        public void get_ScanFrequency(){} // RVA: 0x7FFAC30DBBE0
        public void set_ScanFrequency(){} // RVA: 0x7FFAC8A0AD20
        public void Awake(){} // RVA: 0x7FFAC8A0AD30
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void OnValidate(){} // RVA: 0x7FFAC8A0AD30
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void UpdateFrame(){} // RVA: 0x7FFAC8A0AD40
        public void CanContinue(){} // RVA: 0x7FFAC8A0AF30
        public void WaitforSeekCompletes(){} // RVA: 0x7FFAC8A0B0B0
        public void WaitforSeekCompletes2(){} // RVA: 0x7FFAC2F21310
        public void StartCapture(){} // RVA: 0x7FFAC8A0B150
        public void StopCapture(){} // RVA: 0x7FFAC8A0B3C0
        public void ScanForVideoPlayers(){} // RVA: 0x7FFAC8A0B600
        public void OnDestroy(){} // RVA: 0x7FFAC8A0B9F0
        public void ResetSceneLoading(){} // RVA: 0x7FFAC8A0BAA0
        public void OnSceneLoaded(){} // RVA: 0x7FFAC8A0BB90
        public void .ctor(){} // RVA: 0x7FFAC8A0BBA0
        public void <WaitforSeekCompletes>b__13_0(){} // RVA: 0x7FFAC8A0BD10
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
        public 0x6B278838 _sampleFormat; // 0x30
        public int _headerSize; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A26860
        public void Dispose(){} // RVA: 0x7FFAC8A269F0
        public void WriteInterleaved(){} // RVA: 0x7FFAC8A26AC0
        public void WriteHeader(){} // RVA: 0x7FFAC8A26E40
        public void PackageInt(){} // RVA: 0x7FFAC8A27510
        public void .cctor(){} // RVA: 0x7FFAC8A27620
    }

}