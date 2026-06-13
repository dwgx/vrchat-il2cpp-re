// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 69
// Methods: 1148

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class Android
    {
    }

    public class ApplyToBase
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _media; // 0x20
        public bool _automaticStereoPacking; // 0x28
        public 0x65997DD8 _overrideStereoPacking; // 0x2C
        public bool _stereoRedGreenTint; // 0x30

        // ── Methods ──
        public void get_Player(){} // RVA: 0x30B0C0
        public void set_Player(){} // RVA: 0x1CA1730
        public void get_AutomaticStereoPacking(){} // RVA: 0x6E8A80
        public void set_AutomaticStereoPacking(){} // RVA: 0x1CA1740
        public void get_OverrideStereoPacking(){} // RVA: 0x1209F00
        public void set_OverrideStereoPacking(){} // RVA: 0x1CA1750
        public void get_StereoRedGreenTint(){} // RVA: 0x303450
        public void set_StereoRedGreenTint(){} // RVA: 0x1CA1760
        public void Awake(){} // RVA: 0x1CA1770
        public void ChangeMediaPlayer(){} // RVA: 0x1CA1780
        public void OnMediaPlayerEvent(){} // RVA: 0x1CA1AF0
        public void ForceUpdate(){} // RVA: 0x1CA1B10
        public void Start(){} // RVA: 0x1CA1B90
        public void OnEnable(){} // RVA: 0x1CA1BD0
        public void OnDisable(){} // RVA: 0x1CA1C00
        public void OnDestroy(){} // RVA: 0x1CA1C20
        public void SaveProperties(){} // RVA: 0x2DD310
        public void RestoreProperties(){} // RVA: 0x2DD310
        public void Apply(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x314BB0
    }

    public class ApplyToMaterial
    {
        public UnityEngine.Texture2D _defaultTexture; // 0x38
        public UnityEngine.Material _material; // 0x40
        public string _texturePropertyName; // 0x48
        public UnityEngine.Vector2 _offset; // 0x50
        public UnityEngine.Vector2 _scale; // 0x58

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x4976A0
        public void set_DefaultTexture(){} // RVA: 0x1C8B4E0
        public void get_Material(){} // RVA: 0x35A740
        public void set_Material(){} // RVA: 0x1C8B650
        public void get_TexturePropertyName(){} // RVA: 0x358730
        public void set_TexturePropertyName(){} // RVA: 0x1C8B7C0
        public void get_Offset(){} // RVA: 0x1C8B940
        public void set_Offset(){} // RVA: 0x1C8B960
        public void get_Scale(){} // RVA: 0x1C8B9B0
        public void set_Scale(){} // RVA: 0x1C8B9D0
        public void LateUpdate(){} // RVA: 0x950560
        public void Apply(){} // RVA: 0x1C8BA20
        public void ApplyMapping(){} // RVA: 0x1C8BFB0
        public void SaveProperties(){} // RVA: 0x1C8C6A0
        public void RestoreProperties(){} // RVA: 0x1C8C9F0
        public void .ctor(){} // RVA: 0x1C8CBD0
    }

    public class ApplyToMesh
    {
        public UnityEngine.Texture2D _defaultTexture; // 0x38
        public UnityEngine.Renderer _renderer; // 0x40
        public int _materialIndex; // 0x48
        public string _texturePropertyName; // 0x50
        public UnityEngine.Vector2 _offset; // 0x58
        public UnityEngine.Vector2 _scale; // 0x60

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x4976A0
        public void set_DefaultTexture(){} // RVA: 0x1C8CDB0
        public void get_MeshRenderer(){} // RVA: 0x35A740
        public void set_MeshRenderer(){} // RVA: 0x1C8CF30
        public void get_MaterialIndex(){} // RVA: 0x37E0C0
        public void set_MaterialIndex(){} // RVA: 0x37E0D0
        public void ChangeDefaultTexture(){} // RVA: 0x1C8CDB0
        public void ChangeRenderer(){} // RVA: 0x1C8CF40
        public void get_TexturePropertyName(){} // RVA: 0x37E0E0
        public void set_TexturePropertyName(){} // RVA: 0x1C8D1D0
        public void get_Offset(){} // RVA: 0x1C8B9B0
        public void set_Offset(){} // RVA: 0x1C8B9D0
        public void get_Scale(){} // RVA: 0x1C8D350
        public void set_Scale(){} // RVA: 0x1C8D370
        public void LateUpdate(){} // RVA: 0x950560
        public void Apply(){} // RVA: 0x1C8D3C0
        public void ApplyMapping(){} // RVA: 0x1C8D960
        public void OnEnable(){} // RVA: 0x1C8E0B0
        public void OnDisable(){} // RVA: 0x1C8E3B0
        public void .ctor(){} // RVA: 0x1C8E3E0
    }

    public class AudioChannelMixer
    {
        public int _channel;

        // ── Methods ──
        public void get_Channel(){} // RVA: 0x30B0C0
        public void set_Channel(){} // RVA: 0x30B0D0
        public void Reset(){} // RVA: 0x1C8E530
        public void ChangeChannelCount(){} // RVA: 0x1C8E5F0
        public void OnAudioFilterRead(){} // RVA: 0x1C8E740
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class AudioOutput
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _player; // 0x20
        public 0x65996888 _audioOutputMode; // 0x28
        public int _channelMask; // 0x2C

        // ── Methods ──
        public void get_Player(){} // RVA: 0x30B0C0
        public void set_Player(){} // RVA: 0x1C8E930
        public void get_OutputMode(){} // RVA: 0x791DC0
        public void set_OutputMode(){} // RVA: 0xA53440
        public void get_ChannelMask(){} // RVA: 0x1209F00
        public void set_ChannelMask(){} // RVA: 0x1AFCF60
        public void Awake(){} // RVA: 0x1C8E940
        public void Start(){} // RVA: 0x1C8E9D0
        public void OnAudioConfigurationChanged(){} // RVA: 0x1C8EA60
        public void OnDestroy(){} // RVA: 0x1C8EBB0
        public void Update(){} // RVA: 0x1C8EBC0
        public void GetAudioSource(){} // RVA: 0x4976A0
        public void ChangeMediaPlayer(){} // RVA: 0x1C8ED00
        public void OnMediaPlayerEvent(){} // RVA: 0x1C8F410
        public void ApplyAudioSettings(){} // RVA: 0x2DD310
        public void OnAudioFilterRead(){} // RVA: 0x1C8F4D0
        public void .ctor(){} // RVA: 0x1C8F6A0
    }

    public class AudioOutputManager
    {
        public RenderHeads.Media.AVProVideo.AudioOutputManager center;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x1CA1C30
        public void .ctor(){} // RVA: 0x1CA1DB0
        public void RequestAudio(){} // RVA: 0x1CA1E70
        public void ZeroAudio(){} // RVA: 0x1CA2800
        public void GrabAudio(){} // RVA: 0x1CA2840
    }

    public class AudioTrack
    {
        public int <Bitrate>k__BackingField; // 0x38
        public int <ChannelCount>k__BackingField; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CB95C0 | overloaded x2
        public void get_Bitrate(){} // RVA: 0xFDC9F0
        public void set_Bitrate(){} // RVA: 0xFDD6E0
        public void get_ChannelCount(){} // RVA: 0x891AF0
        public void set_ChannelCount(){} // RVA: 0x1CB95F0
    }

    public class AudioTracks
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x3CFAF0
        public void .ctor(){} // RVA: 0x1CB9510
    }

    public class AuthData
    {
        public string <URL>k__BackingField; // 0x10
        public string <Token>k__BackingField; // 0x18
        public byte[] <KeyBytes>k__BackingField; // 0x20

        // ── Methods ──
        public void get_URL(){} // RVA: 0x2F8380
        public void set_URL(){} // RVA: 0x2DEE30
        public void get_Token(){} // RVA: 0x2E07C0
        public void set_Token(){} // RVA: 0x343E80
        public void get_KeyBytes(){} // RVA: 0x30B0C0
        public void set_KeyBytes(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x1CB3B60
        public void Clear(){} // RVA: 0x1CB3B60
        public void get_KeyBase64(){} // RVA: 0x1CB3CB0
        public void set_KeyBase64(){} // RVA: 0x1CB3DB0
    }

    public class BaseMediaPlayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CA2960
        public void GetVersion(){} // RVA: 0xCD60
        public void GetExpectedVersion(){} // RVA: 0xCD60
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x2DD320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x2DD320
        public void AddChunkToMediaBuffer(){} // RVA: 0x2DD320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x2DD320
        public void CloseMedia(){} // RVA: 0x1CA2EF0
        public void SetLooping(){} // RVA: 0x25130
        public void IsLooping(){} // RVA: 0xDBE0
        public void HasMetaData(){} // RVA: 0xDBE0
        public void CanPlay(){} // RVA: 0xDBE0
        public void Play(){} // RVA: 0x24A50
        public void Pause(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void Rewind(){} // RVA: 0x1CA2FE0
        public void Seek(){} // RVA: 0x26100
        public void SeekFast(){} // RVA: 0x26100
        public void SeekWithTolerance(){} // RVA: 0x1CA3000
        public void GetCurrentTime(){} // RVA: 0x12A40
        public void GetProgramDateTime(){} // RVA: 0x1CA3020
        public void GetPlaybackRate(){} // RVA: 0x21890
        public void SetPlaybackRate(){} // RVA: 0x325B0
        public void GetDuration(){} // RVA: 0x12A40
        public void GetVideoWidth(){} // RVA: 0xD840
        public void GetVideoHeight(){} // RVA: 0xD840
        public void GetVideoFrameRate(){} // RVA: 0x21890
        public void GetVideoDisplayRate(){} // RVA: 0x345460
        public void HasAudio(){} // RVA: 0xDBE0
        public void HasVideo(){} // RVA: 0xDBE0
        public void IsVideoStereo(){} // RVA: 0x1CA3080
        public void IsSeeking(){} // RVA: 0xDBE0
        public void IsPlaying(){} // RVA: 0xDBE0
        public void IsPaused(){} // RVA: 0xDBE0
        public void IsFinished(){} // RVA: 0xDBE0
        public void IsBuffering(){} // RVA: 0xDBE0
        public void WaitForNextFrame(){} // RVA: 0x2DD320
        public void GetTextureCount(){} // RVA: 0x3CFAF0
        public void GetTexture(){} // RVA: 0x1BCC0
        public void GetTextureFrameCount(){} // RVA: 0xD840
        public void SupportsTextureFrameCount(){} // RVA: 0x3C2850
        public void GetTextureTimeStamp(){} // RVA: 0x1CA30B0
        public void RequiresVerticalFlip(){} // RVA: 0xDBE0
        public void GetTextureTransform(){} // RVA: 0x1CA30C0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x1529D00
        public void GetYpCbCrTransform(){} // RVA: 0x1CA3130
        public void GetTextureStereoPacking(){} // RVA: 0x1CA3190
        public void InternalGetTextureStereoPacking(){} // RVA: 0xD840
        public void GetTextureTransparency(){} // RVA: 0x791DC0
        public void GetTextureAlphaPacking(){} // RVA: 0x1CA31C0
        public void MuteAudio(){} // RVA: 0x25130
        public void IsMuted(){} // RVA: 0xDBE0
        public void SetVolume(){} // RVA: 0x325B0
        public void SetBalance(){} // RVA: 0x2DD310
        public void GetVolume(){} // RVA: 0x21890
        public void GetBalance(){} // RVA: 0xAFF380
        public void GetAudioChannelCount(){} // RVA: 0x75BB20
        public void GetAudioChannelMask(){} // RVA: 0x519240
        public void GrabAudio(){} // RVA: 0x519240
        public void GetAudioBufferedSampleCount(){} // RVA: 0x519240
        public void AudioConfigurationChanged(){} // RVA: 0x2DD310
        public void SetAudioHeadRotation(){} // RVA: 0x2DD310
        public void ResetAudioHeadRotation(){} // RVA: 0x2DD310
        public void SetAudioChannelMode(){} // RVA: 0x2DD310
        public void SetAudioFocusEnabled(){} // RVA: 0x2DD310
        public void SetAudioFocusProperties(){} // RVA: 0x2DD310
        public void SetAudioFocusRotation(){} // RVA: 0x2DD310
        public void ResetAudioFocus(){} // RVA: 0x2DD310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x1CA3200
        public void SetPlayWithoutBuffering(){} // RVA: 0x2DD310
        public void IsMediaCachingSupported(){} // RVA: 0x2DD320
        public void AddMediaToCache(){} // RVA: 0x2DD310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x2DD310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x2DD310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x2DD310
        public void RemoveMediaFromCache(){} // RVA: 0x2DD310
        public void GetCachedMediaStatus(){} // RVA: 0x519240
        public void IsExternalPlaybackSupported(){} // RVA: 0x2DD320
        public void IsExternalPlaybackActive(){} // RVA: 0x2DD320
        public void SetAllowsExternalPlayback(){} // RVA: 0x2DD310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x2DD310
        public void SetKeyServerAuthToken(){} // RVA: 0x2DD310
        public void SetOverrideDecryptionKey(){} // RVA: 0x2DD310
        public void Update(){} // RVA: 0x24A50
        public void BeginRender(){} // RVA: 0x2DD310
        public void Render(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void GetDecoderPerformance(){} // RVA: 0x2DD320
        public void EndUpdate(){} // RVA: 0x2DD310
        public void GetNativePlayerHandle(){} // RVA: 0x519240
        public void GetLastError(){} // RVA: 0x1CA3210
        public void GetLastExtendedErrorCode(){} // RVA: 0x519240
        public void GetPlayerDescription(){} // RVA: 0x2F8380
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x3C2850
        public void GetSeekableTimes(){} // RVA: 0x4976A0
        public void GetBufferedTimes(){} // RVA: 0x35A740
        public void GetTextureProperties(){} // RVA: 0x1CA3220
        public void SetTextureProperties(){} // RVA: 0x1CA3240
        public void ApplyTextureProperties(){} // RVA: 0x1CA32D0
        public void UpdateDisplayFrameRate(){} // RVA: 0x1CA3480
        public void IsExpectingNewVideoFrame(){} // RVA: 0x1CA3550
        public void IsPlaybackStalled(){} // RVA: 0x1CA3650
        public void LoadSubtitlesSRT(){} // RVA: 0x1CA3880
        public void UpdateSubtitles(){} // RVA: 0x1CA3A40
        public void GetSubtitleIndex(){} // RVA: 0x1CA3BA0
        public void GetSubtitleText(){} // RVA: 0x1CA3BC0
        public void OnEnable(){} // RVA: 0x2DD310
        public void GetCurrentTimeFrames(){} // RVA: 0x1CA3C40
        public void GetDurationFrames(){} // RVA: 0x1CA3D30
        public void GetMaxFrameNumber(){} // RVA: 0x1CA3DF0
        public void SeekToFrameRelative(){} // RVA: 0x1CA3E10
        public void SeekToFrame(){} // RVA: 0x1CA3F60
        public void UpdateBufferedDisplay(){} // RVA: 0x1CA4070
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x519240
        public void GetBufferedFramesState(){} // RVA: 0x1CA4140
        public void SetSlaves(){} // RVA: 0x2DD310
        public void SetBufferedDisplayMode(){} // RVA: 0x2DD310
        public void SetBufferedDisplayOptions(){} // RVA: 0x2DD310
        public void GetPlaybackQualityStats(){} // RVA: 0x4C7C50
        public void GetCurrentTextCue(){} // RVA: 0x462D00
        public void UpdateTextCue(){} // RVA: 0x1CA4160
        public void InternalIsChangedTextCue(){} // RVA: 0xDBE0
        public void InternalGetCurrentTextCue(){} // RVA: 0xCD60
        public void GetVideoTracks(){} // RVA: 0x31C010
        public void GetAudioTracks(){} // RVA: 0x796DE0
        public void GetTextTracks(){} // RVA: 0xA1C8C0
        public void GetActiveVideoTrack(){} // RVA: 0x1CA4320
        public void GetActiveAudioTrack(){} // RVA: 0x1CA4370
        public void GetActiveTextTrack(){} // RVA: 0x1CA43C0
        public void SetActiveVideoTrack(){} // RVA: 0x1CA4410
        public void SetActiveAudioTrack(){} // RVA: 0x1CA4430
        public void SetActiveTextTrack(){} // RVA: 0x1CA4450
        public void InternalIsChangedTracks(){} // RVA: 0xE1F0
        public void InternalGetTrackCount(){} // RVA: 0x13FB0
        public void InternalSetActiveTrack(){}
        public void InternalGetTrackInfo(){}
        public void InitTracks(){} // RVA: 0x1CA4470
        public void UpdateTracks(){} // RVA: 0x1CA4600
        public void PopulateTrackCollection(){} // RVA: 0x1CA46B0
        public void SetActiveTrack(){} // RVA: 0x1CA48A0
    }

    public class BufferedFramesState
    {
    }

    public class DisplayIMGUI
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _player; // 0x20
        public 0x659A1200 _scaleMode; // 0x28
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
        public void get_Player(){} // RVA: 0x30B0C0
        public void set_Player(){} // RVA: 0x1C8F700
        public void get_ScaleMode(){} // RVA: 0x791DC0
        public void set_ScaleMode(){} // RVA: 0xA53440
        public void get_Color(){} // RVA: 0x1C8F830
        public void set_Color(){} // RVA: 0x1C8F840
        public void get_AllowTransparency(){} // RVA: 0x4424E0
        public void set_AllowTransparency(){} // RVA: 0x4424F0
        public void get_UseDepth(){} // RVA: 0x14C5920
        public void set_UseDepth(){} // RVA: 0x1C8F850
        public void get_Depth(){} // RVA: 0x37E080
        public void set_Depth(){} // RVA: 0x37E090
        public void get_IsAreaFullScreen(){} // RVA: 0x1AF8C70
        public void set_IsAreaFullScreen(){} // RVA: 0x1AF8C60
        public void get_AreaX(){} // RVA: 0xEBB900
        public void set_AreaX(){} // RVA: 0xEBB7C0
        public void get_AreaY(){} // RVA: 0xD0E450
        public void set_AreaY(){} // RVA: 0xEBB7B0
        public void get_AreaWidth(){} // RVA: 0x345460
        public void set_AreaWidth(){} // RVA: 0x345470
        public void get_AreaHeight(){} // RVA: 0x862910
        public void set_AreaHeight(){} // RVA: 0x863060
        public void get_ShowAreaInEditor(){} // RVA: 0x59FF30
        public void set_ShowAreaInEditor(){} // RVA: 0xC5F680
        public void Start(){} // RVA: 0x1C8F860
        public void Update(){} // RVA: 0x1C8FB00
        public void OnDestroy(){} // RVA: 0x1C8FBE0
        public void GetRequiredShader(){} // RVA: 0x1C8FD20
        public void SetupMaterial(){} // RVA: 0x1C900D0
        public void OnGUI(){} // RVA: 0x1C90520
        public void GetAreaRect(){} // RVA: 0x1C90CD0
        public void .ctor(){} // RVA: 0x1C90F50
    }

    public class DisplayUGUI
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _mediaPlayer; // 0xE0
        public UnityEngine.Texture _defaultTexture; // 0xE8
        public UnityEngine.Rect _uvRect; // 0xF0
        public bool _setNativeSize; // 0x100
        public 0x659A1200 _scaleMode; // 0x104
        public bool _noDefaultDisplay; // 0x108
        public bool _displayInEditor; // 0x109
        public int _lastWidth; // 0x10C
        public int _lastHeight; // 0x110
        public 0x65998098 _lastOrientation; // 0x114

        // ── Methods ──
        public void get_Player(){} // RVA: 0x35E900
        public void set_Player(){} // RVA: 0x1C86850
        public void get_DefaultTexture(){} // RVA: 0x35E970
        public void set_DefaultTexture(){} // RVA: 0x1C86860
        public void get_UVRect(){} // RVA: 0x1C869E0
        public void set_UVRect(){} // RVA: 0x1C869F0
        public void get_ApplyNativeSize(){} // RVA: 0x12108C0
        public void set_ApplyNativeSize(){} // RVA: 0x120E9D0
        public void get_ScaleMode(){} // RVA: 0x1C86A00
        public void set_ScaleMode(){} // RVA: 0x1A66500
        public void get_NoDefaultDisplay(){} // RVA: 0x1702E10
        public void set_NoDefaultDisplay(){} // RVA: 0x1702E20
        public void get_DisplayInEditor(){} // RVA: 0x1B6CD40
        public void set_DisplayInEditor(){} // RVA: 0x1B6CF40
        public void Awake(){} // RVA: 0x1C86A10
        public void OnMediaPlayerEvent(){} // RVA: 0x1C86B60
        public void ChangeMediaPlayer(){} // RVA: 0x1C86CD0
        public void EnsureShader(){} // RVA: 0x1C87050
        public void EnsureAlphaPackingShader(){} // RVA: 0x1C87210
        public void EnsureStereoPackingShader(){} // RVA: 0x1C87300
        public void EnsureAndroidOESShader(){} // RVA: 0x1C873F0
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x1C874E0
        public void Start(){} // RVA: 0x1C875D0
        public void OnDestroy(){} // RVA: 0x1C87780
        public void GetRequiredShader(){} // RVA: 0x1C87910
        public void get_mainTexture(){} // RVA: 0x1C87F10
        public void HasValidTexture(){} // RVA: 0x1C88110
        public void UpdateInternalMaterial(){} // RVA: 0x1C88370
        public void LateUpdate(){} // RVA: 0x1C88800
        public void get_CurrentMediaPlayer(){} // RVA: 0x35E900
        public void set_CurrentMediaPlayer(){} // RVA: 0x1C88E90
        public void get_uvRect(){} // RVA: 0x1C869E0
        public void set_uvRect(){} // RVA: 0x1C89020
        public void SetNativeSize(){} // RVA: 0x1C89090
        public void OnPopulateMesh(){} // RVA: 0x1C894F0
        public void _OnFillVBO(){} // RVA: 0x1C895A0
        public void GetDrawingDimensions(){} // RVA: 0x1C89A60
        public void .ctor(){} // RVA: 0x1C8A220
        public void .cctor(){} // RVA: 0x1C8A3A0
    }

    public class Helper
    {
        // ── Methods ──
        public void GetPath(){} // RVA: 0x1CA4EF0
        public void GetFilePath(){} // RVA: 0x1CA5070
        public void GetFriendlyResolutionName(){} // RVA: 0x1CA52C0
        public void GetErrorMessage(){} // RVA: 0x1CA5630
        public void GetPlatformName(){} // RVA: 0x1CA57C0
        public void GetPlatformNames(){} // RVA: 0x1CA5870
        public void LogInfo(){} // RVA: 0x1CA5C80
        public void GetUnityAudioSampleRate(){} // RVA: 0x1CA5DE0
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x1CA5E90
        public void GetTimelineRange(){} // RVA: 0x1CA5F70
        public void GetTimeString(){} // RVA: 0x1CA5FD0
        public void GetOrientation(){} // RVA: 0x1CA6430
        public void GetMatrixForOrientation(){} // RVA: 0x1CA6640
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x1CA6860
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x1CA6900
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x1CA6940
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x1CA6A90
        public void GetShortPathName(){} // RVA: 0x1CA6BF0
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x1CA6CE0
        public void GetReadableTexture(){} // RVA: 0x1CA74D0 | overloaded x2
        public void .cctor(){} // RVA: 0x1CA77F0
    }

    public class HttpHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void IsComplete(){} // RVA: 0x1CB9630
        public void ToValidatedString(){} // RVA: 0x1CB9660
        public void IsValid(){} // RVA: 0x1CB9860 | overloaded x2
        public void IsAscii(){} // RVA: 0x1CB9800
    }

    public class HttpHeaderData
    {
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.HttpHeader> httpHeaders; // 0x10

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x1CB98A0
        public void get_Item(){} // RVA: 0x1CB9980
        public void Clear(){} // RVA: 0x1CB9A10
        public void Add(){} // RVA: 0x1CB9A80
        public void IsModified(){} // RVA: 0x1CB9BB0
        public void ToValidatedString(){} // RVA: 0x1CB9C00
        public void .ctor(){} // RVA: 0x1CB9E30
    }

    public class IAudioTracks
    {
        // ── Methods ──
        public void GetAudioTracks(){} // RVA: 0xCD60
        public void GetActiveAudioTrack(){} // RVA: 0xCD60
        public void SetActiveAudioTrack(){} // RVA: 0x24B10
    }

    public class IBufferedDisplay
    {
        // ── Methods ──
        public void UpdateBufferedDisplay(){} // RVA: 0xCD60
        public void GetBufferedFramesState(){}
        public void SetSlaves(){} // RVA: 0x24B10
        public void SetBufferedDisplayMode(){} // RVA: 0x26C40
        public void SetBufferedDisplayOptions(){} // RVA: 0x25130
    }

    public class IMediaCache
    {
        // ── Methods ──
        public void IsMediaCachingSupported(){} // RVA: 0xDBE0
        public void AddMediaToCache(){} // RVA: 0x2F090
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x24B10
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x24B10
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x24B10
        public void RemoveMediaFromCache(){} // RVA: 0x24B10
        public void GetCachedMediaStatus(){} // RVA: 0x17680
    }

    public class IMediaControl
    {
        // ── Methods ──
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0xDE40
        public void StartOpenMediaFromBuffer(){} // RVA: 0xE6C0
        public void AddChunkToMediaBuffer(){}
        public void EndOpenMediaFromBuffer(){} // RVA: 0xDBE0
        public void CloseMedia(){} // RVA: 0x24A50
        public void SetLooping(){} // RVA: 0x25130
        public void IsLooping(){} // RVA: 0xDBE0
        public void HasMetaData(){} // RVA: 0xDBE0
        public void CanPlay(){} // RVA: 0xDBE0
        public void IsPlaying(){} // RVA: 0xDBE0
        public void IsSeeking(){} // RVA: 0xDBE0
        public void IsPaused(){} // RVA: 0xDBE0
        public void IsFinished(){} // RVA: 0xDBE0
        public void IsBuffering(){} // RVA: 0xDBE0
        public void Play(){} // RVA: 0x24A50
        public void Pause(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void Rewind(){} // RVA: 0x24A50
        public void Seek(){} // RVA: 0x26100
        public void SeekFast(){} // RVA: 0x26100
        public void SeekWithTolerance(){} // RVA: 0x283FA0
        public void SeekToFrame(){} // RVA: 0x28490
        public void SeekToFrameRelative(){} // RVA: 0x28490
        public void GetCurrentTime(){} // RVA: 0x12A40
        public void GetCurrentTimeFrames(){}
        public void GetProgramDateTime(){} // RVA: 0xCD60
        public void GetPlaybackRate(){} // RVA: 0x21890
        public void SetPlaybackRate(){} // RVA: 0x325B0
        public void MuteAudio(){} // RVA: 0x25130
        public void IsMuted(){} // RVA: 0xDBE0
        public void SetVolume(){} // RVA: 0x325B0
        public void SetBalance(){} // RVA: 0x325B0
        public void GetVolume(){} // RVA: 0x21890
        public void GetBalance(){} // RVA: 0x21890
        public void GetSeekableTimes(){} // RVA: 0xCD60
        public void GetBufferedTimes(){} // RVA: 0xCD60
        public void GetLastError(){} // RVA: 0xD840
        public void GetLastExtendedErrorCode(){} // RVA: 0xCD60
        public void SetTextureProperties(){}
        public void GetTextureProperties(){} // RVA: 0x2F090
        public void GrabAudio(){}
        public void GetAudioBufferedSampleCount(){} // RVA: 0xD840
        public void GetAudioChannelCount(){} // RVA: 0xD840
        public void GetAudioChannelMask(){} // RVA: 0xD840
        public void AudioConfigurationChanged(){} // RVA: 0x25130
        public void SetAudioChannelMode(){} // RVA: 0x24FA0
        public void SetAudioHeadRotation(){} // RVA: 0x24B10
        public void ResetAudioHeadRotation(){} // RVA: 0x24A50
        public void SetAudioFocusEnabled(){} // RVA: 0x25130
        public void SetAudioFocusProperties(){}
        public void SetAudioFocusRotation(){} // RVA: 0x24B10
        public void ResetAudioFocus(){} // RVA: 0x24A50
        public void WaitForNextFrame(){} // RVA: 0x10840
        public void SetPlayWithoutBuffering(){} // RVA: 0x25130
        public void SetKeyServerAuthToken(){} // RVA: 0x24B10
        public void SetOverrideDecryptionKey(){} // RVA: 0x24B10
        public void IsExternalPlaybackActive(){} // RVA: 0xDBE0
        public void SetAllowsExternalPlayback(){} // RVA: 0x25130
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x24FA0
    }

    public class IMediaInfo
    {
        // ── Methods ──
        public void GetDuration(){} // RVA: 0x12A40
        public void GetDurationFrames(){}
        public void GetMaxFrameNumber(){}
        public void GetVideoWidth(){} // RVA: 0xD840
        public void GetVideoHeight(){} // RVA: 0xD840
        public void GetVideoFrameRate(){} // RVA: 0x21890
        public void GetVideoDisplayRate(){} // RVA: 0x21890
        public void HasVideo(){} // RVA: 0xDBE0
        public void HasAudio(){} // RVA: 0xDBE0
        public void GetPlayerDescription(){} // RVA: 0xCD60
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0xDBE0
        public void IsPlaybackStalled(){} // RVA: 0xDBE0
        public void GetTextureTransform(){} // RVA: 0xCD60
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0xCD60
        public void IsExternalPlaybackSupported(){} // RVA: 0xDBE0
        public void GetDecoderPerformance(){}
        public void GetPlaybackQualityStats(){} // RVA: 0xCD60
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x24A50
        public void Update(){} // RVA: 0x24A50
        public void EndUpdate(){} // RVA: 0x24A50
        public void BeginRender(){} // RVA: 0x24A50
        public void Render(){} // RVA: 0x24A50
        public void GetNativePlayerHandle(){} // RVA: 0xCD60
    }

    public class IMediaSubtitles
    {
        // ── Methods ──
        public void LoadSubtitlesSRT(){} // RVA: 0xDE40
        public void GetSubtitleIndex(){} // RVA: 0xD840
        public void GetSubtitleText(){} // RVA: 0xCD60
    }

    public class ITextTracks
    {
        // ── Methods ──
        public void GetTextTracks(){} // RVA: 0xCD60
        public void GetActiveTextTrack(){} // RVA: 0xCD60
        public void SetActiveTextTrack(){} // RVA: 0x24B10
        public void GetCurrentTextCue(){} // RVA: 0xCD60
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0xD840
        public void GetTexture(){} // RVA: 0x1BCC0
        public void GetTextureFrameCount(){} // RVA: 0xD840
        public void SupportsTextureFrameCount(){} // RVA: 0xDBE0
        public void GetTextureTimeStamp(){} // RVA: 0xCD60
        public void GetTexturePixelAspectRatio(){} // RVA: 0x21890
        public void RequiresVerticalFlip(){} // RVA: 0xDBE0
        public void GetTextureStereoPacking(){} // RVA: 0xD840
        public void GetTextureTransparency(){} // RVA: 0xD840
        public void GetTextureAlphaPacking(){} // RVA: 0xD840
        public void GetYpCbCrTransform(){}
    }

    public class IVideoTracks
    {
        // ── Methods ──
        public void GetVideoTracks(){} // RVA: 0xCD60
        public void GetActiveVideoTrack(){} // RVA: 0xCD60
        public void SetActiveVideoTrack(){} // RVA: 0x24B10
    }

    public class KeyAuthData
    {
        // ── Methods ──
        public void IsModified(){} // RVA: 0x1CB9EF0
        public void OnBeforeSerialize(){} // RVA: 0x1CB9F20
        public void OnAfterDeserialize(){} // RVA: 0x1CB9F90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LazyShaderProperty
    {
        public string _name; // 0x10
        public int _id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CBDE20
        public void get_Name(){} // RVA: 0x1AD4690
        public void get_Id(){} // RVA: 0x1CBDE90
    }

    public class MediaCachingOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MediaHints
    {
        public 0x65997F38 transparency; // 0x10

        // ── Methods ──
        public void get_Default(){} // RVA: 0x1CA8240
        public void .cctor(){} // RVA: 0x2DD310
    }

    public class MediaPath
    {
        public 0x65997C78 _pathType; // 0x10
        public string _path; // 0x18

        // ── Methods ──
        public void get_PathType(){} // RVA: 0x32A5C0
        public void set_PathType(){} // RVA: 0x2E00C0
        public void get_Path(){} // RVA: 0x2E07C0
        public void set_Path(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x1CA7E80 | overloaded x3
        public void GetResolvedFullPath(){} // RVA: 0x1CA7F90
        public void op_Equality(){} // RVA: 0x1CA8060
        public void op_Inequality(){} // RVA: 0x1CA8080
        public void Equals(){} // RVA: 0x1CA80C0
        public void GetHashCode(){} // RVA: 0x1CA8200
    }

    public class MediaPlayer
    {
        public 0x65997C20 _mediaSource; // 0x20
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
        public 0x65999488 _resampleMode; // 0x68
        public int _resampleBufferSize; // 0x6C
        public RenderHeads.Media.AVProVideo.Resampler _resampler; // 0x70
        public 0x659980F0 _videoMapping; // 0x78
        public 0x65897F70 _textureFilterMode; // 0x7C
        public 0x65897FC8 _textureWrapMode; // 0x80
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
        public 0x65998148 _forceFileFormat; // 0xD8
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
        public void get_MediaSource(){} // RVA: 0x760030
        public void set_MediaSource(){} // RVA: 0x99E0D0
        public void get_MediaReference(){} // RVA: 0x30B130
        public void set_MediaReference(){} // RVA: 0x2DEE90
        public void get_MediaPath(){} // RVA: 0x6374D0
        public void set_MediaPath(){} // RVA: 0x30B890
        public void get_FallbackMediaHints(){} // RVA: 0x343F40
        public void set_FallbackMediaHints(){} // RVA: 0x343F60
        public void get_AutoOpen(){} // RVA: 0x1AF8C70
        public void set_AutoOpen(){} // RVA: 0x1AF8C60
        public void get_AutoStart(){} // RVA: 0x1C90FC0
        public void set_AutoStart(){} // RVA: 0x1C90FD0
        public void get_Loop(){} // RVA: 0x1C90FE0
        public void set_Loop(){} // RVA: 0x1C91040
        public void get_AudioVolume(){} // RVA: 0x1C910B0
        public void set_AudioVolume(){} // RVA: 0x1C91110
        public void get_AudioBalance(){} // RVA: 0x1C911A0
        public void set_AudioBalance(){} // RVA: 0x1C91200
        public void get_AudioMuted(){} // RVA: 0x1C91290
        public void set_AudioMuted(){} // RVA: 0x1C912F0
        public void get_AudioSource(){} // RVA: 0x3A5500
        public void set_AudioSource(){} // RVA: 0x3A5510
        public void get_PlaybackRate(){} // RVA: 0x1C91360
        public void set_PlaybackRate(){} // RVA: 0x1C913C0
        public void get_UseResampler(){} // RVA: 0x1498640
        public void set_UseResampler(){} // RVA: 0x1C91430
        public void get_ResampleMode(){} // RVA: 0x1C91440
        public void set_ResampleMode(){} // RVA: 0x1C91450
        public void get_ResampleBufferSize(){} // RVA: 0x1C91460
        public void set_ResampleBufferSize(){} // RVA: 0x1C91470
        public void get_FrameResampler(){} // RVA: 0x3A5590
        public void get_VideoLayoutMapping(){} // RVA: 0x1AE3800
        public void set_VideoLayoutMapping(){} // RVA: 0x1AE6D80
        public void get_TextureFilterMode(){} // RVA: 0x1C91480
        public void set_TextureFilterMode(){} // RVA: 0x1C91580
        public void get_TextureWrapMode(){} // RVA: 0x1C91600
        public void set_TextureWrapMode(){} // RVA: 0x1C91700
        public void get_TextureAnisoLevel(){} // RVA: 0x1C91780
        public void set_TextureAnisoLevel(){} // RVA: 0x1C91880
        public void get_SideloadSubtitles(){} // RVA: 0x1342AB0
        public void set_SideloadSubtitles(){} // RVA: 0x10F2C40
        public void get_SubtitlePath(){} // RVA: 0x796DE0
        public void set_SubtitlePath(){} // RVA: 0xB54600
        public void set_AudioHeadTransform(){} // RVA: 0x9AA650
        public void get_AudioHeadTransform(){} // RVA: 0xA1C8C0
        public void get_AudioFocusEnabled(){} // RVA: 0x1B6CD50
        public void set_AudioFocusEnabled(){} // RVA: 0xB70090
        public void get_AudioFocusTransform(){} // RVA: 0xA1C130
        public void set_AudioFocusTransform(){} // RVA: 0xAE5030
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x135AEB0
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x1C91900
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x1C91910
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x1C91920
        public void get_HttpHeaders(){} // RVA: 0x3480B0
        public void set_HttpHeaders(){} // RVA: 0x3480C0
        public void get_KeyAuth(){} // RVA: 0x348120
        public void set_KeyAuth(){} // RVA: 0x348130
        public void get_Events(){} // RVA: 0x1C91930
        public void get_EventMask(){} // RVA: 0xA50BB0
        public void set_EventMask(){} // RVA: 0x1AE7FE0
        public void get_PauseMediaOnAppPause(){} // RVA: 0x1C919F0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x1C91A00
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x1C91A10
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x1C91A20
        public void get_Persistent(){} // RVA: 0x1C91A30
        public void set_Persistent(){} // RVA: 0x1C91A40
        public void get_ForceFileFormat(){} // RVA: 0x1C91A50
        public void set_ForceFileFormat(){} // RVA: 0x1C91A60
        public void get_Info(){} // RVA: 0x7F7DB0
        public void get_Control(){} // RVA: 0x35E970
        public void get_Player(){} // RVA: 0xA94E10
        public void get_TextureProducer(){} // RVA: 0x3482A0
        public void get_Subtitles(){} // RVA: 0xA902E0
        public void get_VideoTracks(){} // RVA: 0x59E660
        public void get_AudioTracks(){} // RVA: 0xA8EE80
        public void get_TextTracks(){} // RVA: 0xA8E870
        public void get_Cache(){} // RVA: 0x507710
        public void get_BufferedDisplay(){} // RVA: 0x507D10
        public void get_MediaOpened(){} // RVA: 0x1C91A70
        public void Awake(){} // RVA: 0x1C91A80
        public void Initialise(){} // RVA: 0x1C91B20
        public void Start(){} // RVA: 0x1C92520
        public void OpenMedia(){} // RVA: 0x1C927E0 | overloaded x4
        public void InternalOpenMedia(){} // RVA: 0x1C92810
        public void SetLoadOptions(){} // RVA: 0x1C93000
        public void SetPlaybackOptions(){} // RVA: 0x1C930D0
        public void CloseMedia(){} // RVA: 0x1C93200
        public void RewindPrerollPause(){} // RVA: 0x1C933A0
        public void Play(){} // RVA: 0x1C93490
        public void Pause(){} // RVA: 0x1C93530
        public void Stop(){} // RVA: 0x1C935B0
        public void Rewind(){} // RVA: 0x1C93610
        public void SeekToLiveTime(){} // RVA: 0x1C936A0
        public void Update(){} // RVA: 0x1C93740
        public void LateUpdate(){} // RVA: 0x1C93970
        public void UpdateResampler(){} // RVA: 0x1C93B50
        public void OnEnable(){} // RVA: 0x1C93CE0
        public void OnDisable(){} // RVA: 0x1C93D60
        public void OnDestroy(){} // RVA: 0x1C93E00
        public void ForceDispose(){} // RVA: 0x1C94460
        public void AllPlayersDispose(){} // RVA: 0x1C94510
        public void HandleApplicationQuit(){} // RVA: 0x1C94650
        public void StartRenderCoroutine(){} // RVA: 0x1C94970
        public void StopRenderCoroutine(){} // RVA: 0x1C94A90
        public void FinalRenderCapture(){} // RVA: 0x1C94B10
        public void GetPlatform(){} // RVA: 0x519240
        public void GetCurrentPlatformOptions(){} // RVA: 0x82F060
        public void GetPlatformVideoApiString(){} // RVA: 0x1C94BB0
        public void GetPlatformFileOffset(){} // RVA: 0x519240
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x1C94C30
        public void GetResolvedFilePath(){} // RVA: 0x1C94CE0
        public void CreateMediaPlayer(){} // RVA: 0x1C95000 | overloaded x2
        public void CreateMediaPlayerNull(){} // RVA: 0x1C94F90
        public void UpdateAudioFocus(){} // RVA: 0x1C953B0
        public void UpdateAudioHeadTransform(){} // RVA: 0x1C95630
        public void UpdateErrors(){} // RVA: 0x1C95850
        public void IsUsingAndroidOESPath(){} // RVA: 0x1C95B00
        public void OnApplicationFocus(){} // RVA: 0x2DD310
        public void OnApplicationPause(){} // RVA: 0x2DD310
        public void ResetEvents(){} // RVA: 0x1C95B50
        public void UpdateEvents(){} // RVA: 0x1C95B80
        public void IsHandleEvent(){} // RVA: 0x1C96060
        public void FireEventIfPossible(){} // RVA: 0x1C96090
        public void CanFireEvent(){} // RVA: 0x1C96120
        public void ForceWaitForNewFrame(){} // RVA: 0x1C965C0
        public void GetDummyCamera(){} // RVA: 0x1C967F0
        public void ExtractFrameCoroutine(){} // RVA: 0x1C96C60
        public void ExtractFrameAsync(){} // RVA: 0x1C96DE0
        public void ExtractFrame(){} // RVA: 0x1C97170 | overloaded x2
        public void OpenMediaFromBuffer(){} // RVA: 0x1C97410
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x1C97510
        public void AddChunkToVideoBuffer(){} // RVA: 0x1C97790
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x1C978B0
        public void OpenMediaFromBufferInternal(){} // RVA: 0x1C97940
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x1C97BA0
        public void AddChunkToBufferInternal(){} // RVA: 0x1C97790
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x1C978B0
        public void get_PlatformOptionsWindows(){} // RVA: 0x82F060
        public void get_PlatformOptionsMacOSX(){} // RVA: 0xDA5BB0
        public void get_PlatformOptionsIOS(){} // RVA: 0xD83B50
        public void get_PlatformOptionsTVOS(){} // RVA: 0xA90180
        public void get_PlatformOptionsAndroid(){} // RVA: 0xA974D0
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0xDB1150
        public void get_PlatformOptionsWebGL(){} // RVA: 0xA94F10
        public void EnableSubtitles(){} // RVA: 0x1C97D80
        public void LoadSubtitlesCoroutine(){} // RVA: 0x1C981D0
        public void DisableSubtitles(){} // RVA: 0x1C98330
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x1C984A0
        public void .ctor(){} // RVA: 0x1C98620
    }

    public class MediaPlayerEvent
    {
        // ── Methods ──
        public void HasListeners(){} // RVA: 0x1CA49D0
        public void AddListener(){} // RVA: 0x1CA4A60
        public void RemoveListener(){} // RVA: 0x1CA4BE0
        public void RemoveAllListeners(){} // RVA: 0x1CA4CE0
        public void .ctor(){} // RVA: 0x1CA4D50
    }

    public class MediaPlayerLoadEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CA4990
    }

    public class MediaPlaylist
    {
        public System.Collections.Generic.List`1<MediaItem> _items; // 0x10

        // ── Methods ──
        public void get_Items(){} // RVA: 0x2F8380
        public void HasItemAt(){} // RVA: 0x1C9A5F0
        public void .ctor(){} // RVA: 0x1C9A660
    }

    public class MediaReference
    {
        public string outputs; // 0x18
        public RenderHeads.Media.AVProVideo.MediaPath _mediaPath; // 0x20
        public RenderHeads.Media.AVProVideo.MediaHints _hints; // 0x28

        // ── Methods ──
        public void get_Alias(){} // RVA: 0x2E07C0
        public void set_Alias(){} // RVA: 0x343E80
        public void get_MediaPath(){} // RVA: 0x30B0C0
        public void set_MediaPath(){} // RVA: 0x30B0D0
        public void get_Hints(){} // RVA: 0x358700
        public void set_Hints(){} // RVA: 0x358720
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x1C8B1E0
        public void GetPlatformMediaReference(){} // RVA: 0x1C8B2B0
        public void .ctor(){} // RVA: 0x1C8B330
    }

    public class NullMediaPlayer
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x1CA96D0
        public void GetExpectedVersion(){} // RVA: 0x1CA9710
        public void OpenMedia(){} // RVA: 0x1CA9730
        public void CloseMedia(){} // RVA: 0x1CA9A70
        public void SetLooping(){} // RVA: 0x2FE4D0
        public void IsLooping(){} // RVA: 0x2FE4C0
        public void HasMetaData(){} // RVA: 0x3C2850
        public void CanPlay(){} // RVA: 0x3C2850
        public void HasAudio(){} // RVA: 0x2DD320
        public void HasVideo(){} // RVA: 0x2DD320
        public void Play(){} // RVA: 0x1CA9AB0
        public void Pause(){} // RVA: 0x1CA9AD0
        public void Stop(){} // RVA: 0x1CA9AE0
        public void IsSeeking(){} // RVA: 0x2DD320
        public void IsPlaying(){} // RVA: 0x5A6180
        public void IsPaused(){} // RVA: 0x1CA9AF0
        public void IsFinished(){} // RVA: 0x1CA9B00
        public void IsBuffering(){} // RVA: 0x2DD320
        public void GetDuration(){} // RVA: 0x1CA9B50
        public void GetVideoWidth(){} // RVA: 0x1CA9B60
        public void GetVideoHeight(){} // RVA: 0xA002A0
        public void GetVideoDisplayRate(){} // RVA: 0xAFFE90
        public void GetTexture(){} // RVA: 0x3FA100
        public void GetTextureFrameCount(){} // RVA: 0x1CA9B70
        public void InternalGetTextureStereoPacking(){} // RVA: 0x5B1C70
        public void RequiresVerticalFlip(){} // RVA: 0x2DD320
        public void Seek(){} // RVA: 0x1CA9B80
        public void SeekFast(){} // RVA: 0x1CA9B80
        public void GetCurrentTime(){} // RVA: 0x1CA9B90
        public void SetPlaybackRate(){} // RVA: 0x1CA9BA0
        public void GetPlaybackRate(){} // RVA: 0x1CA9BB0
        public void MuteAudio(){} // RVA: 0x2DD310
        public void IsMuted(){} // RVA: 0x3C2850
        public void SetVolume(){} // RVA: 0x1CA9BC0
        public void GetVolume(){} // RVA: 0x1CA9BD0
        public void GetVideoFrameRate(){} // RVA: 0xAFF380
        public void Update(){} // RVA: 0x1CA9BE0
        public void Render(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
        public void InternalSetActiveTrack(){} // RVA: 0x2DD320
        public void InternalIsChangedTracks(){} // RVA: 0x2DD320
        public void InternalGetTrackCount(){} // RVA: 0x519240
        public void InternalGetTrackInfo(){} // RVA: 0x519240
        public void InternalIsChangedTextCue(){} // RVA: 0x2DD320
        public void InternalGetCurrentTextCue(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x1CA9ED0
    }

    public class OptionsAppleExtensions
    {
        // ── Methods ──
        public void GenerateMipmaps(){} // RVA: 0x1C9A500
        public void SetGenerateMipMaps(){} // RVA: 0x1C9A510
        public void AllowExternalPlayback(){} // RVA: 0x1C9A530
        public void SetAllowExternalPlayback(){} // RVA: 0x1C9A540
        public void PlayWithoutBuffering(){} // RVA: 0x1C9A560
        public void SetPlayWithoutBuffering(){} // RVA: 0x1C9A570
        public void UseSinglePlayerItem(){} // RVA: 0x1C9A590
        public void SetUseSinglePlayerItem(){} // RVA: 0x1C9A5A0
        public void ResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x1C9A5C0
        public void SetResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x1C9A5D0
    }

    public class PlaybackQualityStats
    {
        public int Parser; // 0x10
        public int Descriptor; // 0x14
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public float BaseOptions; // 0x1C
        public string get_Descriptor; // 0x20
        public int <PerfectFrames>k__BackingField; // 0x28
        public int <TotalFrames>k__BackingField; // 0x2C
        public bool <LogIssues>k__BackingField; // 0x30

        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0x32A5C0
        public void set_SkippedFrames(){} // RVA: 0x2E00C0
        public void get_DuplicateFrames(){} // RVA: 0x8ABED0
        public void set_DuplicateFrames(){} // RVA: 0x8AC660
        public void get_UnityDroppedFrames(){} // RVA: 0x5BED50
        public void set_UnityDroppedFrames(){} // RVA: 0x6374E0
        public void get_PerfectFramesT(){} // RVA: 0x3AA570
        public void set_PerfectFramesT(){} // RVA: 0x3AA580
        public void get_VSyncStatus(){} // RVA: 0x30B0C0
        public void set_VSyncStatus(){} // RVA: 0x30B0D0
        public void get_PerfectFrames(){} // RVA: 0x791DC0
        public void set_PerfectFrames(){} // RVA: 0xA53440
        public void get_TotalFrames(){} // RVA: 0x1209F00
        public void set_TotalFrames(){} // RVA: 0x1AFCF60
        public void get_LogIssues(){} // RVA: 0x303450
        public void set_LogIssues(){} // RVA: 0x303460
        public void Reset(){} // RVA: 0x1CA89E0
        public void Start(){} // RVA: 0x1CA8A30
        public void Update(){} // RVA: 0x1CA9030
        public void IsGameViewVSyncEnabled(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PlaylistMediaPlayer
    {
        public UnityEngine.Shader _transitionShader; // 0x1C0
        public RenderHeads.Media.AVProVideo.MediaPlayer _playerA; // 0x1C8
        public RenderHeads.Media.AVProVideo.MediaPlayer _playerB; // 0x1D0
        public bool _playlistAutoProgress; // 0x1D8
        public bool _autoCloseVideo; // 0x1D9
        public 0x65997280 _playlistLoopMode; // 0x1DC
        public RenderHeads.Media.AVProVideo.MediaPlaylist _playlist; // 0x1E0
        public bool _pausePreviousOnTransition; // 0x1E8
        public 0x65997228 _defaultTransition; // 0x1EC
        public float _defaultTransitionDuration; // 0x1F0
        public 0x65997388 _defaultTransitionEasing; // 0x1F4
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropFromTex;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropFade; // 0x10
        public bool _isPaused; // 0x1F8
        public int _playlistIndex; // 0x1FC
        public RenderHeads.Media.AVProVideo.MediaPlayer _nextPlayer; // 0x200

        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x1C9A8E0
        public void get_NextPlayer(){} // RVA: 0xD9E9A0
        public void get_Playlist(){} // RVA: 0x8CBA20
        public void get_PlaylistIndex(){} // RVA: 0x1C9AA30
        public void get_PlaylistItem(){} // RVA: 0x1C9AA40
        public void get_DefaultTransition(){} // RVA: 0x1C9AB30
        public void set_DefaultTransition(){} // RVA: 0x1C9AB40
        public void get_DefaultTransitionDuration(){} // RVA: 0x1C9AB50
        public void set_DefaultTransitionDuration(){} // RVA: 0x1C9AB60
        public void get_DefaultTransitionEasing(){} // RVA: 0x1C9AB70
        public void set_DefaultTransitionEasing(){} // RVA: 0x1C9AB80
        public void get_AutoCloseVideo(){} // RVA: 0x1C9AB90
        public void set_AutoCloseVideo(){} // RVA: 0x1C9ABA0
        public void get_LoopMode(){} // RVA: 0x1C9ABB0
        public void set_LoopMode(){} // RVA: 0x1C9ABC0
        public void get_AutoProgress(){} // RVA: 0x1C9ABD0
        public void set_AutoProgress(){} // RVA: 0x1C9ABE0
        public void get_Info(){} // RVA: 0x1C9ABF0
        public void get_Control(){} // RVA: 0x1C9AD00
        public void get_TextureProducer(){} // RVA: 0x1C9AE10
        public void get_AudioVolume(){} // RVA: 0x1C9AF40
        public void set_AudioVolume(){} // RVA: 0x1C9AF50
        public void get_AudioMuted(){} // RVA: 0x1C9B0A0
        public void set_AudioMuted(){} // RVA: 0x1C9B0B0
        public void Play(){} // RVA: 0x1C9B1E0
        public void Pause(){} // RVA: 0x1C9B2F0
        public void IsPaused(){} // RVA: 0x1C9B3F0
        public void SwapPlayers(){} // RVA: 0x1C9B400
        public void GetCurrentTexture(){} // RVA: 0x1C9BDF0
        public void GetNextTexture(){} // RVA: 0x1C9BF50
        public void Awake(){} // RVA: 0x1C9C0A0
        public void OnDestroy(){} // RVA: 0x1C9C450
        public void Start(){} // RVA: 0x1C9C790
        public void OnVideoEvent(){} // RVA: 0x1C9C9F0
        public void PrevItem(){} // RVA: 0x1C9CDB0
        public void NextItem(){} // RVA: 0x1C9CDC0
        public void CanJumpToItem(){} // RVA: 0x1C9CE40
        public void JumpToItem(){} // RVA: 0x1C9CF20
        public void OpenVideoFile(){} // RVA: 0x1C9D0F0
        public void IsTransitioning(){} // RVA: 0x1C9D4A0
        public void SetTransition(){} // RVA: 0x1C9D5A0
        public void Update(){} // RVA: 0x1C9D770
        public void GetTexture(){} // RVA: 0xD90BA0
        public void GetTextureCount(){} // RVA: 0x1C9DE10
        public void GetTextureFrameCount(){} // RVA: 0x1C9DE90
        public void SupportsTextureFrameCount(){} // RVA: 0x1C9DF10
        public void GetTextureTimeStamp(){} // RVA: 0x1C9DF90
        public void GetTexturePixelAspectRatio(){} // RVA: 0x1C9E010
        public void RequiresVerticalFlip(){} // RVA: 0x1C9E090
        public void GetYpCbCrTransform(){} // RVA: 0x1C9E110
        public void GetTextureStereoPacking(){} // RVA: 0x1C9E1C0
        public void GetTextureTransparency(){} // RVA: 0x1C9E240
        public void GetTextureAlphaPacking(){} // RVA: 0x1C9E2C0
        public void GetTransitionName(){} // RVA: 0x1C9E340
        public void .ctor(){} // RVA: 0x1C9E670
        public void .cctor(){} // RVA: 0x1C9E910
    }

    public class Resampler
    {
        public System.Collections.Generic.List`1<TimestampedRenderTexture[]> _droppedFrames; // 0x10
        public RenderHeads.Media.AVProVideo.MediaPlayer _frameDisplayedTimer; // 0x18
        public UnityEngine.RenderTexture[] _outputTexture; // 0x20
        public int _start; // 0x28
        public int _end; // 0x2C
        public int _bufferSize; // 0x30
        public long _baseTimestamp; // 0x38

        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x1C91440
        public void get_FrameDisplayedTimer(){} // RVA: 0x1AE3800
        public void get_BaseTimestamp(){} // RVA: 0x4976A0
        public void set_BaseTimestamp(){} // RVA: 0xF501D0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7D0490
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7D04A0
        public void get_LastT(){} // RVA: 0x8DF510
        public void set_LastT(){} // RVA: 0x8DD750
        public void get_TextureTimeStamp(){} // RVA: 0x796DE0
        public void set_TextureTimeStamp(){} // RVA: 0x1CBA190
        public void OnVideoEvent(){} // RVA: 0x1CBA1A0
        public void .ctor(){} // RVA: 0x1CBA280
        public void get_OutputTexture(){} // RVA: 0x30B0C0
        public void Reset(){} // RVA: 0x1CBA7C0
        public void Release(){} // RVA: 0x1CBA7E0
        public void ReleaseRenderTextures(){} // RVA: 0x1CBA970
        public void ConstructRenderTextures(){} // RVA: 0x1CBACC0
        public void CheckRenderTexturesValid(){} // RVA: 0x1CBB2A0
        public void FindBeforeFrameIndex(){} // RVA: 0x1CBB710
        public void FindClosestFrame(){} // RVA: 0x1CBB950
        public void PointUpdate(){} // RVA: 0x1CBBB30
        public void SampleFrame(){} // RVA: 0x1CBBE60
        public void SampleFrames(){} // RVA: 0x1CBC030
        public void LinearUpdate(){} // RVA: 0x1CBC400
        public void InvalidateBuffer(){} // RVA: 0x1CBC620
        public void GuessFrameRate(){} // RVA: 0x1CBC720
        public void Update(){} // RVA: 0x1CBC9E0
        public void UpdateTimestamp(){} // RVA: 0x1CBD700
    }

    public class ResolveToRenderTexture
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer IsCreated; // 0x20
        public RenderHeads.Media.AVProVideo.VideoResolveOptions Length; // 0x28
        public 0x65999698 Depthkit; // 0x58
        public UnityEngine.RenderTexture _externalTexture; // 0x60

        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0x30B0C0
        public void set_MediaPlayer(){} // RVA: 0x1C9F390
        public void get_VideoResolveOptions(){} // RVA: 0x1C9F3A0
        public void set_VideoResolveOptions(){} // RVA: 0x1C9F3C0
        public void get_ExternalTexture(){} // RVA: 0x37B370
        public void set_ExternalTexture(){} // RVA: 0x37B380
        public void get_TargetTexture(){} // RVA: 0x1C9F3E0
        public void SetMaterialDirty(){} // RVA: 0x48DED0
        public void ChangeMediaPlayer(){} // RVA: 0x1C9F4C0
        public void Start(){} // RVA: 0x1C9F660
        public void LateUpdate(){} // RVA: 0x1C9F950
        public void Resolve(){} // RVA: 0x1C9F960
        public void OnDisable(){} // RVA: 0x1CA0150
        public void OnDestroy(){} // RVA: 0x1CA02C0
        public void .ctor(){} // RVA: 0x1CA0400
    }

    public class Subtitle
    {
        // ── Methods ──
        public void IsBefore(){} // RVA: 0x1CBD720
        public void IsTime(){} // RVA: 0x1CBD740
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubtitlePlayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubtitleUtils
    {
        // ── Methods ──
        public void ParseTimeToSeconds(){} // RVA: 0x1CBD760
        public void ParseSubtitlesSRT(){} // RVA: 0x1CBD910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubtitlesUGUI
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer _player; // 0x20
        public UnityEngine.UI.Text _text; // 0x28

        // ── Methods ──
        public void set_Player(){} // RVA: 0x1C8A4D0
        public void get_Player(){} // RVA: 0x30B0C0
        public void set_Text(){} // RVA: 0x2DEE90
        public void get_Text(){} // RVA: 0x30B130
        public void Start(){} // RVA: 0x1C8A4E0
        public void OnDestroy(){} // RVA: 0x1C8A4F0
        public void Update(){} // RVA: 0x1C8A500
        public void ChangeMediaPlayer(){} // RVA: 0x1C8A510
        public void SetText(){} // RVA: 0x1C8A850
        public void PrepareText(){} // RVA: 0x1C8A890
        public void UpdateBackgroundRect(){} // RVA: 0x1C8AA00
        public void OnMediaPlayerEvent(){} // RVA: 0x1C8ACB0
        public void .ctor(){} // RVA: 0x1C8AF00
    }

    public class TextCue
    {
        public string <Text>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_Text(){} // RVA: 0x2F8380
        public void set_Text(){} // RVA: 0x2DEE30
    }

    public class TextTrack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CB9600 | overloaded x2
    }

    public class TextTracks
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x3E2CB0
        public void .ctor(){} // RVA: 0x1CB9550
    }

    public class TextureFrame
    {
    }

    public class TimeRange
    {
        public double startTime; // 0x10
        public double duration; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CA83B0
        public void get_StartTime(){} // RVA: 0x1CA83C0
        public void get_EndTime(){} // RVA: 0x1CA83D0
        public void get_Duration(){} // RVA: 0x1CA83E0
    }

    public class TimeRanges
    {
        public RenderHeads.Media.AVProVideo.TimeRange[] _ranges; // 0x10
        public double _minTime; // 0x18
        public double _maxTime; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CA8750 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x1CA8480
        public void get_Item(){} // RVA: 0x1CA84A0
        public void ToString(){} // RVA: 0x1CA84E0
        public void CalculateRange(){} // RVA: 0x1CA8850
        public void get_Count(){} // RVA: 0xF3F910
        public void get_MinTime(){} // RVA: 0x196AD00
        public void get_MaxTime(){} // RVA: 0x1A346F0
        public void get_Duration(){} // RVA: 0x1CA89D0
    }

    public class TrackBase
    {
        public int _uid; // 0x10
        public 0x65998EB0 _trackType; // 0x14
        public string _displayName; // 0x18
        public string _name; // 0x20
        public string _language; // 0x28
        public bool _isDefault; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CB90F0 | overloaded x2
        public void get_Uid(){} // RVA: 0x32A5C0
        public void set_Uid(){} // RVA: 0x2E00C0
        public void get_TrackType(){} // RVA: 0x8ABED0
        public void set_TrackType(){} // RVA: 0x8AC660
        public void get_DisplayName(){} // RVA: 0x2E07C0
        public void set_DisplayName(){} // RVA: 0x343E80
        public void get_Name(){} // RVA: 0x30B0C0
        public void set_Name(){} // RVA: 0x30B0D0
        public void get_Language(){} // RVA: 0x30B130
        public void set_Language(){} // RVA: 0x2DEE90
        public void get_IsDefault(){} // RVA: 0x303450
        public void set_IsDefault(){} // RVA: 0x303460
        public void CreateDisplayName(){} // RVA: 0x1CB9370
    }

    public class TrackCollection
    {
        public 0x65998EB0 <TrackType>k__BackingField; // 0x10

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x32A5C0
        public void set_TrackType(){} // RVA: 0x2E00C0
        public void get_Count(){} // RVA: 0xD840
        public void GetEnumerator(){} // RVA: 0xCD60
        public void Clear(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x24B10
        public void HasActiveTrack(){} // RVA: 0xDBE0
        public void IsActiveTrack(){} // RVA: 0xDE40
        public void SetActiveTrack(){} // RVA: 0x24B10
        public void SetFirstTrackActive(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TrackCollection`1
    {
        public T <ActiveTrack>k__BackingField;
        public System.Collections.Generic.List`1<T> _tracks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void GetEnumerator(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void get_ActiveTrack(){} // RVA: 0x283FA0
        public void set_ActiveTrack(){} // RVA: 0x283FA0
        public void HasActiveTrack(){} // RVA: 0xDBE0
        public void IsActiveTrack(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x24B10
        public void SetActiveTrack(){} // RVA: 0x24B10
        public void SetFirstTrackActive(){} // RVA: 0x24A50
        public void get_Count(){} // RVA: 0xD840
    }

    public class TrackCollection`1
    {
        public RenderHeads.Media.AVProVideo.VideoTrack <ActiveTrack>k__BackingField; // 0x18
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.VideoTrack> _tracks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x441DBC0
        public void GetEnumerator(){} // RVA: 0x441DD00
        public void get_Item(){} // RVA: 0x441DDD0
        public void get_ActiveTrack(){} // RVA: 0x2E07C0
        public void set_ActiveTrack(){} // RVA: 0x343E80
        public void HasActiveTrack(){} // RVA: 0x1D3B060
        public void IsActiveTrack(){} // RVA: 0x441DE20
        public void Clear(){} // RVA: 0x441DE30
        public void Add(){} // RVA: 0x441DEC0
        public void SetActiveTrack(){} // RVA: 0x441DFD0
        public void SetFirstTrackActive(){} // RVA: 0x441E0D0
        public void get_Count(){} // RVA: 0x441E160
    }

    public class TrackCollection`1
    {
        public RenderHeads.Media.AVProVideo.AudioTrack <ActiveTrack>k__BackingField; // 0x18
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.AudioTrack> _tracks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x441DBC0
        public void GetEnumerator(){} // RVA: 0x441DD00
        public void get_Item(){} // RVA: 0x441DDD0
        public void get_ActiveTrack(){} // RVA: 0x2E07C0
        public void set_ActiveTrack(){} // RVA: 0x343E80
        public void HasActiveTrack(){} // RVA: 0x1D3B060
        public void IsActiveTrack(){} // RVA: 0x441DE20
        public void Clear(){} // RVA: 0x441DE30
        public void Add(){} // RVA: 0x441DEC0
        public void SetActiveTrack(){} // RVA: 0x441DFD0
        public void SetFirstTrackActive(){} // RVA: 0x441E0D0
        public void get_Count(){} // RVA: 0x441E160
    }

    public class TrackCollection`1
    {
        public RenderHeads.Media.AVProVideo.TextTrack <ActiveTrack>k__BackingField; // 0x18
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.TextTrack> _tracks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x441DBC0
        public void GetEnumerator(){} // RVA: 0x441DD00
        public void get_Item(){} // RVA: 0x441DDD0
        public void get_ActiveTrack(){} // RVA: 0x2E07C0
        public void set_ActiveTrack(){} // RVA: 0x343E80
        public void HasActiveTrack(){} // RVA: 0x1D3B060
        public void IsActiveTrack(){} // RVA: 0x441DE20
        public void Clear(){} // RVA: 0x441DE30
        public void Add(){} // RVA: 0x441DEC0
        public void SetActiveTrack(){} // RVA: 0x441DFD0
        public void SetFirstTrackActive(){} // RVA: 0x441E0D0
        public void get_Count(){} // RVA: 0x441E160
    }

    public class UpdateMultiPassStereo
    {
        public UnityEngine.Camera _camera; // 0x20

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x30B0C0
        public void set_Camera(){} // RVA: 0x30B0D0
        public void Awake(){} // RVA: 0x1CA04D0
        public void Start(){} // RVA: 0x1CA05E0
        public void LogXRDeviceDetails(){} // RVA: 0x1CA05F0
        public void IsMultiPassVrEnabled(){} // RVA: 0x1CA0B70
        public void LateUpdate(){} // RVA: 0x1CA0C10
        public void .ctor(){} // RVA: 0x2DDD50
        public void .cctor(){} // RVA: 0x1CA1540
    }

    public class VideoRender
    {
        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x1CBDF00
        public void CreateIMGUIMaterial(){} // RVA: 0x1CBDFA0
        public void SetupLayoutMaterial(){} // RVA: 0x1CBE020
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x1CBE1A0
        public void SetupStereoMaterial(){} // RVA: 0x1CBE2F0
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x1CBE5B0
        public void SetupAlphaPackedMaterial(){} // RVA: 0x1CBE680
        public void SetupGammaMaterial(){} // RVA: 0x1CBE7D0
        public void SetupTextureMatrix(){} // RVA: 0x2DD310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x1CBE8D0
        public void GetTexture(){} // RVA: 0x1CBEA10
        public void SetupMaterialForMedia(){} // RVA: 0x1CBEBC0
        public void SetupMaterial(){} // RVA: 0x1CBF210
        public void SetupResolveMaterial(){} // RVA: 0x1CBFA20
        public void ResolveVideoToRenderTexture(){} // RVA: 0x1CBFEB0
        public void GetResolveTextureSize(){} // RVA: 0x1CC07E0
        public void RequiresResolve(){} // RVA: 0x1CC0890
        public void DrawTexture(){} // RVA: 0x1CC0940
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x1CC1120
    }

    public class VideoResolveOptions
    {
        // ── Methods ──
        public void IsColourAdjust(){} // RVA: 0x1CA82B0
        public void ResetColourAdjust(){} // RVA: 0x1CA8310
        public void Create(){} // RVA: 0x1CA8340
    }

    public class VideoTrack
    {
        public int <Bitrate>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CB9590 | overloaded x2
        public void get_Bitrate(){} // RVA: 0xFDC9F0
        public void set_Bitrate(){} // RVA: 0xFDD6E0
    }

    public class VideoTracks
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x1CB94D0
    }

    public class WebGL
    {
    }

    public class Windows
    {
    }

    public class WindowsMediaPlayer
    {
        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x1CA9F00
        public void DeinitPlatform(){} // RVA: 0x1CAA3D0
        public void GetAudioChannelCount(){} // RVA: 0x1CAA480
        public void GetAudioChannelMask(){} // RVA: 0x1CAA500
        public void .ctor(){} // RVA: 0x1CAA7F0 | overloaded x2
        public void SetOptions(){} // RVA: 0x1CAAA50
        public void GetVersion(){} // RVA: 0x1CAAD90
        public void GetExpectedVersion(){} // RVA: 0x1CAADF0
        public void UseNativeMips(){} // RVA: 0x1CAAE30
        public void OpenMedia(){} // RVA: 0x1CAAE40
        public void OpenMediaFromBuffer(){} // RVA: 0x1CAB610
        public void StartOpenMediaFromBuffer(){} // RVA: 0x1CABAE0
        public void AddChunkToMediaBuffer(){} // RVA: 0x1CABBB0
        public void EndOpenMediaFromBuffer(){} // RVA: 0x1CABC70
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x1CAC0C0
        public void CloseMedia(){} // RVA: 0x1CAC290
        public void SetLooping(){} // RVA: 0x1CAC430
        public void IsLooping(){} // RVA: 0x408F80
        public void HasMetaData(){} // RVA: 0x1CAC4C0
        public void HasAudio(){} // RVA: 0x35EAD0
        public void HasVideo(){} // RVA: 0x18AA2A0
        public void CanPlay(){} // RVA: 0x1CAC4D0
        public void Play(){} // RVA: 0x1CAC4E0
        public void Pause(){} // RVA: 0x1CAC570
        public void Stop(){} // RVA: 0x1CAC570
        public void IsSeeking(){} // RVA: 0x1CAC590
        public void IsPlaying(){} // RVA: 0x1CAC620
        public void IsPaused(){} // RVA: 0x1CAC6A0
        public void IsFinished(){} // RVA: 0x1CAC6E0
        public void IsBuffering(){} // RVA: 0x1CAC7D0
        public void GetDuration(){} // RVA: 0x1CAC860
        public void GetVideoWidth(){} // RVA: 0x1CAC8E0
        public void GetVideoHeight(){} // RVA: 0x1CAC8F0
        public void GetVideoFrameRate(){} // RVA: 0x1CAC900
        public void GetTexture(){} // RVA: 0x1CAC910
        public void GetTextureFrameCount(){} // RVA: 0x1CACA20
        public void GetTextureTimeStamp(){} // RVA: 0x1CACA30
        public void GetTexturePixelAspectRatio(){} // RVA: 0x1CACAB0
        public void RequiresVerticalFlip(){} // RVA: 0x1CACB60
        public void InternalGetTextureStereoPacking(){} // RVA: 0x1CACB70
        public void Seek(){} // RVA: 0x1CACBF0
        public void SeekFast(){} // RVA: 0x1CACCB0
        public void GetCurrentTime(){} // RVA: 0x1CACD70
        public void SetPlaybackRate(){} // RVA: 0x1CACDF0
        public void GetPlaybackRate(){} // RVA: 0x1CACE80
        public void MuteAudio(){} // RVA: 0x1CACF00
        public void IsMuted(){} // RVA: 0x1C91A30
        public void SetVolume(){} // RVA: 0x1CACF90
        public void GetVolume(){} // RVA: 0x1CAD030
        public void SetBalance(){} // RVA: 0x1CAD040
        public void GetBalance(){} // RVA: 0x8A84A0
        public void IsPlaybackStalled(){} // RVA: 0x1CAD0E0
        public void WaitForNextFrame(){} // RVA: 0x1CAD190
        public void SetAudioChannelMode(){} // RVA: 0x1CAD3A0
        public void SetAudioHeadRotation(){} // RVA: 0x1CAD430
        public void ResetAudioHeadRotation(){} // RVA: 0x1CAD470
        public void SetAudioFocusEnabled(){} // RVA: 0x1CAD590
        public void SetAudioFocusProperties(){} // RVA: 0x1CAD5A0
        public void SetAudioFocusRotation(){} // RVA: 0x1CAD5B0
        public void ResetAudioFocus(){} // RVA: 0x1CAD5F0
        public void Update(){} // RVA: 0x1CAD660
        public void ReleaseTexture(){} // RVA: 0x1CADEA0
        public void UpdateTexture(){} // RVA: 0x1CAE140
        public void EndUpdate(){} // RVA: 0x1CAE8E0
        public void GetLastExtendedErrorCode(){} // RVA: 0x1CAE960
        public void OnTextureSizeChanged(){} // RVA: 0x2DD310
        public void BeginRender(){} // RVA: 0x1CAE9E0
        public void Render(){} // RVA: 0x1CAEA30
        public void Dispose(){} // RVA: 0x2DD310
        public void GrabAudio(){} // RVA: 0x1CAEA90
        public void GetAudioBufferedSampleCount(){} // RVA: 0x1CAEB50
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x1CAEBD0
        public void GetDecoderPerformance(){} // RVA: 0x1CAEBE0
        public void IssueRenderThreadEvent(){} // RVA: 0x1CAEC90
        public void GetPluginVersion(){} // RVA: 0x1CAEDB0
        public void InternalSetActiveTrack(){} // RVA: 0x1CAEE80
        public void InternalIsChangedTextCue(){} // RVA: 0x1CAEF30
        public void InternalGetCurrentTextCue(){} // RVA: 0x1CAEFC0
        public void InternalIsChangedTracks(){} // RVA: 0x1CAF090
        public void InternalGetTrackCount(){} // RVA: 0x1CAF130
        public void InternalGetTrackInfo(){} // RVA: 0x1CAF1D0
        public void UpdateTimeRanges(){} // RVA: 0x1CAF620
        public void UpdateTimeRange(){} // RVA: 0x1CAF690
        public void FlushFrameBuffering(){} // RVA: 0x1CAF7A0
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x1CAF8F0
        public void LogBufferState(){} // RVA: 0x1CB00E0
        public void SetBufferedDisplayTime(){} // RVA: 0x1CB04B0
        public void GetBufferedFramesState(){} // RVA: 0x1CB0570
        public void SetBufferedDisplayMode(){} // RVA: 0x1CB0610
        public void SetBufferedDisplayOptions(){} // RVA: 0x1CB0730
        public void SetSlaves(){} // RVA: 0x1CB0760
        public void IsPrerollComplete(){} // RVA: 0x1CB08D0
        public void .cctor(){} // RVA: 0x1CB0A60
    }

    public class WindowsRtMediaPlayer
    {
        public bool _isMediaLoaded; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CB4200 | overloaded x2
        public void CanPlay(){} // RVA: 0x1CB44E0
        public void Dispose(){} // RVA: 0x1CB4500
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x2DD320
        public void GetCurrentTime(){} // RVA: 0x1CB4680
        public void GetDuration(){} // RVA: 0x1CB4700
        public void GetPlaybackRate(){} // RVA: 0x1CB4710
        public void GetTexture(){} // RVA: 0x1CB4790
        public void GetTextureCount(){} // RVA: 0x1CB47E0
        public void GetTextureFrameCount(){} // RVA: 0x1896340
        public void InternalGetTextureStereoPacking(){} // RVA: 0x1CB48F0
        public void GetVersion(){} // RVA: 0x1CB4970
        public void GetExpectedVersion(){} // RVA: 0x1CB49D0
        public void GetVideoFrameRate(){} // RVA: 0x1CB4A10
        public void GetVideoWidth(){} // RVA: 0x1CB4AC0
        public void GetVideoHeight(){} // RVA: 0x1CB4C00
        public void GetVolume(){} // RVA: 0x1CB4D40
        public void SetBalance(){} // RVA: 0x1CB4DC0
        public void GetBalance(){} // RVA: 0x1CB4E50
        public void HasAudio(){} // RVA: 0x1CB4ED0
        public void HasMetaData(){} // RVA: 0x1CB4F10
        public void HasVideo(){} // RVA: 0x1CB4F40
        public void IsBuffering(){} // RVA: 0x1CB4F80
        public void IsFinished(){} // RVA: 0x1CB4FA0
        public void IsLooping(){} // RVA: 0x1CB5050
        public void IsMuted(){} // RVA: 0x1CB50E0
        public void IsPaused(){} // RVA: 0x1CB5170
        public void IsPlaying(){} // RVA: 0x1CB5190
        public void IsSeeking(){} // RVA: 0x1CB51B0
        public void MuteAudio(){} // RVA: 0x1CB51D0
        public void OpenMedia(){} // RVA: 0x1CB5260
        public void CloseMedia(){} // RVA: 0x1CB5470
        public void Pause(){} // RVA: 0x1CB5510
        public void Play(){} // RVA: 0x1CB5590
        public void Render(){} // RVA: 0x1CB5610
        public void Update_Textures(){} // RVA: 0x1CB5690
        public void get_AuthenticationData(){} // RVA: 0x348040
        public void set_AuthenticationData(){} // RVA: 0x1CB5BA0
        public void RequiresVerticalFlip(){} // RVA: 0x3C2850
        public void Seek(){} // RVA: 0x1CB5C10
        public void SeekFast(){} // RVA: 0x1CA3000
        public void SetLooping(){} // RVA: 0x1CB5CA0
        public void SetPlaybackRate(){} // RVA: 0x1CB5D30
        public void SetVolume(){} // RVA: 0x1CB5DC0
        public void Stop(){} // RVA: 0x1CB5E50
        public void UpdateTimeRanges(){} // RVA: 0x1CB5E70
        public void UpdateTimeRange(){} // RVA: 0x1CB5EE0
        public void GetProgramDateTime(){} // RVA: 0x1CB5FF0
        public void Update(){} // RVA: 0x1CB61F0
        public void SetKeyServerAuthToken(){} // RVA: 0x1CB66D0
        public void SetOverrideDecryptionKey(){} // RVA: 0x1CB6750
        public void InternalSetActiveTrack(){} // RVA: 0x1CB67D0
        public void InternalIsChangedTracks(){} // RVA: 0x1CB6870
        public void InternalGetTrackCount(){} // RVA: 0x1CB6900
        public void InternalGetTrackInfo(){} // RVA: 0x1CB6990
        public void InternalIsChangedTextCue(){} // RVA: 0x1CB6D70
        public void InternalGetCurrentTextCue(){} // RVA: 0x1CB6E00
        public void InitialisePlatform(){} // RVA: 0x1CB6ED0
        public void DeinitPlatform(){} // RVA: 0x1CB7250
        public void .cctor(){} // RVA: 0x1CB72B0
    }

    public class WindowsUWP
    {
    }

}