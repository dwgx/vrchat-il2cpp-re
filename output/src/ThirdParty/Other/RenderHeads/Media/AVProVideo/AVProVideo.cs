// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 66
// Methods: 1112

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class Android : Object
    {
    }

    public class ApplyToBase : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _media; // 0x20
        public bool _automaticStereoPacking; // 0x28
        public 0x6666E9A4 _overrideStereoPacking; // 0x2C
        public bool _stereoRedGreenTint; // 0x30

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFE811290C0
        public void set_Player(){} // RVA: 0x7FFE82A331D0
        public void get_AutomaticStereoPacking(){} // RVA: 0x7FFE815F1380
        public void set_AutomaticStereoPacking(){} // RVA: 0x7FFE82A331E0
        public void get_OverrideStereoPacking(){} // RVA: 0x7FFE81F84A50
        public void set_OverrideStereoPacking(){} // RVA: 0x7FFE82A331F0
        public void get_StereoRedGreenTint(){} // RVA: 0x7FFE81121450
        public void set_StereoRedGreenTint(){} // RVA: 0x7FFE82A33200
        public void Awake(){} // RVA: 0x7FFE82A33210
        public void ChangeMediaPlayer(){} // RVA: 0x7FFE82A33220
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFE82A33590
        public void ForceUpdate(){} // RVA: 0x7FFE82A335B0
        public void Start(){} // RVA: 0x7FFE82A33630
        public void OnEnable(){} // RVA: 0x7FFE82A33670
        public void OnDisable(){} // RVA: 0x7FFE82A336A0
        public void OnDestroy(){} // RVA: 0x7FFE82A336C0
        public void SaveProperties(){} // RVA: 0x7FFE810FB310
        public void RestoreProperties(){} // RVA: 0x7FFE810FB310
        public void Apply(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE81132BB0
    }

    public class ApplyToMaterial : ApplyToBase
    {
        public UnityEngine.Texture2D _defaultTexture; // 0x38
        public UnityEngine.Material _material; // 0x40
        public string _texturePropertyName; // 0x48
        public UnityEngine.Vector2 _offset; // 0x50
        public UnityEngine.Vector2 _scale; // 0x58

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFE8143BA80
        public void set_DefaultTexture(){} // RVA: 0x7FFE82A1CF90
        public void get_Material(){} // RVA: 0x7FFE81178740
        public void set_Material(){} // RVA: 0x7FFE82A1D100
        public void get_TexturePropertyName(){} // RVA: 0x7FFE81176730
        public void set_TexturePropertyName(){} // RVA: 0x7FFE82A1D270
        public void get_Offset(){} // RVA: 0x7FFE82A1D3F0
        public void set_Offset(){} // RVA: 0x7FFE82A1D410
        public void get_Scale(){} // RVA: 0x7FFE82A1D460
        public void set_Scale(){} // RVA: 0x7FFE82A1D480
        public void LateUpdate(){} // RVA: 0x7FFE81768340
        public void Apply(){} // RVA: 0x7FFE82A1D4D0
        public void ApplyMapping(){} // RVA: 0x7FFE82A1DA60
        public void SaveProperties(){} // RVA: 0x7FFE82A1E150
        public void RestoreProperties(){} // RVA: 0x7FFE82A1E4A0
        public void .ctor(){} // RVA: 0x7FFE82A1E680
    }

    public class ApplyToMesh : ApplyToBase
    {
        public UnityEngine.Texture2D _defaultTexture; // 0x38
        public UnityEngine.Renderer _renderer; // 0x40
        public int _materialIndex; // 0x48
        public string _texturePropertyName; // 0x50
        public UnityEngine.Vector2 _offset; // 0x58
        public UnityEngine.Vector2 _scale; // 0x60

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFE8143BA80
        public void set_DefaultTexture(){} // RVA: 0x7FFE82A1E860
        public void get_MeshRenderer(){} // RVA: 0x7FFE81178740
        public void set_MeshRenderer(){} // RVA: 0x7FFE82A1E9E0
        public void get_MaterialIndex(){} // RVA: 0x7FFE8119C0C0
        public void set_MaterialIndex(){} // RVA: 0x7FFE8119C0D0
        public void ChangeDefaultTexture(){} // RVA: 0x7FFE82A1E860
        public void ChangeRenderer(){} // RVA: 0x7FFE82A1E9F0
        public void get_TexturePropertyName(){} // RVA: 0x7FFE8119C0E0
        public void set_TexturePropertyName(){} // RVA: 0x7FFE82A1EC80
        public void get_Offset(){} // RVA: 0x7FFE82A1D460
        public void set_Offset(){} // RVA: 0x7FFE82A1D480
        public void get_Scale(){} // RVA: 0x7FFE82A1EE00
        public void set_Scale(){} // RVA: 0x7FFE82A1EE20
        public void LateUpdate(){} // RVA: 0x7FFE81768340
        public void Apply(){} // RVA: 0x7FFE82A1EE70
        public void ApplyMapping(){} // RVA: 0x7FFE82A1F410
        public void OnEnable(){} // RVA: 0x7FFE82A1FB60
        public void OnDisable(){} // RVA: 0x7FFE82A1FE60
        public void .ctor(){} // RVA: 0x7FFE82A1FE90
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        public int MaxChannels;

        // ── Methods ──
        public void get_Channel(){} // RVA: 0x7FFE811290C0
        public void set_Channel(){} // RVA: 0x7FFE811290D0
        public void Reset(){} // RVA: 0x7FFE82A1FFE0
        public void ChangeChannelCount(){} // RVA: 0x7FFE82A200A0
        public void OnAudioFilterRead(){} // RVA: 0x7FFE82A201F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class AudioOutput : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0x20
        public 0x6666D454 _audioOutputMode; // 0x28
        public int _channelMask; // 0x2C

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFE811290C0
        public void set_Player(){} // RVA: 0x7FFE82A203E0
        public void get_OutputMode(){} // RVA: 0x7FFE81549710
        public void set_OutputMode(){} // RVA: 0x7FFE817E4800
        public void get_ChannelMask(){} // RVA: 0x7FFE81F84A50
        public void set_ChannelMask(){} // RVA: 0x7FFE82883A50
        public void Awake(){} // RVA: 0x7FFE82A203F0
        public void Start(){} // RVA: 0x7FFE82A20480
        public void OnAudioConfigurationChanged(){} // RVA: 0x7FFE82A20510
        public void OnDestroy(){} // RVA: 0x7FFE82A20660
        public void Update(){} // RVA: 0x7FFE82A20670
        public void GetAudioSource(){} // RVA: 0x7FFE8143BA80
        public void ChangeMediaPlayer(){} // RVA: 0x7FFE82A207B0
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFE82A20EC0
        public void ApplyAudioSettings(){} // RVA: 0x7FFE810FB310
        public void OnAudioFilterRead(){} // RVA: 0x7FFE82A20F80
        public void .ctor(){} // RVA: 0x7FFE82A21150
    }

    public class AudioOutputManager : Object
    {
        public RenderHeads.Media.AVProVideo.AudioOutputManager _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE82A336D0
        public void .ctor(){} // RVA: 0x7FFE82A33850
        public void RequestAudio(){} // RVA: 0x7FFE82A33910
        public void ZeroAudio(){} // RVA: 0x7FFE82A342A0
        public void GrabAudio(){} // RVA: 0x7FFE82A342E0
    }

    public class AudioTrack : TrackBase
    {
        public int _bitrate; // 0x38
        public int _channelCount; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4B040 | overloaded x2
        public void get_Bitrate(){} // RVA: 0x7FFE81D46090
        public void set_Bitrate(){} // RVA: 0x7FFE81D46A00
        public void get_ChannelCount(){} // RVA: 0x7FFE816311C0
        public void set_ChannelCount(){} // RVA: 0x7FFE82A4B070
    }

    public class AudioTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE82A4AF90
    }

    public class AuthData : Object
    {
        public string _uRL; // 0x10
        public string _token; // 0x18
        public byte[] _keyBytes; // 0x20
        public object field_3; // 0x94

        // ── Methods ──
        public void get_URL(){} // RVA: 0x7FFE81116380
        public void set_URL(){} // RVA: 0x7FFE810FCE30
        public void get_Token(){} // RVA: 0x7FFE810FE7C0
        public void set_Token(){} // RVA: 0x7FFE81161E80
        public void get_KeyBytes(){} // RVA: 0x7FFE811290C0
        public void set_KeyBytes(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE82A455E0
        public void Clear(){} // RVA: 0x7FFE82A455E0
        public void get_KeyBase64(){} // RVA: 0x7FFE82A45730
        public void set_KeyBase64(){} // RVA: 0x7FFE82A45830
    }

    public class BaseMediaPlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A34400
        public void GetVersion(){} // RVA: 0x7FFE80E2E2E0
        public void GetExpectedVersion(){} // RVA: 0x7FFE80E2E2E0
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFE810FB320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFE810FB320
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFE810FB320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFE810FB320
        public void CloseMedia(){} // RVA: 0x7FFE82A34990
        public void SetLooping(){} // RVA: 0x7FFE80E466C0
        public void IsLooping(){} // RVA: 0x7FFE80E2F150
        public void HasMetaData(){} // RVA: 0x7FFE80E2F150
        public void CanPlay(){} // RVA: 0x7FFE80E2F150
        public void Play(){} // RVA: 0x7FFE80E45FE0
        public void Pause(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void Rewind(){} // RVA: 0x7FFE82A34A80
        public void Seek(){} // RVA: 0x7FFE80E476E0
        public void SeekFast(){} // RVA: 0x7FFE80E476E0
        public void SeekWithTolerance(){} // RVA: 0x7FFE82A34AA0
        public void GetCurrentTime(){} // RVA: 0x7FFE80E33FB0
        public void GetProgramDateTime(){} // RVA: 0x7FFE82A34AC0
        public void GetPlaybackRate(){} // RVA: 0x7FFE80E42E10
        public void SetPlaybackRate(){} // RVA: 0x7FFE80E53B80
        public void GetDuration(){} // RVA: 0x7FFE80E33FB0
        public void GetVideoWidth(){} // RVA: 0x7FFE80E2EDB0
        public void GetVideoHeight(){} // RVA: 0x7FFE80E2EDB0
        public void GetVideoFrameRate(){} // RVA: 0x7FFE80E42E10
        public void GetVideoDisplayRate(){} // RVA: 0x7FFE81163460
        public void HasAudio(){} // RVA: 0x7FFE80E2F150
        public void HasVideo(){} // RVA: 0x7FFE80E2F150
        public void IsVideoStereo(){} // RVA: 0x7FFE82A34B20
        public void IsSeeking(){} // RVA: 0x7FFE80E2F150
        public void IsPlaying(){} // RVA: 0x7FFE80E2F150
        public void IsPaused(){} // RVA: 0x7FFE80E2F150
        public void IsFinished(){} // RVA: 0x7FFE80E2F150
        public void IsBuffering(){} // RVA: 0x7FFE80E2F150
        public void WaitForNextFrame(){} // RVA: 0x7FFE810FB320
        public void GetTextureCount(){} // RVA: 0x7FFE811EDAF0
        public void GetTexture(){} // RVA: 0x7FFE80E3D230
        public void GetTextureFrameCount(){} // RVA: 0x7FFE80E2EDB0
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFE811E0850
        public void GetTextureTimeStamp(){} // RVA: 0x7FFE82A34B50
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE80E2F150
        public void GetTextureTransform(){} // RVA: 0x7FFE82A34B60
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFE822CD360
        public void GetYpCbCrTransform(){} // RVA: 0x7FFE82A34BD0
        public void GetTextureStereoPacking(){} // RVA: 0x7FFE82A34C30
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFE80E2EDB0
        public void GetTextureTransparency(){} // RVA: 0x7FFE81549710
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFE82A34C60
        public void MuteAudio(){} // RVA: 0x7FFE80E466C0
        public void IsMuted(){} // RVA: 0x7FFE80E2F150
        public void SetVolume(){} // RVA: 0x7FFE80E53B80
        public void SetBalance(){} // RVA: 0x7FFE810FB310
        public void GetVolume(){} // RVA: 0x7FFE80E42E10
        public void GetBalance(){} // RVA: 0x7FFE8186F320
        public void GetAudioChannelCount(){} // RVA: 0x7FFE81517DA0
        public void GetAudioChannelMask(){} // RVA: 0x7FFE813240E0
        public void GrabAudio(){} // RVA: 0x7FFE813240E0
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFE813240E0
        public void AudioConfigurationChanged(){} // RVA: 0x7FFE810FB310
        public void SetAudioHeadRotation(){} // RVA: 0x7FFE810FB310
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFE810FB310
        public void SetAudioChannelMode(){} // RVA: 0x7FFE810FB310
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFE810FB310
        public void SetAudioFocusProperties(){} // RVA: 0x7FFE810FB310
        public void SetAudioFocusRotation(){} // RVA: 0x7FFE810FB310
        public void ResetAudioFocus(){} // RVA: 0x7FFE810FB310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7FFE82A34CA0
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFE810FB310
        public void IsMediaCachingSupported(){} // RVA: 0x7FFE810FB320
        public void AddMediaToCache(){} // RVA: 0x7FFE810FB310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7FFE810FB310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7FFE810FB310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7FFE810FB310
        public void RemoveMediaFromCache(){} // RVA: 0x7FFE810FB310
        public void GetCachedMediaStatus(){} // RVA: 0x7FFE813240E0
        public void IsExternalPlaybackSupported(){} // RVA: 0x7FFE810FB320
        public void IsExternalPlaybackActive(){} // RVA: 0x7FFE810FB320
        public void SetAllowsExternalPlayback(){} // RVA: 0x7FFE810FB310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7FFE810FB310
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFE810FB310
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFE810FB310
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void BeginRender(){} // RVA: 0x7FFE810FB310
        public void Render(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void GetDecoderPerformance(){} // RVA: 0x7FFE810FB320
        public void EndUpdate(){} // RVA: 0x7FFE810FB310
        public void GetNativePlayerHandle(){} // RVA: 0x7FFE813240E0
        public void GetLastError(){} // RVA: 0x7FFE82A34CB0
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFE813240E0
        public void GetPlayerDescription(){} // RVA: 0x7FFE81116380
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFE811E0850
        public void GetSeekableTimes(){} // RVA: 0x7FFE8143BA80
        public void GetBufferedTimes(){} // RVA: 0x7FFE81178740
        public void GetTextureProperties(){} // RVA: 0x7FFE82A34CC0
        public void SetTextureProperties(){} // RVA: 0x7FFE82A34CE0
        public void ApplyTextureProperties(){} // RVA: 0x7FFE82A34D70
        public void UpdateDisplayFrameRate(){} // RVA: 0x7FFE82A34F20
        public void IsExpectingNewVideoFrame(){} // RVA: 0x7FFE82A34FF0
        public void IsPlaybackStalled(){} // RVA: 0x7FFE82A350F0
        public void LoadSubtitlesSRT(){} // RVA: 0x7FFE82A35320
        public void UpdateSubtitles(){} // RVA: 0x7FFE82A354E0
        public void GetSubtitleIndex(){} // RVA: 0x7FFE82A35640
        public void GetSubtitleText(){} // RVA: 0x7FFE82A35660
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void GetCurrentTimeFrames(){} // RVA: 0x7FFE82A356E0
        public void GetDurationFrames(){} // RVA: 0x7FFE82A357D0
        public void GetMaxFrameNumber(){} // RVA: 0x7FFE82A35890
        public void SeekToFrameRelative(){} // RVA: 0x7FFE82A358B0
        public void SeekToFrame(){} // RVA: 0x7FFE82A35A00
        public void UpdateBufferedDisplay(){} // RVA: 0x7FFE82A35B10
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFE813240E0
        public void GetBufferedFramesState(){} // RVA: 0x7FFE82A35BE0
        public void SetSlaves(){} // RVA: 0x7FFE810FB310
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFE810FB310
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFE810FB310
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFE81463AE0
        public void GetCurrentTextCue(){} // RVA: 0x7FFE81280C30
        public void UpdateTextCue(){} // RVA: 0x7FFE82A35C00
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFE80E2F150
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFE80E2E2E0
        public void GetVideoTracks(){} // RVA: 0x7FFE8113A010
        public void GetAudioTracks(){} // RVA: 0x7FFE8154EB60
        public void GetTextTracks(){} // RVA: 0x7FFE817AE360
        public void GetActiveVideoTrack(){} // RVA: 0x7FFE82A35DC0
        public void GetActiveAudioTrack(){} // RVA: 0x7FFE82A35E10
        public void GetActiveTextTrack(){} // RVA: 0x7FFE82A35E60
        public void SetActiveVideoTrack(){} // RVA: 0x7FFE82A35EB0
        public void SetActiveAudioTrack(){} // RVA: 0x7FFE82A35ED0
        public void SetActiveTextTrack(){} // RVA: 0x7FFE82A35EF0
        public void InternalIsChangedTracks(){} // RVA: 0x7FFE80E2F760
        public void InternalGetTrackCount(){} // RVA: 0x7FFE80E35520
        public void InternalSetActiveTrack(){}
        public void InternalGetTrackInfo(){}
        public void InitTracks(){} // RVA: 0x7FFE82A35F10
        public void UpdateTracks(){} // RVA: 0x7FFE82A360A0
        public void PopulateTrackCollection(){} // RVA: 0x7FFE82A36150
        public void SetActiveTrack(){} // RVA: 0x7FFE82A36340
    }

    public class BufferedFramesState : ValueType
    {
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0x20
        public 0x6667968C _scaleMode; // 0x28
        public UnityEngine.Color _color; // 0x2C
        public bool _allowTransparency; // 0x3C
        public bool _useDepth; // 0x3D
        public int _depth; // 0x40
        public bool _isAreaFullScreen; // 0x44
        public float _areaX; // 0x48
        public float _areaY; // 0x4C
        public float _areaWidth; // 0x50
        public float _areaHeight; // 0x54
        public bool _showAreaInEditor; // 0x58

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFE811290C0
        public void set_Player(){} // RVA: 0x7FFE82A211B0
        public void get_ScaleMode(){} // RVA: 0x7FFE81549710
        public void set_ScaleMode(){} // RVA: 0x7FFE817E4800
        public void get_Color(){} // RVA: 0x7FFE82A212E0
        public void set_Color(){} // RVA: 0x7FFE82A212F0
        public void get_AllowTransparency(){} // RVA: 0x7FFE812604E0
        public void set_AllowTransparency(){} // RVA: 0x7FFE812604F0
        public void get_UseDepth(){} // RVA: 0x7FFE8222A420
        public void set_UseDepth(){} // RVA: 0x7FFE82A21300
        public void get_Depth(){} // RVA: 0x7FFE8119C080
        public void set_Depth(){} // RVA: 0x7FFE8119C090
        public void get_IsAreaFullScreen(){} // RVA: 0x7FFE82876440
        public void set_IsAreaFullScreen(){} // RVA: 0x7FFE82876430
        public void get_AreaX(){} // RVA: 0x7FFE81C1C360
        public void set_AreaX(){} // RVA: 0x7FFE81C1C2E0
        public void get_AreaY(){} // RVA: 0x7FFE81A74BC0
        public void set_AreaY(){} // RVA: 0x7FFE81C1C3E0
        public void get_AreaWidth(){} // RVA: 0x7FFE81163460
        public void set_AreaWidth(){} // RVA: 0x7FFE81163470
        public void get_AreaHeight(){} // RVA: 0x7FFE81604410
        public void set_AreaHeight(){} // RVA: 0x7FFE816031A0
        public void get_ShowAreaInEditor(){} // RVA: 0x7FFE813A1140
        public void set_ShowAreaInEditor(){} // RVA: 0x7FFE819E83C0
        public void Start(){} // RVA: 0x7FFE82A21310
        public void Update(){} // RVA: 0x7FFE82A215B0
        public void OnDestroy(){} // RVA: 0x7FFE82A21690
        public void GetRequiredShader(){} // RVA: 0x7FFE82A217D0
        public void SetupMaterial(){} // RVA: 0x7FFE82A21B80
        public void OnGUI(){} // RVA: 0x7FFE82A21FD0
        public void GetAreaRect(){} // RVA: 0x7FFE82A22780
        public void .ctor(){} // RVA: 0x7FFE82A22A00
    }

    public class DisplayUGUI : MaskableGraphic
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0xE0
        public UnityEngine.Texture _defaultTexture; // 0xE8
        public UnityEngine.Rect _uvRect; // 0xF0
        public bool _setNativeSize; // 0x100
        public 0x6667968C _scaleMode; // 0x104
        public bool _noDefaultDisplay; // 0x108
        public bool _displayInEditor; // 0x109
        public int _lastWidth; // 0x10C
        public int _lastHeight; // 0x110
        public alizeAsObject _lastOrientation; // 0x114

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFE8117C900
        public void set_Player(){} // RVA: 0x7FFE82A18300
        public void get_DefaultTexture(){} // RVA: 0x7FFE8117C970
        public void set_DefaultTexture(){} // RVA: 0x7FFE82A18310
        public void get_UVRect(){} // RVA: 0x7FFE82A18490
        public void set_UVRect(){} // RVA: 0x7FFE82A184A0
        public void get_ApplyNativeSize(){} // RVA: 0x7FFE81F84400
        public void set_ApplyNativeSize(){} // RVA: 0x7FFE81F84A40
        public void get_ScaleMode(){} // RVA: 0x7FFE82A184B0
        public void set_ScaleMode(){} // RVA: 0x7FFE827ED250
        public void get_NoDefaultDisplay(){} // RVA: 0x7FFE82472660
        public void set_NoDefaultDisplay(){} // RVA: 0x7FFE82472670
        public void get_DisplayInEditor(){} // RVA: 0x7FFE82904DF0
        public void set_DisplayInEditor(){} // RVA: 0x7FFE82904650
        public void Awake(){} // RVA: 0x7FFE82A184C0
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFE82A18610
        public void ChangeMediaPlayer(){} // RVA: 0x7FFE82A18780
        public void EnsureShader(){} // RVA: 0x7FFE82A18B00
        public void EnsureAlphaPackingShader(){} // RVA: 0x7FFE82A18CC0
        public void EnsureStereoPackingShader(){} // RVA: 0x7FFE82A18DB0
        public void EnsureAndroidOESShader(){} // RVA: 0x7FFE82A18EA0
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x7FFE82A18F90
        public void Start(){} // RVA: 0x7FFE82A19080
        public void OnDestroy(){} // RVA: 0x7FFE82A19230
        public void GetRequiredShader(){} // RVA: 0x7FFE82A193C0
        public void get_mainTexture(){} // RVA: 0x7FFE82A199C0
        public void HasValidTexture(){} // RVA: 0x7FFE82A19BC0
        public void UpdateInternalMaterial(){} // RVA: 0x7FFE82A19E20
        public void LateUpdate(){} // RVA: 0x7FFE82A1A2B0
        public void get_CurrentMediaPlayer(){} // RVA: 0x7FFE8117C900
        public void set_CurrentMediaPlayer(){} // RVA: 0x7FFE82A1A940
        public void get_uvRect(){} // RVA: 0x7FFE82A18490
        public void set_uvRect(){} // RVA: 0x7FFE82A1AAD0
        public void SetNativeSize(){} // RVA: 0x7FFE82A1AB40
        public void OnPopulateMesh(){} // RVA: 0x7FFE82A1AFA0
        public void _OnFillVBO(){} // RVA: 0x7FFE82A1B050
        public void GetDrawingDimensions(){} // RVA: 0x7FFE82A1B510
        public void .ctor(){} // RVA: 0x7FFE82A1BCD0
        public void .cctor(){} // RVA: 0x7FFE82A1BE50
    }

    public class Helper : Object
    {
        // ── Methods ──
        public void GetPath(){} // RVA: 0x7FFE82A36990
        public void GetFilePath(){} // RVA: 0x7FFE82A36B10
        public void GetFriendlyResolutionName(){} // RVA: 0x7FFE82A36D60
        public void GetErrorMessage(){} // RVA: 0x7FFE82A370D0
        public void GetPlatformName(){} // RVA: 0x7FFE82A37260
        public void GetPlatformNames(){} // RVA: 0x7FFE82A37310
        public void LogInfo(){} // RVA: 0x7FFE82A37720
        public void GetUnityAudioSampleRate(){} // RVA: 0x7FFE82A37880
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x7FFE82A37930
        public void GetTimelineRange(){} // RVA: 0x7FFE82A37A10
        public void GetTimeString(){} // RVA: 0x7FFE82A37A70
        public void GetOrientation(){} // RVA: 0x7FFE82A37ED0
        public void GetMatrixForOrientation(){} // RVA: 0x7FFE82A380E0
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x7FFE82A38300
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x7FFE82A383A0
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x7FFE82A383E0
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7FFE82A38530
        public void GetShortPathName(){} // RVA: 0x7FFE82A38690
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x7FFE82A38780
        public void GetReadableTexture(){} // RVA: 0x7FFE82A38F70 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE82A39290
    }

    public class HttpHeader : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void IsComplete(){} // RVA: 0x7FFE82A4B0B0
        public void ToValidatedString(){} // RVA: 0x7FFE82A4B0E0
        public void IsValid(){} // RVA: 0x7FFE82A4B2E0 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFE82A4B280
    }

    public class HttpHeaderData : Object
    {
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.HttpHeader> httpHeaders; // 0x10

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFE82A4B320
        public void get_Item(){} // RVA: 0x7FFE82A4B400
        public void Clear(){} // RVA: 0x7FFE82A4B490
        public void Add(){} // RVA: 0x7FFE82A4B500
        public void IsModified(){} // RVA: 0x7FFE82A4B630
        public void ToValidatedString(){} // RVA: 0x7FFE82A4B680
        public void .ctor(){} // RVA: 0x7FFE82A4B8B0
    }

    public class IAudioTracks
    {
        // ── Methods ──
        public void GetAudioTracks(){} // RVA: 0x7FFE80E2E2E0
        public void GetActiveAudioTrack(){} // RVA: 0x7FFE80E2E2E0
        public void SetActiveAudioTrack(){} // RVA: 0x7FFE80E460A0
    }

    public class IBufferedDisplay
    {
        // ── Methods ──
        public void UpdateBufferedDisplay(){} // RVA: 0x7FFE80E2E2E0
        public void GetBufferedFramesState(){}
        public void SetSlaves(){} // RVA: 0x7FFE80E460A0
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFE80E48220
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFE80E466C0
    }

    public class IMediaCache
    {
        // ── Methods ──
        public void IsMediaCachingSupported(){} // RVA: 0x7FFE80E2F150
        public void AddMediaToCache(){} // RVA: 0x7FFE80E50660
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7FFE80E460A0
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7FFE80E460A0
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7FFE80E460A0
        public void RemoveMediaFromCache(){} // RVA: 0x7FFE80E460A0
        public void GetCachedMediaStatus(){} // RVA: 0x7FFE80E38BF0
    }

    public class IMediaControl
    {
        // ── Methods ──
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFE80E2F3B0
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFE80E2FC30
        public void AddChunkToMediaBuffer(){}
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFE80E2F150
        public void CloseMedia(){} // RVA: 0x7FFE80E45FE0
        public void SetLooping(){} // RVA: 0x7FFE80E466C0
        public void IsLooping(){} // RVA: 0x7FFE80E2F150
        public void HasMetaData(){} // RVA: 0x7FFE80E2F150
        public void CanPlay(){} // RVA: 0x7FFE80E2F150
        public void IsPlaying(){} // RVA: 0x7FFE80E2F150
        public void IsSeeking(){} // RVA: 0x7FFE80E2F150
        public void IsPaused(){} // RVA: 0x7FFE80E2F150
        public void IsFinished(){} // RVA: 0x7FFE80E2F150
        public void IsBuffering(){} // RVA: 0x7FFE80E2F150
        public void Play(){} // RVA: 0x7FFE80E45FE0
        public void Pause(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void Rewind(){} // RVA: 0x7FFE80E45FE0
        public void Seek(){} // RVA: 0x7FFE80E476E0
        public void SeekFast(){} // RVA: 0x7FFE80E476E0
        public void SeekWithTolerance(){} // RVA: 0x7FFE810A1420
        public void SeekToFrame(){} // RVA: 0x7FFE80E49A70
        public void SeekToFrameRelative(){} // RVA: 0x7FFE80E49A70
        public void GetCurrentTime(){} // RVA: 0x7FFE80E33FB0
        public void GetCurrentTimeFrames(){}
        public void GetProgramDateTime(){} // RVA: 0x7FFE80E2E2E0
        public void GetPlaybackRate(){} // RVA: 0x7FFE80E42E10
        public void SetPlaybackRate(){} // RVA: 0x7FFE80E53B80
        public void MuteAudio(){} // RVA: 0x7FFE80E466C0
        public void IsMuted(){} // RVA: 0x7FFE80E2F150
        public void SetVolume(){} // RVA: 0x7FFE80E53B80
        public void SetBalance(){} // RVA: 0x7FFE80E53B80
        public void GetVolume(){} // RVA: 0x7FFE80E42E10
        public void GetBalance(){} // RVA: 0x7FFE80E42E10
        public void GetSeekableTimes(){} // RVA: 0x7FFE80E2E2E0
        public void GetBufferedTimes(){} // RVA: 0x7FFE80E2E2E0
        public void GetLastError(){} // RVA: 0x7FFE80E2EDB0
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFE80E2E2E0
        public void SetTextureProperties(){}
        public void GetTextureProperties(){} // RVA: 0x7FFE80E50660
        public void GrabAudio(){}
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetAudioChannelCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetAudioChannelMask(){} // RVA: 0x7FFE80E2EDB0
        public void AudioConfigurationChanged(){} // RVA: 0x7FFE80E466C0
        public void SetAudioChannelMode(){} // RVA: 0x7FFE80E46530
        public void SetAudioHeadRotation(){} // RVA: 0x7FFE80E460A0
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFE80E45FE0
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFE80E466C0
        public void SetAudioFocusProperties(){}
        public void SetAudioFocusRotation(){} // RVA: 0x7FFE80E460A0
        public void ResetAudioFocus(){} // RVA: 0x7FFE80E45FE0
        public void WaitForNextFrame(){} // RVA: 0x7FFE80E31D70
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFE80E466C0
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFE80E460A0
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFE80E460A0
        public void IsExternalPlaybackActive(){} // RVA: 0x7FFE80E2F150
        public void SetAllowsExternalPlayback(){} // RVA: 0x7FFE80E466C0
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7FFE80E46530
    }

    public class IMediaInfo
    {
        // ── Methods ──
        public void GetDuration(){} // RVA: 0x7FFE80E33FB0
        public void GetDurationFrames(){}
        public void GetMaxFrameNumber(){}
        public void GetVideoWidth(){} // RVA: 0x7FFE80E2EDB0
        public void GetVideoHeight(){} // RVA: 0x7FFE80E2EDB0
        public void GetVideoFrameRate(){} // RVA: 0x7FFE80E42E10
        public void GetVideoDisplayRate(){} // RVA: 0x7FFE80E42E10
        public void HasVideo(){} // RVA: 0x7FFE80E2F150
        public void HasAudio(){} // RVA: 0x7FFE80E2F150
        public void GetPlayerDescription(){} // RVA: 0x7FFE80E2E2E0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFE80E2F150
        public void IsPlaybackStalled(){} // RVA: 0x7FFE80E2F150
        public void GetTextureTransform(){} // RVA: 0x7FFE80E2E2E0
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7FFE80E2E2E0
        public void IsExternalPlaybackSupported(){} // RVA: 0x7FFE80E2F150
        public void GetDecoderPerformance(){}
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE80E45FE0
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void EndUpdate(){} // RVA: 0x7FFE80E45FE0
        public void BeginRender(){} // RVA: 0x7FFE80E45FE0
        public void Render(){} // RVA: 0x7FFE80E45FE0
        public void GetNativePlayerHandle(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMediaSubtitles
    {
        // ── Methods ──
        public void LoadSubtitlesSRT(){} // RVA: 0x7FFE80E2F3B0
        public void GetSubtitleIndex(){} // RVA: 0x7FFE80E2EDB0
        public void GetSubtitleText(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ITextTracks
    {
        // ── Methods ──
        public void GetTextTracks(){} // RVA: 0x7FFE80E2E2E0
        public void GetActiveTextTrack(){} // RVA: 0x7FFE80E2E2E0
        public void SetActiveTextTrack(){} // RVA: 0x7FFE80E460A0
        public void GetCurrentTextCue(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0x7FFE80E2EDB0
        public void GetTexture(){} // RVA: 0x7FFE80E3D230
        public void GetTextureFrameCount(){} // RVA: 0x7FFE80E2EDB0
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFE80E2F150
        public void GetTextureTimeStamp(){} // RVA: 0x7FFE80E2E2E0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFE80E42E10
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE80E2F150
        public void GetTextureStereoPacking(){} // RVA: 0x7FFE80E2EDB0
        public void GetTextureTransparency(){} // RVA: 0x7FFE80E2EDB0
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFE80E2EDB0
        public void GetYpCbCrTransform(){}
    }

    public class IVideoTracks
    {
        // ── Methods ──
        public void GetVideoTracks(){} // RVA: 0x7FFE80E2E2E0
        public void GetActiveVideoTrack(){} // RVA: 0x7FFE80E2E2E0
        public void SetActiveVideoTrack(){} // RVA: 0x7FFE80E460A0
    }

    public class KeyAuthData : Object
    {
        // ── Methods ──
        public void IsModified(){} // RVA: 0x7FFE82A4B970
        public void OnBeforeSerialize(){} // RVA: 0x7FFE82A4B9A0
        public void OnAfterDeserialize(){} // RVA: 0x7FFE82A4BA10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LazyShaderProperty : ValueType
    {
        public string _name; // 0x10
        public int _id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4F890
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void get_Id(){} // RVA: 0x7FFE82A4F900
    }

    public class MediaCachingOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MediaHints : ValueType
    {
        public 0x6666EB04 transparency; // 0x10

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFE82A39CE0
        public void .cctor(){} // RVA: 0x7FFE810FB310
    }

    public class MediaPath : Object
    {
        public 0x6666E844 _pathType; // 0x10
        public string _path; // 0x18

        // ── Methods ──
        public void get_PathType(){} // RVA: 0x7FFE811485C0
        public void set_PathType(){} // RVA: 0x7FFE810FE0C0
        public void get_Path(){} // RVA: 0x7FFE810FE7C0
        public void set_Path(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE82A39920 | overloaded x3
        public void GetResolvedFullPath(){} // RVA: 0x7FFE82A39A30
        public void op_Equality(){} // RVA: 0x7FFE82A39B00
        public void op_Inequality(){} // RVA: 0x7FFE82A39B20
        public void Equals(){} // RVA: 0x7FFE82A39B60
        public void GetHashCode(){} // RVA: 0x7FFE82A39CA0
    }

    public class MediaPlayer : MonoBehaviour
    {
        public 0x6666E7EC _mediaSource; // 0x20
        public RenderHeads.Media.AVProVideo.MediaReference _mediaReference; // 0x28
        public RenderHeads.Media.AVProVideo.MediaPath _mediaPath; // 0x30
        public RenderHeads.Media.AVProVideo.MediaHints _fallbackMediaHints; // 0x38
        public bool _autoOpen; // 0x44
        public bool _autoPlayOnStart; // 0x45
        public bool _loop; // 0x46
        public float _audioVolume; // 0x48
        public float _audioBalance; // 0x4C
        public bool _audioMuted; // 0x50
        public UnityEngine.AudioSource _audioSource; // 0x58
        public float _playbackRate; // 0x60
        public bool _useResampler; // 0x64
        public 0x66670054 _resampleMode; // 0x68
        public int _resampleBufferSize; // 0x6C
        public RenderHeads.Media.AVProVideo.Resampler _resampler; // 0x70
        public 0x6666ECBC _videoMapping; // 0x78
        public 0x665757DC _textureFilterMode; // 0x7C
        public 0x66575834 _textureWrapMode; // 0x80
        public int _textureAnisoLevel; // 0x84
        public bool _sideloadSubtitles; // 0x88
        public RenderHeads.Media.AVProVideo.MediaPath _subtitlePath; // 0x90
        public UnityEngine.Transform _audioHeadTransform; // 0x98
        public bool _audioFocusEnabled; // 0xA0
        public UnityEngine.Transform _audioFocusTransform; // 0xA8
        public float _audioFocusWidthDegrees; // 0xB0
        public float _audioFocusOffLevelDB; // 0xB4
        public RenderHeads.Media.AVProVideo.HttpHeaderData _httpHeaders; // 0xB8
        public RenderHeads.Media.AVProVideo.KeyAuthData _keyAuth; // 0xC0
        public RenderHeads.Media.AVProVideo.MediaPlayerEvent _events; // 0xC8
        public int _eventMask; // 0xD0
        public bool _pauseMediaOnAppPause; // 0xD4
        public bool _playMediaOnAppUnpause; // 0xD5
        public bool _persistent; // 0xD6
        public 0x6666ED14 _forceFileFormat; // 0xD8
        public RenderHeads.Media.AVProVideo.BaseMediaPlayer _baseMediaPlayer; // 0xE0
        public RenderHeads.Media.AVProVideo.IMediaControl _controlInterface; // 0xE8
        public RenderHeads.Media.AVProVideo.ITextureProducer _textureInterface; // 0xF0
        public RenderHeads.Media.AVProVideo.IMediaInfo _infoInterface; // 0xF8
        public RenderHeads.Media.AVProVideo.IMediaPlayer _playerInterface; // 0x100
        public RenderHeads.Media.AVProVideo.IMediaSubtitles _subtitlesInterface; // 0x108
        public RenderHeads.Media.AVProVideo.IMediaCache _cacheInterface; // 0x110
        public RenderHeads.Media.AVProVideo.IBufferedDisplay _bufferedDisplayInterface; // 0x118
        public RenderHeads.Media.AVProVideo.IVideoTracks _videoTracksInterface; // 0x120
        public RenderHeads.Media.AVProVideo.IAudioTracks _audioTracksInterface; // 0x128
        public RenderHeads.Media.AVProVideo.ITextTracks _textTracksInterface; // 0x130
        public System.IDisposable _disposeInterface; // 0x138
        public bool _isMediaOpened; // 0x140
        public bool _autoPlayOnStartTriggered; // 0x141
        public bool _wasPlayingOnPause; // 0x142
        public UnityEngine.Coroutine _renderingCoroutine; // 0x148
        public bool s_GlobalStartup;
        public bool s_TrialVersion; // 0x1

        // ── Methods ──
        public void get_MediaSource(){} // RVA: 0x7FFE8151D690
        public void set_MediaSource(){} // RVA: 0x7FFE8170B670
        public void get_MediaReference(){} // RVA: 0x7FFE81129130
        public void set_MediaReference(){} // RVA: 0x7FFE810FCE90
        public void get_MediaPath(){} // RVA: 0x7FFE8144E200
        public void set_MediaPath(){} // RVA: 0x7FFE81129890
        public void get_FallbackMediaHints(){} // RVA: 0x7FFE81161F40
        public void set_FallbackMediaHints(){} // RVA: 0x7FFE81161F60
        public void get_AutoOpen(){} // RVA: 0x7FFE82876440
        public void set_AutoOpen(){} // RVA: 0x7FFE82876430
        public void get_AutoStart(){} // RVA: 0x7FFE82A22A70
        public void set_AutoStart(){} // RVA: 0x7FFE82A22A80
        public void get_Loop(){} // RVA: 0x7FFE82A22A90
        public void set_Loop(){} // RVA: 0x7FFE82A22AF0
        public void get_AudioVolume(){} // RVA: 0x7FFE82A22B60
        public void set_AudioVolume(){} // RVA: 0x7FFE82A22BC0
        public void get_AudioBalance(){} // RVA: 0x7FFE82A22C50
        public void set_AudioBalance(){} // RVA: 0x7FFE82A22CB0
        public void get_AudioMuted(){} // RVA: 0x7FFE82A22D40
        public void set_AudioMuted(){} // RVA: 0x7FFE82A22DA0
        public void get_AudioSource(){} // RVA: 0x7FFE811C3500
        public void set_AudioSource(){} // RVA: 0x7FFE811C3510
        public void get_PlaybackRate(){} // RVA: 0x7FFE82A22E10
        public void set_PlaybackRate(){} // RVA: 0x7FFE82A22E70
        public void get_UseResampler(){} // RVA: 0x7FFE821FF050
        public void set_UseResampler(){} // RVA: 0x7FFE82A22EE0
        public void get_ResampleMode(){} // RVA: 0x7FFE82A22EF0
        public void set_ResampleMode(){} // RVA: 0x7FFE82A22F00
        public void get_ResampleBufferSize(){} // RVA: 0x7FFE82A22F10
        public void set_ResampleBufferSize(){} // RVA: 0x7FFE82A22F20
        public void get_FrameResampler(){} // RVA: 0x7FFE811C3590
        public void get_VideoLayoutMapping(){} // RVA: 0x7FFE8286C0A0
        public void set_VideoLayoutMapping(){} // RVA: 0x7FFE82862F10
        public void get_TextureFilterMode(){} // RVA: 0x7FFE82A22F30
        public void set_TextureFilterMode(){} // RVA: 0x7FFE82A23030
        public void get_TextureWrapMode(){} // RVA: 0x7FFE82A230B0
        public void set_TextureWrapMode(){} // RVA: 0x7FFE82A231B0
        public void get_TextureAnisoLevel(){} // RVA: 0x7FFE82A23230
        public void set_TextureAnisoLevel(){} // RVA: 0x7FFE82A23330
        public void get_SideloadSubtitles(){} // RVA: 0x7FFE820C4230
        public void set_SideloadSubtitles(){} // RVA: 0x7FFE820C0790
        public void get_SubtitlePath(){} // RVA: 0x7FFE8154EB60
        public void set_SubtitlePath(){} // RVA: 0x7FFE818CE320
        public void set_AudioHeadTransform(){} // RVA: 0x7FFE8171B470
        public void get_AudioHeadTransform(){} // RVA: 0x7FFE817AE360
        public void get_AudioFocusEnabled(){} // RVA: 0x7FFE820E9360
        public void set_AudioFocusEnabled(){} // RVA: 0x7FFE818DBD80
        public void get_AudioFocusTransform(){} // RVA: 0x7FFE817AB5E0
        public void set_AudioFocusTransform(){} // RVA: 0x7FFE81857260
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x7FFE820D7060
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x7FFE81F57C10
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x7FFE82A233B0
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x7FFE82A233C0
        public void get_HttpHeaders(){} // RVA: 0x7FFE811660B0
        public void set_HttpHeaders(){} // RVA: 0x7FFE811660C0
        public void get_KeyAuth(){} // RVA: 0x7FFE81166120
        public void set_KeyAuth(){} // RVA: 0x7FFE81166130
        public void get_Events(){} // RVA: 0x7FFE82A233D0
        public void get_EventMask(){} // RVA: 0x7FFE817E0030
        public void set_EventMask(){} // RVA: 0x7FFE82862FC0
        public void get_PauseMediaOnAppPause(){} // RVA: 0x7FFE82A23490
        public void set_PauseMediaOnAppPause(){} // RVA: 0x7FFE82A234A0
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x7FFE82A234B0
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x7FFE82A234C0
        public void get_Persistent(){} // RVA: 0x7FFE82A234D0
        public void set_Persistent(){} // RVA: 0x7FFE82A234E0
        public void get_ForceFileFormat(){} // RVA: 0x7FFE82A234F0
        public void set_ForceFileFormat(){} // RVA: 0x7FFE82A23500
        public void get_Info(){} // RVA: 0x7FFE8158D5D0
        public void get_Control(){} // RVA: 0x7FFE8117C970
        public void get_Player(){} // RVA: 0x7FFE81828B50
        public void get_TextureProducer(){} // RVA: 0x7FFE811662A0
        public void get_Subtitles(){} // RVA: 0x7FFE8181E3D0
        public void get_VideoTracks(){} // RVA: 0x7FFE813A1DA0
        public void get_AudioTracks(){} // RVA: 0x7FFE8182B890
        public void get_TextTracks(){} // RVA: 0x7FFE81823850
        public void get_Cache(){} // RVA: 0x7FFE81317980
        public void get_BufferedDisplay(){} // RVA: 0x7FFE81318010
        public void get_MediaOpened(){} // RVA: 0x7FFE82A23510
        public void Awake(){} // RVA: 0x7FFE82A23520
        public void Initialise(){} // RVA: 0x7FFE82A235C0
        public void Start(){} // RVA: 0x7FFE82A23FC0
        public void OpenMedia(){} // RVA: 0x7FFE82A24280 | overloaded x4
        public void InternalOpenMedia(){} // RVA: 0x7FFE82A242B0
        public void SetLoadOptions(){} // RVA: 0x7FFE82A24AA0
        public void SetPlaybackOptions(){} // RVA: 0x7FFE82A24B70
        public void CloseMedia(){} // RVA: 0x7FFE82A24CA0
        public void RewindPrerollPause(){} // RVA: 0x7FFE82A24E40
        public void Play(){} // RVA: 0x7FFE82A24F30
        public void Pause(){} // RVA: 0x7FFE82A24FD0
        public void Stop(){} // RVA: 0x7FFE82A25050
        public void Rewind(){} // RVA: 0x7FFE82A250B0
        public void SeekToLiveTime(){} // RVA: 0x7FFE82A25140
        public void Update(){} // RVA: 0x7FFE82A251E0
        public void LateUpdate(){} // RVA: 0x7FFE82A25410
        public void UpdateResampler(){} // RVA: 0x7FFE82A255F0
        public void OnEnable(){} // RVA: 0x7FFE82A25780
        public void OnDisable(){} // RVA: 0x7FFE82A25800
        public void OnDestroy(){} // RVA: 0x7FFE82A258A0
        public void ForceDispose(){} // RVA: 0x7FFE82A25F00
        public void AllPlayersDispose(){} // RVA: 0x7FFE82A25FB0
        public void HandleApplicationQuit(){} // RVA: 0x7FFE82A260F0
        public void StartRenderCoroutine(){} // RVA: 0x7FFE82A26410
        public void StopRenderCoroutine(){} // RVA: 0x7FFE82A26530
        public void FinalRenderCapture(){} // RVA: 0x7FFE82A265B0
        public void GetPlatform(){} // RVA: 0x7FFE813240E0
        public void GetCurrentPlatformOptions(){} // RVA: 0x7FFE815BB1F0
        public void GetPlatformVideoApiString(){} // RVA: 0x7FFE82A26650
        public void GetPlatformFileOffset(){} // RVA: 0x7FFE813240E0
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x7FFE82A266D0
        public void GetResolvedFilePath(){} // RVA: 0x7FFE82A26780
        public void CreateMediaPlayer(){} // RVA: 0x7FFE82A26AA0 | overloaded x2
        public void CreateMediaPlayerNull(){} // RVA: 0x7FFE82A26A30
        public void UpdateAudioFocus(){} // RVA: 0x7FFE82A26E50
        public void UpdateAudioHeadTransform(){} // RVA: 0x7FFE82A270D0
        public void UpdateErrors(){} // RVA: 0x7FFE82A272F0
        public void IsUsingAndroidOESPath(){} // RVA: 0x7FFE82A275A0
        public void OnApplicationFocus(){} // RVA: 0x7FFE810FB310
        public void OnApplicationPause(){} // RVA: 0x7FFE810FB310
        public void ResetEvents(){} // RVA: 0x7FFE82A275F0
        public void UpdateEvents(){} // RVA: 0x7FFE82A27620
        public void IsHandleEvent(){} // RVA: 0x7FFE82A27B00
        public void FireEventIfPossible(){} // RVA: 0x7FFE82A27B30
        public void CanFireEvent(){} // RVA: 0x7FFE82A27BC0
        public void ForceWaitForNewFrame(){} // RVA: 0x7FFE82A28060
        public void GetDummyCamera(){} // RVA: 0x7FFE82A28290
        public void ExtractFrameCoroutine(){} // RVA: 0x7FFE82A28700
        public void ExtractFrameAsync(){} // RVA: 0x7FFE82A28880
        public void ExtractFrame(){} // RVA: 0x7FFE82A28C10 | overloaded x2
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFE82A28EB0
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x7FFE82A28FB0
        public void AddChunkToVideoBuffer(){} // RVA: 0x7FFE82A29230
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x7FFE82A29350
        public void OpenMediaFromBufferInternal(){} // RVA: 0x7FFE82A293E0
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x7FFE82A29640
        public void AddChunkToBufferInternal(){} // RVA: 0x7FFE82A29230
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x7FFE82A29350
        public void get_PlatformOptionsWindows(){} // RVA: 0x7FFE815BB1F0
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7FFE81B38340
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFE81B295E0
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7FFE81825EC0
        public void get_PlatformOptionsAndroid(){} // RVA: 0x7FFE8181EA60
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x7FFE81B32390
        public void get_PlatformOptionsWebGL(){} // RVA: 0x7FFE8182AF50
        public void EnableSubtitles(){} // RVA: 0x7FFE82A29820
        public void LoadSubtitlesCoroutine(){} // RVA: 0x7FFE82A29C70
        public void DisableSubtitles(){} // RVA: 0x7FFE82A29DD0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE82A29F40
        public void .ctor(){} // RVA: 0x7FFE82A2A0C0
    }

    public class MediaPlayerEvent : UnityEvent`3
    {
        // ── Methods ──
        public void HasListeners(){} // RVA: 0x7FFE82A36470
        public void AddListener(){} // RVA: 0x7FFE82A36500
        public void RemoveListener(){} // RVA: 0x7FFE82A36680
        public void RemoveAllListeners(){} // RVA: 0x7FFE82A36780
        public void .ctor(){} // RVA: 0x7FFE82A367F0
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A36430
    }

    public class MediaPlaylist : Object
    {
        public System.Collections.Generic.List`1<MediaItem> _items; // 0x10

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE81116380
        public void HasItemAt(){} // RVA: 0x7FFE82A2C090
        public void .ctor(){} // RVA: 0x7FFE82A2C100
    }

    public class MediaReference : ScriptableObject
    {
        public string _alias; // 0x18
        public RenderHeads.Media.AVProVideo.MediaPath _mediaPath; // 0x20
        public RenderHeads.Media.AVProVideo.MediaHints _hints; // 0x28

        // ── Methods ──
        public void get_Alias(){} // RVA: 0x7FFE810FE7C0
        public void set_Alias(){} // RVA: 0x7FFE81161E80
        public void get_MediaPath(){} // RVA: 0x7FFE811290C0
        public void set_MediaPath(){} // RVA: 0x7FFE811290D0
        public void get_Hints(){} // RVA: 0x7FFE81176700
        public void set_Hints(){} // RVA: 0x7FFE81176720
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x7FFE82A1CC90
        public void GetPlatformMediaReference(){} // RVA: 0x7FFE82A1CD60
        public void .ctor(){} // RVA: 0x7FFE82A1CDE0
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x7FFE82A3B170
        public void GetExpectedVersion(){} // RVA: 0x7FFE82A3B1B0
        public void OpenMedia(){} // RVA: 0x7FFE82A3B1D0
        public void CloseMedia(){} // RVA: 0x7FFE82A3B510
        public void SetLooping(){} // RVA: 0x7FFE8111C4D0
        public void IsLooping(){} // RVA: 0x7FFE8111C4C0
        public void HasMetaData(){} // RVA: 0x7FFE811E0850
        public void CanPlay(){} // RVA: 0x7FFE811E0850
        public void HasAudio(){} // RVA: 0x7FFE810FB320
        public void HasVideo(){} // RVA: 0x7FFE810FB320
        public void Play(){} // RVA: 0x7FFE82A3B550
        public void Pause(){} // RVA: 0x7FFE82A3B570
        public void Stop(){} // RVA: 0x7FFE82A3B580
        public void IsSeeking(){} // RVA: 0x7FFE810FB320
        public void IsPlaying(){} // RVA: 0x7FFE813A1D80
        public void IsPaused(){} // RVA: 0x7FFE81F57AF0
        public void IsFinished(){} // RVA: 0x7FFE82A3B590
        public void IsBuffering(){} // RVA: 0x7FFE810FB320
        public void GetDuration(){} // RVA: 0x7FFE82A3B5E0
        public void GetVideoWidth(){} // RVA: 0x7FFE82A3B5F0
        public void GetVideoHeight(){} // RVA: 0x7FFE81790750
        public void GetVideoDisplayRate(){} // RVA: 0x7FFE8186D840
        public void GetTexture(){} // RVA: 0x7FFE81218100
        public void GetTextureFrameCount(){} // RVA: 0x7FFE82A3B600
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFE813B49D0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE810FB320
        public void Seek(){} // RVA: 0x7FFE82A3B610
        public void SeekFast(){} // RVA: 0x7FFE82A3B610
        public void GetCurrentTime(){} // RVA: 0x7FFE82A3B620
        public void SetPlaybackRate(){} // RVA: 0x7FFE82A3B630
        public void GetPlaybackRate(){} // RVA: 0x7FFE82A3B640
        public void MuteAudio(){} // RVA: 0x7FFE810FB310
        public void IsMuted(){} // RVA: 0x7FFE811E0850
        public void SetVolume(){} // RVA: 0x7FFE82A3B650
        public void GetVolume(){} // RVA: 0x7FFE82A3B660
        public void GetVideoFrameRate(){} // RVA: 0x7FFE8186F320
        public void Update(){} // RVA: 0x7FFE82A3B670
        public void Render(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void InternalSetActiveTrack(){} // RVA: 0x7FFE810FB320
        public void InternalIsChangedTracks(){} // RVA: 0x7FFE810FB320
        public void InternalGetTrackCount(){} // RVA: 0x7FFE813240E0
        public void InternalGetTrackInfo(){} // RVA: 0x7FFE813240E0
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFE810FB320
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE82A3B960
    }

    public class OptionsAppleExtensions : Object
    {
        // ── Methods ──
        public void GenerateMipmaps(){} // RVA: 0x7FFE82A2BFA0
        public void SetGenerateMipMaps(){} // RVA: 0x7FFE82A2BFB0
        public void AllowExternalPlayback(){} // RVA: 0x7FFE82A2BFD0
        public void SetAllowExternalPlayback(){} // RVA: 0x7FFE82A2BFE0
        public void PlayWithoutBuffering(){} // RVA: 0x7FFE82A2C000
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFE82A2C010
        public void UseSinglePlayerItem(){} // RVA: 0x7FFE82A2C030
        public void SetUseSinglePlayerItem(){} // RVA: 0x7FFE82A2C040
        public void ResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7FFE82A2C060
        public void SetResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7FFE82A2C070
    }

    public class PlaybackQualityStats : Object
    {
        public int _skippedFrames; // 0x10
        public int _duplicateFrames; // 0x14
        public int _unityDroppedFrames; // 0x18
        public float _perfectFramesT; // 0x1C
        public string _vSyncStatus; // 0x20
        public int _perfectFrames; // 0x28
        public int _totalFrames; // 0x2C
        public bool _logIssues; // 0x30

        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0x7FFE811485C0
        public void set_SkippedFrames(){} // RVA: 0x7FFE810FE0C0
        public void get_DuplicateFrames(){} // RVA: 0x7FFE8164B230
        public void set_DuplicateFrames(){} // RVA: 0x7FFE8164E0F0
        public void get_UnityDroppedFrames(){} // RVA: 0x7FFE813DB630
        public void set_UnityDroppedFrames(){} // RVA: 0x7FFE8144DF00
        public void get_PerfectFramesT(){} // RVA: 0x7FFE811C8570
        public void set_PerfectFramesT(){} // RVA: 0x7FFE811C8580
        public void get_VSyncStatus(){} // RVA: 0x7FFE811290C0
        public void set_VSyncStatus(){} // RVA: 0x7FFE811290D0
        public void get_PerfectFrames(){} // RVA: 0x7FFE81549710
        public void set_PerfectFrames(){} // RVA: 0x7FFE817E4800
        public void get_TotalFrames(){} // RVA: 0x7FFE81F84A50
        public void set_TotalFrames(){} // RVA: 0x7FFE82883A50
        public void get_LogIssues(){} // RVA: 0x7FFE81121450
        public void set_LogIssues(){} // RVA: 0x7FFE81121460
        public void Reset(){} // RVA: 0x7FFE82A3A480
        public void Start(){} // RVA: 0x7FFE82A3A4D0
        public void Update(){} // RVA: 0x7FFE82A3AAD0
        public void IsGameViewVSyncEnabled(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        public UnityEngine.Shader _transitionShader; // 0x1C0
        public RenderHeads.Media.AVProVideo.MediaPlayer _playerA; // 0x1C8
        public RenderHeads.Media.AVProVideo.MediaPlayer _playerB; // 0x1D0
        public bool _playlistAutoProgress; // 0x1D8
        public bool _autoCloseVideo; // 0x1D9
        public 0x6666DE4C _playlistLoopMode; // 0x1DC
        public RenderHeads.Media.AVProVideo.MediaPlaylist _playlist; // 0x1E0
        public bool _pausePreviousOnTransition; // 0x1E8
        public 0x6666DDF4 _defaultTransition; // 0x1EC
        public float _defaultTransitionDuration; // 0x1F0
        public 0x6666DF54 _defaultTransitionEasing; // 0x1F4
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropFromTex;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropFade; // 0x10
        public bool _isPaused; // 0x1F8
        public int _playlistIndex; // 0x1FC
        public RenderHeads.Media.AVProVideo.MediaPlayer _nextPlayer; // 0x200

        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x7FFE82A2C380
        public void get_NextPlayer(){} // RVA: 0x7FFE81B14500
        public void get_Playlist(){} // RVA: 0x7FFE816611A0
        public void get_PlaylistIndex(){} // RVA: 0x7FFE82A2C4D0
        public void get_PlaylistItem(){} // RVA: 0x7FFE82A2C4E0
        public void get_DefaultTransition(){} // RVA: 0x7FFE82A2C5D0
        public void set_DefaultTransition(){} // RVA: 0x7FFE82A2C5E0
        public void get_DefaultTransitionDuration(){} // RVA: 0x7FFE82A2C5F0
        public void set_DefaultTransitionDuration(){} // RVA: 0x7FFE82A2C600
        public void get_DefaultTransitionEasing(){} // RVA: 0x7FFE82A2C610
        public void set_DefaultTransitionEasing(){} // RVA: 0x7FFE82A2C620
        public void get_AutoCloseVideo(){} // RVA: 0x7FFE82A2C630
        public void set_AutoCloseVideo(){} // RVA: 0x7FFE82A2C640
        public void get_LoopMode(){} // RVA: 0x7FFE82A2C650
        public void set_LoopMode(){} // RVA: 0x7FFE82A2C660
        public void get_AutoProgress(){} // RVA: 0x7FFE82A2C670
        public void set_AutoProgress(){} // RVA: 0x7FFE82A2C680
        public void get_Info(){} // RVA: 0x7FFE82A2C690
        public void get_Control(){} // RVA: 0x7FFE82A2C7A0
        public void get_TextureProducer(){} // RVA: 0x7FFE82A2C8B0
        public void get_AudioVolume(){} // RVA: 0x7FFE82A2C9E0
        public void set_AudioVolume(){} // RVA: 0x7FFE82A2C9F0
        public void get_AudioMuted(){} // RVA: 0x7FFE82A2CB40
        public void set_AudioMuted(){} // RVA: 0x7FFE82A2CB50
        public void Play(){} // RVA: 0x7FFE82A2CC80
        public void Pause(){} // RVA: 0x7FFE82A2CD90
        public void IsPaused(){} // RVA: 0x7FFE82A2CE90
        public void SwapPlayers(){} // RVA: 0x7FFE82A2CEA0
        public void GetCurrentTexture(){} // RVA: 0x7FFE82A2D890
        public void GetNextTexture(){} // RVA: 0x7FFE82A2D9F0
        public void Awake(){} // RVA: 0x7FFE82A2DB40
        public void OnDestroy(){} // RVA: 0x7FFE82A2DEF0
        public void Start(){} // RVA: 0x7FFE82A2E230
        public void OnVideoEvent(){} // RVA: 0x7FFE82A2E490
        public void PrevItem(){} // RVA: 0x7FFE82A2E850
        public void NextItem(){} // RVA: 0x7FFE82A2E860
        public void CanJumpToItem(){} // RVA: 0x7FFE82A2E8E0
        public void JumpToItem(){} // RVA: 0x7FFE82A2E9C0
        public void OpenVideoFile(){} // RVA: 0x7FFE82A2EB90
        public void IsTransitioning(){} // RVA: 0x7FFE82A2EF40
        public void SetTransition(){} // RVA: 0x7FFE82A2F040
        public void Update(){} // RVA: 0x7FFE82A2F210
        public void GetTexture(){} // RVA: 0x7FFE81B20B50
        public void GetTextureCount(){} // RVA: 0x7FFE82A2F8B0
        public void GetTextureFrameCount(){} // RVA: 0x7FFE82A2F930
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFE82A2F9B0
        public void GetTextureTimeStamp(){} // RVA: 0x7FFE82A2FA30
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFE82A2FAB0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE82A2FB30
        public void GetYpCbCrTransform(){} // RVA: 0x7FFE82A2FBB0
        public void GetTextureStereoPacking(){} // RVA: 0x7FFE82A2FC60
        public void GetTextureTransparency(){} // RVA: 0x7FFE82A2FCE0
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFE82A2FD60
        public void GetTransitionName(){} // RVA: 0x7FFE82A2FDE0
        public void .ctor(){} // RVA: 0x7FFE82A30110
        public void .cctor(){} // RVA: 0x7FFE82A303B0
    }

    public class Resampler : Object
    {
        public System.Collections.Generic.List`1<TimestampedRenderTexture[]> _buffer; // 0x10
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0x18
        public UnityEngine.RenderTexture[] _outputTexture; // 0x20
        public int _start; // 0x28
        public int _end; // 0x2C
        public int _bufferSize; // 0x30
        public long _baseTimestamp; // 0x38

        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x7FFE82A22EF0
        public void get_FrameDisplayedTimer(){} // RVA: 0x7FFE8286C0A0
        public void get_BaseTimestamp(){} // RVA: 0x7FFE8143BA80
        public void set_BaseTimestamp(){} // RVA: 0x7FFE81CDDAA0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7FFE815E8460
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7FFE815E8470
        public void get_LastT(){} // RVA: 0x7FFE81683320
        public void set_LastT(){} // RVA: 0x7FFE8167C150
        public void get_TextureTimeStamp(){} // RVA: 0x7FFE8154EB60
        public void set_TextureTimeStamp(){} // RVA: 0x7FFE81854020
        public void OnVideoEvent(){} // RVA: 0x7FFE82A4BC10
        public void .ctor(){} // RVA: 0x7FFE82A4BCF0
        public void get_OutputTexture(){} // RVA: 0x7FFE811290C0
        public void Reset(){} // RVA: 0x7FFE82A4C230
        public void Release(){} // RVA: 0x7FFE82A4C250
        public void ReleaseRenderTextures(){} // RVA: 0x7FFE82A4C3E0
        public void ConstructRenderTextures(){} // RVA: 0x7FFE82A4C730
        public void CheckRenderTexturesValid(){} // RVA: 0x7FFE82A4CD10
        public void FindBeforeFrameIndex(){} // RVA: 0x7FFE82A4D180
        public void FindClosestFrame(){} // RVA: 0x7FFE82A4D3C0
        public void PointUpdate(){} // RVA: 0x7FFE82A4D5A0
        public void SampleFrame(){} // RVA: 0x7FFE82A4D8D0
        public void SampleFrames(){} // RVA: 0x7FFE82A4DAA0
        public void LinearUpdate(){} // RVA: 0x7FFE82A4DE70
        public void InvalidateBuffer(){} // RVA: 0x7FFE82A4E090
        public void GuessFrameRate(){} // RVA: 0x7FFE82A4E190
        public void Update(){} // RVA: 0x7FFE82A4E450
        public void UpdateTimestamp(){} // RVA: 0x7FFE82A4F170
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0x20
        public RenderHeads.Media.AVProVideo.VideoResolveOptions _options; // 0x28
        public 0x66670264 _resolveFlags; // 0x58
        public UnityEngine.RenderTexture _externalTexture; // 0x60

        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0x7FFE811290C0
        public void set_MediaPlayer(){} // RVA: 0x7FFE82A30E30
        public void get_VideoResolveOptions(){} // RVA: 0x7FFE82A30E40
        public void set_VideoResolveOptions(){} // RVA: 0x7FFE82A30E60
        public void get_ExternalTexture(){} // RVA: 0x7FFE81199370
        public void set_ExternalTexture(){} // RVA: 0x7FFE81199380
        public void get_TargetTexture(){} // RVA: 0x7FFE82A30E80
        public void SetMaterialDirty(){} // RVA: 0x7FFE812ACC00
        public void ChangeMediaPlayer(){} // RVA: 0x7FFE82A30F60
        public void Start(){} // RVA: 0x7FFE82A31100
        public void LateUpdate(){} // RVA: 0x7FFE82A313F0
        public void Resolve(){} // RVA: 0x7FFE82A31400
        public void OnDisable(){} // RVA: 0x7FFE82A31BF0
        public void OnDestroy(){} // RVA: 0x7FFE82A31D60
        public void .ctor(){} // RVA: 0x7FFE82A31EA0
    }

    public class Subtitle : Object
    {
        // ── Methods ──
        public void IsBefore(){} // RVA: 0x7FFE82A4F190
        public void IsTime(){} // RVA: 0x7FFE82A4F1B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubtitlePlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubtitleUtils : Object
    {
        // ── Methods ──
        public void ParseTimeToSeconds(){} // RVA: 0x7FFE82A4F1D0
        public void ParseSubtitlesSRT(){} // RVA: 0x7FFE82A4F380
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubtitlesUGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0x20
        public UnityEngine.UI.Text _text; // 0x28

        // ── Methods ──
        public void set_Player(){} // RVA: 0x7FFE82A1BF80
        public void get_Player(){} // RVA: 0x7FFE811290C0
        public void set_Text(){} // RVA: 0x7FFE810FCE90
        public void get_Text(){} // RVA: 0x7FFE81129130
        public void Start(){} // RVA: 0x7FFE82A1BF90
        public void OnDestroy(){} // RVA: 0x7FFE82A1BFA0
        public void Update(){} // RVA: 0x7FFE82A1BFB0
        public void ChangeMediaPlayer(){} // RVA: 0x7FFE82A1BFC0
        public void SetText(){} // RVA: 0x7FFE82A1C300
        public void PrepareText(){} // RVA: 0x7FFE82A1C340
        public void UpdateBackgroundRect(){} // RVA: 0x7FFE82A1C4B0
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFE82A1C760
        public void .ctor(){} // RVA: 0x7FFE82A1C9B0
    }

    public class TextCue : Object
    {
        public string _text; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Text(){} // RVA: 0x7FFE81116380
        public void set_Text(){} // RVA: 0x7FFE810FCE30
    }

    public class TextTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4B080 | overloaded x2
    }

    public class TextTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFE81200CB0
        public void .ctor(){} // RVA: 0x7FFE82A4AFD0
    }

    public class TextureFrame : ValueType
    {
    }

    public class TimeRange : ValueType
    {
        public double startTime; // 0x10
        public double duration; // 0x18
        public object field_2; // 0x9E50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A39E50
        public void get_StartTime(){} // RVA: 0x7FFE82A39E60
        public void get_EndTime(){} // RVA: 0x7FFE82A39E70
        public void get_Duration(){} // RVA: 0x7FFE82A39E80
    }

    public class TimeRanges : Object
    {
        public RenderHeads.Media.AVProVideo.TimeRange[] _ranges; // 0x10
        public double _minTime; // 0x18
        public double _maxTime; // 0x20
        public object field_3; // 0x87
        public object field_4; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A3A1F0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE82A39F20
        public void get_Item(){} // RVA: 0x7FFE82A39F40
        public void ToString(){} // RVA: 0x7FFE82A39F80
        public void CalculateRange(){} // RVA: 0x7FFE82A3A2F0
        public void get_Count(){} // RVA: 0x7FFE81CCB610
        public void get_MinTime(){} // RVA: 0x7FFE826F6CB0
        public void get_MaxTime(){} // RVA: 0x7FFE827BB220
        public void get_Duration(){} // RVA: 0x7FFE82A3A470
    }

    public class TrackBase : Object
    {
        public int _uid; // 0x10
        public 0x6666FA7C _trackType; // 0x14
        public string _displayName; // 0x18
        public string _name; // 0x20
        public string _language; // 0x28
        public bool _isDefault; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4AB70 | overloaded x2
        public void get_Uid(){} // RVA: 0x7FFE811485C0
        public void set_Uid(){} // RVA: 0x7FFE810FE0C0
        public void get_TrackType(){} // RVA: 0x7FFE8164B230
        public void set_TrackType(){} // RVA: 0x7FFE8164E0F0
        public void get_DisplayName(){} // RVA: 0x7FFE810FE7C0
        public void set_DisplayName(){} // RVA: 0x7FFE81161E80
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void set_Name(){} // RVA: 0x7FFE811290D0
        public void get_Language(){} // RVA: 0x7FFE81129130
        public void set_Language(){} // RVA: 0x7FFE810FCE90
        public void get_IsDefault(){} // RVA: 0x7FFE81121450
        public void set_IsDefault(){} // RVA: 0x7FFE81121460
        public void CreateDisplayName(){} // RVA: 0x7FFE82A4ADF0
    }

    public class TrackCollection : Object
    {
        public 0x6666FA7C _trackType; // 0x10
        public object field_1; // 0xA0

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFE811485C0
        public void set_TrackType(){} // RVA: 0x7FFE810FE0C0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void HasActiveTrack(){} // RVA: 0x7FFE80E2F150
        public void IsActiveTrack(){} // RVA: 0x7FFE80E2F3B0
        public void SetActiveTrack(){} // RVA: 0x7FFE80E460A0
        public void SetFirstTrackActive(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TrackCollection`1 : TrackCollection
    {
        public T _activeTrack;
        public System.Collections.Generic.List`1<T> _tracks;
        public object field_2; // 0xA2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_ActiveTrack(){} // RVA: 0x7FFE810A1420
        public void set_ActiveTrack(){} // RVA: 0x7FFE810A1420
        public void HasActiveTrack(){} // RVA: 0x7FFE80E2F150
        public void IsActiveTrack(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void SetActiveTrack(){} // RVA: 0x7FFE80E460A0
        public void SetFirstTrackActive(){} // RVA: 0x7FFE80E45FE0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        public UnityEngine.Camera _camera; // 0x20

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFE811290C0
        public void set_Camera(){} // RVA: 0x7FFE811290D0
        public void Awake(){} // RVA: 0x7FFE82A31F70
        public void Start(){} // RVA: 0x7FFE82A32080
        public void LogXRDeviceDetails(){} // RVA: 0x7FFE82A32090
        public void IsMultiPassVrEnabled(){} // RVA: 0x7FFE82A32610
        public void LateUpdate(){} // RVA: 0x7FFE82A326B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void .cctor(){} // RVA: 0x7FFE82A32FE0
    }

    public class VideoRender : Object
    {
        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x7FFE82A4F970
        public void CreateIMGUIMaterial(){} // RVA: 0x7FFE82A4FA10
        public void SetupLayoutMaterial(){} // RVA: 0x7FFE82A4FA90
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x7FFE82A4FC10
        public void SetupStereoMaterial(){} // RVA: 0x7FFE82A4FD60
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x7FFE82A50020
        public void SetupAlphaPackedMaterial(){} // RVA: 0x7FFE82A500F0
        public void SetupGammaMaterial(){} // RVA: 0x7FFE82A50240
        public void SetupTextureMatrix(){} // RVA: 0x7FFE810FB310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x7FFE82A50340
        public void GetTexture(){} // RVA: 0x7FFE82A50480
        public void SetupMaterialForMedia(){} // RVA: 0x7FFE82A50630
        public void SetupMaterial(){} // RVA: 0x7FFE82A50C80
        public void SetupResolveMaterial(){} // RVA: 0x7FFE82A51490
        public void ResolveVideoToRenderTexture(){} // RVA: 0x7FFE82A51920
        public void GetResolveTextureSize(){} // RVA: 0x7FFE82A52250
        public void RequiresResolve(){} // RVA: 0x7FFE82A52300
        public void DrawTexture(){} // RVA: 0x7FFE82A523B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82A52B90
    }

    public class VideoResolveOptions : ValueType
    {
        // ── Methods ──
        public void IsColourAdjust(){} // RVA: 0x7FFE82A39D50
        public void ResetColourAdjust(){} // RVA: 0x7FFE82A39DB0
        public void Create(){} // RVA: 0x7FFE82A39DE0
    }

    public class VideoTrack : TrackBase
    {
        public int _bitrate; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A4B010 | overloaded x2
        public void get_Bitrate(){} // RVA: 0x7FFE81D46090
        public void set_Bitrate(){} // RVA: 0x7FFE81D46A00
    }

    public class VideoTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE82A4AF50
    }

    public class WebGL : Object
    {
    }

    public class Windows : Object
    {
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x7FFE82A3B990
        public void DeinitPlatform(){} // RVA: 0x7FFE82A3BE60
        public void GetAudioChannelCount(){} // RVA: 0x7FFE82A3BF10
        public void GetAudioChannelMask(){} // RVA: 0x7FFE82A3BF90
        public void .ctor(){} // RVA: 0x7FFE82A3C280 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFE82A3C4E0
        public void GetVersion(){} // RVA: 0x7FFE82A3C820
        public void GetExpectedVersion(){} // RVA: 0x7FFE82A3C880
        public void UseNativeMips(){} // RVA: 0x7FFE82A3C8C0
        public void OpenMedia(){} // RVA: 0x7FFE82A3C8D0
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFE82A3D0A0
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFE82A3D570
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFE82A3D640
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFE82A3D700
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x7FFE82A3DB50
        public void CloseMedia(){} // RVA: 0x7FFE82A3DD20
        public void SetLooping(){} // RVA: 0x7FFE82A3DEC0
        public void IsLooping(){} // RVA: 0x7FFE81226F80
        public void HasMetaData(){} // RVA: 0x7FFE82A3DF50
        public void HasAudio(){} // RVA: 0x7FFE8117CAD0
        public void HasVideo(){} // RVA: 0x7FFE82145E40
        public void CanPlay(){} // RVA: 0x7FFE82A3DF60
        public void Play(){} // RVA: 0x7FFE82A3DF70
        public void Pause(){} // RVA: 0x7FFE82A3E000
        public void Stop(){} // RVA: 0x7FFE82A3E000
        public void IsSeeking(){} // RVA: 0x7FFE82A3E020
        public void IsPlaying(){} // RVA: 0x7FFE82A3E0B0
        public void IsPaused(){} // RVA: 0x7FFE82A3E130
        public void IsFinished(){} // RVA: 0x7FFE82A3E170
        public void IsBuffering(){} // RVA: 0x7FFE82A3E260
        public void GetDuration(){} // RVA: 0x7FFE82A3E2F0
        public void GetVideoWidth(){} // RVA: 0x7FFE82A3E370
        public void GetVideoHeight(){} // RVA: 0x7FFE82A3E380
        public void GetVideoFrameRate(){} // RVA: 0x7FFE82A3E390
        public void GetTexture(){} // RVA: 0x7FFE82A3E3A0
        public void GetTextureFrameCount(){} // RVA: 0x7FFE82A3E4B0
        public void GetTextureTimeStamp(){} // RVA: 0x7FFE82A3E4C0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFE82A3E540
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE82144680
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFE82A3E5F0
        public void Seek(){} // RVA: 0x7FFE82A3E670
        public void SeekFast(){} // RVA: 0x7FFE82A3E730
        public void GetCurrentTime(){} // RVA: 0x7FFE82A3E7F0
        public void SetPlaybackRate(){} // RVA: 0x7FFE82A3E870
        public void GetPlaybackRate(){} // RVA: 0x7FFE82A3E900
        public void MuteAudio(){} // RVA: 0x7FFE82A3E980
        public void IsMuted(){} // RVA: 0x7FFE82A234D0
        public void SetVolume(){} // RVA: 0x7FFE82A3EA10
        public void GetVolume(){} // RVA: 0x7FFE82A3EAB0
        public void SetBalance(){} // RVA: 0x7FFE82A3EAC0
        public void GetBalance(){} // RVA: 0x7FFE81643620
        public void IsPlaybackStalled(){} // RVA: 0x7FFE82A3EB60
        public void WaitForNextFrame(){} // RVA: 0x7FFE82A3EC10
        public void SetAudioChannelMode(){} // RVA: 0x7FFE82A3EE20
        public void SetAudioHeadRotation(){} // RVA: 0x7FFE82A3EEB0
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFE82A3EEF0
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFE82A3F010
        public void SetAudioFocusProperties(){} // RVA: 0x7FFE82A3F020
        public void SetAudioFocusRotation(){} // RVA: 0x7FFE82A3F030
        public void ResetAudioFocus(){} // RVA: 0x7FFE82A3F070
        public void Update(){} // RVA: 0x7FFE82A3F0E0
        public void ReleaseTexture(){} // RVA: 0x7FFE82A3F920
        public void UpdateTexture(){} // RVA: 0x7FFE82A3FBC0
        public void EndUpdate(){} // RVA: 0x7FFE82A40360
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFE82A403E0
        public void OnTextureSizeChanged(){} // RVA: 0x7FFE810FB310
        public void BeginRender(){} // RVA: 0x7FFE82A40460
        public void Render(){} // RVA: 0x7FFE82A404B0
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void GrabAudio(){} // RVA: 0x7FFE82A40510
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFE82A405D0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFE82A40650
        public void GetDecoderPerformance(){} // RVA: 0x7FFE82A40660
        public void IssueRenderThreadEvent(){} // RVA: 0x7FFE82A40710
        public void GetPluginVersion(){} // RVA: 0x7FFE82A40830
        public void InternalSetActiveTrack(){} // RVA: 0x7FFE82A40900
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFE82A409B0
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFE82A40A40
        public void InternalIsChangedTracks(){} // RVA: 0x7FFE82A40B10
        public void InternalGetTrackCount(){} // RVA: 0x7FFE82A40BB0
        public void InternalGetTrackInfo(){} // RVA: 0x7FFE82A40C50
        public void UpdateTimeRanges(){} // RVA: 0x7FFE82A410A0
        public void UpdateTimeRange(){} // RVA: 0x7FFE82A41110
        public void FlushFrameBuffering(){} // RVA: 0x7FFE82A41220
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFE82A41370
        public void LogBufferState(){} // RVA: 0x7FFE82A41B60
        public void SetBufferedDisplayTime(){} // RVA: 0x7FFE82A41F30
        public void GetBufferedFramesState(){} // RVA: 0x7FFE82A41FF0
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFE82A42090
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFE82A421B0
        public void SetSlaves(){} // RVA: 0x7FFE82A421E0
        public void IsPrerollComplete(){} // RVA: 0x7FFE82A42350
        public void .cctor(){} // RVA: 0x7FFE82A424E0
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        public bool _isMediaLoaded; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A45C80 | overloaded x2
        public void CanPlay(){} // RVA: 0x7FFE82A45F60
        public void Dispose(){} // RVA: 0x7FFE82A45F80
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFE810FB320
        public void GetCurrentTime(){} // RVA: 0x7FFE82A46100
        public void GetDuration(){} // RVA: 0x7FFE82A46180
        public void GetPlaybackRate(){} // RVA: 0x7FFE82A46190
        public void GetTexture(){} // RVA: 0x7FFE82A46210
        public void GetTextureCount(){} // RVA: 0x7FFE82A46260
        public void GetTextureFrameCount(){} // RVA: 0x7FFE8260FFA0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFE82A46370
        public void GetVersion(){} // RVA: 0x7FFE82A463F0
        public void GetExpectedVersion(){} // RVA: 0x7FFE82A46450
        public void GetVideoFrameRate(){} // RVA: 0x7FFE82A46490
        public void GetVideoWidth(){} // RVA: 0x7FFE82A46540
        public void GetVideoHeight(){} // RVA: 0x7FFE82A46680
        public void GetVolume(){} // RVA: 0x7FFE82A467C0
        public void SetBalance(){} // RVA: 0x7FFE82A46840
        public void GetBalance(){} // RVA: 0x7FFE82A468D0
        public void HasAudio(){} // RVA: 0x7FFE82A46950
        public void HasMetaData(){} // RVA: 0x7FFE82A46990
        public void HasVideo(){} // RVA: 0x7FFE82A469C0
        public void IsBuffering(){} // RVA: 0x7FFE82A46A00
        public void IsFinished(){} // RVA: 0x7FFE82A46A20
        public void IsLooping(){} // RVA: 0x7FFE82A46AD0
        public void IsMuted(){} // RVA: 0x7FFE82A46B60
        public void IsPaused(){} // RVA: 0x7FFE82A46BF0
        public void IsPlaying(){} // RVA: 0x7FFE82A46C10
        public void IsSeeking(){} // RVA: 0x7FFE82A46C30
        public void MuteAudio(){} // RVA: 0x7FFE82A46C50
        public void OpenMedia(){} // RVA: 0x7FFE82A46CE0
        public void CloseMedia(){} // RVA: 0x7FFE82A46EF0
        public void Pause(){} // RVA: 0x7FFE82A46F90
        public void Play(){} // RVA: 0x7FFE82A47010
        public void Render(){} // RVA: 0x7FFE82A47090
        public void Update_Textures(){} // RVA: 0x7FFE82A47110
        public void get_AuthenticationData(){} // RVA: 0x7FFE81166040
        public void set_AuthenticationData(){} // RVA: 0x7FFE82A47620
        public void RequiresVerticalFlip(){} // RVA: 0x7FFE811E0850
        public void Seek(){} // RVA: 0x7FFE82A47690
        public void SeekFast(){} // RVA: 0x7FFE82A34AA0
        public void SetLooping(){} // RVA: 0x7FFE82A47720
        public void SetPlaybackRate(){} // RVA: 0x7FFE82A477B0
        public void SetVolume(){} // RVA: 0x7FFE82A47840
        public void Stop(){} // RVA: 0x7FFE82A478D0
        public void UpdateTimeRanges(){} // RVA: 0x7FFE82A478F0
        public void UpdateTimeRange(){} // RVA: 0x7FFE82A47960
        public void GetProgramDateTime(){} // RVA: 0x7FFE82A47A70
        public void Update(){} // RVA: 0x7FFE82A47C70
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFE82A48150
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFE82A481D0
        public void InternalSetActiveTrack(){} // RVA: 0x7FFE82A48250
        public void InternalIsChangedTracks(){} // RVA: 0x7FFE82A482F0
        public void InternalGetTrackCount(){} // RVA: 0x7FFE82A48380
        public void InternalGetTrackInfo(){} // RVA: 0x7FFE82A48410
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFE82A487F0
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFE82A48880
        public void InitialisePlatform(){} // RVA: 0x7FFE82A48950
        public void DeinitPlatform(){} // RVA: 0x7FFE82A48CD0
        public void .cctor(){} // RVA: 0x7FFE82A48D30
    }

    public class WindowsUWP : Object
    {
    }

}