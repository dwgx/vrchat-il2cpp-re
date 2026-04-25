// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 66
// Methods: 1112

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class Android : Object
    {
        public int Default_MinBufferTimeMs;
        public int Default_MaxBufferTimeMs;
        public int Default_BufferForPlaybackMs;
        public int Default_BufferForPlaybackAfterRebufferMs;
    }

    public class ApplyToBase : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer Player; // 0x20
        public bool AutomaticStereoPacking; // 0x28
        public 0x6B274BB8 OverrideStereoPacking; // 0x2C
        public bool StereoRedGreenTint; // 0x30
        public bool _isDirty; // 0x31

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Player(){} // RVA: 0x7FFAC47CAE30
        public void get_AutomaticStereoPacking(){} // RVA: 0x7FFAC30F6BA0
        public void set_AutomaticStereoPacking(){} // RVA: 0x7FFAC47CAE40
        public void get_OverrideStereoPacking(){} // RVA: 0x7FFAC3C891D0
        public void set_OverrideStereoPacking(){} // RVA: 0x7FFAC47CAE50
        public void get_StereoRedGreenTint(){} // RVA: 0x7FFAC2F47450
        public void set_StereoRedGreenTint(){} // RVA: 0x7FFAC47CAE60
        public void Awake(){} // RVA: 0x7FFAC47CAE70
        public void ChangeMediaPlayer(){} // RVA: 0x7FFAC47CAE80
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFAC47CB1F0
        public void ForceUpdate(){} // RVA: 0x7FFAC47CB210
        public void Start(){} // RVA: 0x7FFAC47CB290
        public void OnEnable(){} // RVA: 0x7FFAC47CB2D0
        public void OnDisable(){} // RVA: 0x7FFAC47CB300
        public void OnDestroy(){} // RVA: 0x7FFAC47CB320
        public void SaveProperties(){} // RVA: 0x7FFAC2F21310
        public void RestoreProperties(){} // RVA: 0x7FFAC2F21310
        public void Apply(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
    }

    public class ApplyToMaterial : ApplyToBase
    {
        public UnityEngine.Texture2D DefaultTexture; // 0x38
        public UnityEngine.Material Material; // 0x40
        public string TexturePropertyName; // 0x48
        public UnityEngine.Vector2 Offset; // 0x50
        public UnityEngine.Vector2 Scale; // 0x58
        public UnityEngine.Texture _lastTextureApplied; // 0x60
        public RenderHeads.Media.AVProVideo.LazyShaderProperty _propTexture; // 0x68
        public UnityEngine.Texture _originalTexture; // 0x78
        public UnityEngine.Vector2 _originalScale; // 0x80
        public UnityEngine.Vector2 _originalOffset; // 0x88

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFAC31D0140
        public void set_DefaultTexture(){} // RVA: 0x7FFAC47B4BF0
        public void get_Material(){} // RVA: 0x7FFAC2F9E740
        public void set_Material(){} // RVA: 0x7FFAC47B4D60
        public void get_TexturePropertyName(){} // RVA: 0x7FFAC2F9C730
        public void set_TexturePropertyName(){} // RVA: 0x7FFAC47B4ED0
        public void get_Offset(){} // RVA: 0x7FFAC47B5050
        public void set_Offset(){} // RVA: 0x7FFAC47B5070
        public void get_Scale(){} // RVA: 0x7FFAC47B50C0
        public void set_Scale(){} // RVA: 0x7FFAC47B50E0
        public void LateUpdate(){} // RVA: 0x7FFAC30FEBD0
        public void Apply(){} // RVA: 0x7FFAC47B5130
        public void ApplyMapping(){} // RVA: 0x7FFAC47B56C0
        public void SaveProperties(){} // RVA: 0x7FFAC47B5DB0
        public void RestoreProperties(){} // RVA: 0x7FFAC47B6100
        public void .ctor(){} // RVA: 0x7FFAC47B62E0
    }

    public class ApplyToMesh : ApplyToBase
    {
        public UnityEngine.Texture2D DefaultTexture; // 0x38
        public UnityEngine.Renderer MeshRenderer; // 0x40
        public int MaterialIndex; // 0x48
        public string TexturePropertyName; // 0x50
        public UnityEngine.Vector2 Offset; // 0x58
        public UnityEngine.Vector2 Scale; // 0x60
        public UnityEngine.Texture _lastTextureApplied; // 0x68
        public RenderHeads.Media.AVProVideo.LazyShaderProperty _propTexture; // 0x70

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFAC31D0140
        public void set_DefaultTexture(){} // RVA: 0x7FFAC47B64C0
        public void get_MeshRenderer(){} // RVA: 0x7FFAC2F9E740
        public void set_MeshRenderer(){} // RVA: 0x7FFAC47B6640
        public void get_MaterialIndex(){} // RVA: 0x7FFAC2FC20C0
        public void set_MaterialIndex(){} // RVA: 0x7FFAC2FC20D0
        public void ChangeDefaultTexture(){} // RVA: 0x7FFAC47B64C0
        public void ChangeRenderer(){} // RVA: 0x7FFAC47B6650
        public void get_TexturePropertyName(){} // RVA: 0x7FFAC2FC20E0
        public void set_TexturePropertyName(){} // RVA: 0x7FFAC47B68E0
        public void get_Offset(){} // RVA: 0x7FFAC47B50C0
        public void set_Offset(){} // RVA: 0x7FFAC47B50E0
        public void get_Scale(){} // RVA: 0x7FFAC47B6A60
        public void set_Scale(){} // RVA: 0x7FFAC47B6A80
        public void LateUpdate(){} // RVA: 0x7FFAC30FEBD0
        public void Apply(){} // RVA: 0x7FFAC47B6AD0
        public void ApplyMapping(){} // RVA: 0x7FFAC47B7070
        public void OnEnable(){} // RVA: 0x7FFAC47B77C0
        public void OnDisable(){} // RVA: 0x7FFAC47B7AC0
        public void .ctor(){} // RVA: 0x7FFAC47B7AF0
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        public int Channel;
        public float[] _channels; // 0x20

        // ── Methods ──
        public void get_Channel(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Channel(){} // RVA: 0x7FFAC2F4F0D0
        public void Reset(){} // RVA: 0x7FFAC47B7C40
        public void ChangeChannelCount(){} // RVA: 0x7FFAC47B7D00
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC47B7E50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioOutput : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer Player; // 0x20
        public 0x6B273668 OutputMode; // 0x28
        public int ChannelMask; // 0x2C
        public bool _supportPositionalAudio; // 0x30
        public UnityEngine.AudioSource _audioSource; // 0x38

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Player(){} // RVA: 0x7FFAC47B8040
        public void get_OutputMode(){} // RVA: 0x7FFAC32EC4C0
        public void set_OutputMode(){} // RVA: 0x7FFAC369A6E0
        public void get_ChannelMask(){} // RVA: 0x7FFAC3C891D0
        public void set_ChannelMask(){} // RVA: 0x7FFAC45B6490
        public void Awake(){} // RVA: 0x7FFAC47B8050
        public void Start(){} // RVA: 0x7FFAC47B80E0
        public void OnAudioConfigurationChanged(){} // RVA: 0x7FFAC47B8170
        public void OnDestroy(){} // RVA: 0x7FFAC47B82C0
        public void Update(){} // RVA: 0x7FFAC47B82D0
        public void GetAudioSource(){} // RVA: 0x7FFAC31D0140
        public void ChangeMediaPlayer(){} // RVA: 0x7FFAC47B8410
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFAC47B8B20
        public void ApplyAudioSettings(){} // RVA: 0x7FFAC2F21310
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC47B8BE0
        public void .ctor(){} // RVA: 0x7FFAC47B8DB0
    }

    public class AudioOutputManager : Object
    {
        public RenderHeads.Media.AVProVideo.AudioOutputManager Instance;
        public System.Collections.Generic.Dictionary`2<RenderHeads.Media.AVProVideo.MediaPlayer,PlayerInstance> _instances; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC47CB330
        public void .ctor(){} // RVA: 0x7FFAC47CB4B0
        public void RequestAudio(){} // RVA: 0x7FFAC47CB570
        public void ZeroAudio(){} // RVA: 0x7FFAC47CBF00
        public void GrabAudio(){} // RVA: 0x7FFAC47CBF40
    }

    public class AudioTrack : TrackBase
    {
        public int Bitrate; // 0x38
        public int ChannelCount; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E2CA0 | overloaded x2
        public void get_Bitrate(){} // RVA: 0x7FFAC358A870
        public void set_Bitrate(){} // RVA: 0x7FFAC3588350
        public void get_ChannelCount(){} // RVA: 0x7FFAC33BD4A0
        public void set_ChannelCount(){} // RVA: 0x7FFAC47E2CD0
    }

    public class AudioTracks : TrackCollection`1
    {
        public object TrackType;

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC47E2BF0
    }

    public class AuthData : Object
    {
        public string URL; // 0x10
        public string Token; // 0x18
        public byte[] KeyBytes; // 0x20

        // ── Methods ──
        public void get_URL(){} // RVA: 0x7FFAC2F3C380
        public void set_URL(){} // RVA: 0x7FFAC2F22E30
        public void get_Token(){} // RVA: 0x7FFAC2F247C0
        public void set_Token(){} // RVA: 0x7FFAC2F87E80
        public void get_KeyBytes(){} // RVA: 0x7FFAC2F4F0C0
        public void set_KeyBytes(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC47DD240
        public void Clear(){} // RVA: 0x7FFAC47DD240
        public void get_KeyBase64(){} // RVA: 0x7FFAC47DD390
        public void set_KeyBase64(){} // RVA: 0x7FFAC47DD490
    }

    public class BaseMediaPlayer : Object
    {
        public string _playerDescription; // 0x10
        public 0x6B274E20 _lastError; // 0x18
        public 0x6B17BF70 _defaultTextureFilterMode; // 0x1C
        public 0x6B17BFC8 _defaultTextureWrapMode; // 0x20
        public int _defaultTextureAnisoLevel; // 0x24
        public RenderHeads.Media.AVProVideo.MediaHints _mediaHints; // 0x28
        public RenderHeads.Media.AVProVideo.TimeRanges _seekableTimes; // 0x38
        public RenderHeads.Media.AVProVideo.TimeRanges _bufferedTimes; // 0x40
        public float _displayRateTimer; // 0x48
        public int _displayRateLastFrameCount; // 0x4C
        public float _displayRate; // 0x50
        public float _stallDetectionTimer; // 0x54
        public int _stallDetectionFrame; // 0x58
        public int _stallDetectionGuard; // 0x5C
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.Subtitle> _subtitles; // 0x60
        public RenderHeads.Media.AVProVideo.Subtitle _currentSubtitle; // 0x68
        public int _unityFrameCountBufferedDisplayGuard; // 0x70
        public RenderHeads.Media.AVProVideo.PlaybackQualityStats _playbackQualityStats; // 0x78
        public RenderHeads.Media.AVProVideo.TextCue _currentTextCue; // 0x80
        public RenderHeads.Media.AVProVideo.VideoTracks _videoTracks; // 0x88
        public RenderHeads.Media.AVProVideo.AudioTracks _audioTracks; // 0x90
        public RenderHeads.Media.AVProVideo.TextTracks _textTracks; // 0x98
        public RenderHeads.Media.AVProVideo.TrackCollection[] _trackCollections; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47CC060
        public void GetVersion(){} // RVA: 0x7FFAC2C58E90
        public void GetExpectedVersion(){} // RVA: 0x7FFAC2C58E90
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFAC2F21320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFAC2F21320
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFAC2F21320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFAC2F21320
        public void CloseMedia(){} // RVA: 0x7FFAC47CC5F0
        public void SetLooping(){} // RVA: 0x7FFAC2C71060
        public void IsLooping(){} // RVA: 0x7FFAC2C59D00
        public void HasMetaData(){} // RVA: 0x7FFAC2C59D00
        public void CanPlay(){} // RVA: 0x7FFAC2C59D00
        public void Play(){} // RVA: 0x7FFAC2C70980
        public void Pause(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Rewind(){} // RVA: 0x7FFAC47CC6E0
        public void Seek(){} // RVA: 0x7FFAC2C72080
        public void SeekFast(){} // RVA: 0x7FFAC2C72080
        public void SeekWithTolerance(){} // RVA: 0x7FFAC47CC700
        public void GetCurrentTime(){} // RVA: 0x7FFAC2C5EB60
        public void GetProgramDateTime(){} // RVA: 0x7FFAC47CC720
        public void GetPlaybackRate(){} // RVA: 0x7FFAC2C6D880
        public void SetPlaybackRate(){} // RVA: 0x7FFAC2C7E480
        public void GetDuration(){} // RVA: 0x7FFAC2C5EB60
        public void GetVideoWidth(){} // RVA: 0x7FFAC2C59960
        public void GetVideoHeight(){} // RVA: 0x7FFAC2C59960
        public void GetVideoFrameRate(){} // RVA: 0x7FFAC2C6D880
        public void GetVideoDisplayRate(){} // RVA: 0x7FFAC2F89460
        public void HasAudio(){} // RVA: 0x7FFAC2C59D00
        public void HasVideo(){} // RVA: 0x7FFAC2C59D00
        public void IsVideoStereo(){} // RVA: 0x7FFAC47CC780
        public void IsSeeking(){} // RVA: 0x7FFAC2C59D00
        public void IsPlaying(){} // RVA: 0x7FFAC2C59D00
        public void IsPaused(){} // RVA: 0x7FFAC2C59D00
        public void IsFinished(){} // RVA: 0x7FFAC2C59D00
        public void IsBuffering(){} // RVA: 0x7FFAC2C59D00
        public void WaitForNextFrame(){} // RVA: 0x7FFAC2F21320
        public void GetTextureCount(){} // RVA: 0x7FFAC3013AF0
        public void GetTexture(){} // RVA: 0x7FFAC2C67DE0
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC2C59960
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFAC3006850
        public void GetTextureTimeStamp(){} // RVA: 0x7FFAC47CC7B0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC2C59D00
        public void GetTextureTransform(){} // RVA: 0x7FFAC47CC7C0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFAC3FB3CE0
        public void GetYpCbCrTransform(){} // RVA: 0x7FFAC47CC830
        public void GetTextureStereoPacking(){} // RVA: 0x7FFAC47CC890
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFAC2C59960
        public void GetTextureTransparency(){} // RVA: 0x7FFAC32EC4C0
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFAC47CC8C0
        public void MuteAudio(){} // RVA: 0x7FFAC2C71060
        public void IsMuted(){} // RVA: 0x7FFAC2C59D00
        public void SetVolume(){} // RVA: 0x7FFAC2C7E480
        public void SetBalance(){} // RVA: 0x7FFAC2F21310
        public void GetVolume(){} // RVA: 0x7FFAC2C6D880
        public void GetBalance(){} // RVA: 0x7FFAC37432E0
        public void GetAudioChannelCount(){} // RVA: 0x7FFAC32BD0E0
        public void GetAudioChannelMask(){} // RVA: 0x7FFAC34F9180
        public void GrabAudio(){} // RVA: 0x7FFAC34F9180
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFAC34F9180
        public void AudioConfigurationChanged(){} // RVA: 0x7FFAC2F21310
        public void SetAudioHeadRotation(){} // RVA: 0x7FFAC2F21310
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFAC2F21310
        public void SetAudioChannelMode(){} // RVA: 0x7FFAC2F21310
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFAC2F21310
        public void SetAudioFocusProperties(){} // RVA: 0x7FFAC2F21310
        public void SetAudioFocusRotation(){} // RVA: 0x7FFAC2F21310
        public void ResetAudioFocus(){} // RVA: 0x7FFAC2F21310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7FFAC47CC900
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFAC2F21310
        public void IsMediaCachingSupported(){} // RVA: 0x7FFAC2F21320
        public void AddMediaToCache(){} // RVA: 0x7FFAC2F21310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7FFAC2F21310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7FFAC2F21310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7FFAC2F21310
        public void RemoveMediaFromCache(){} // RVA: 0x7FFAC2F21310
        public void GetCachedMediaStatus(){} // RVA: 0x7FFAC34F9180
        public void IsExternalPlaybackSupported(){} // RVA: 0x7FFAC2F21320
        public void IsExternalPlaybackActive(){} // RVA: 0x7FFAC2F21320
        public void SetAllowsExternalPlayback(){} // RVA: 0x7FFAC2F21310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7FFAC2F21310
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFAC2F21310
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFAC2F21310
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void BeginRender(){} // RVA: 0x7FFAC2F21310
        public void Render(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void GetDecoderPerformance(){} // RVA: 0x7FFAC2F21320
        public void EndUpdate(){} // RVA: 0x7FFAC2F21310
        public void GetNativePlayerHandle(){} // RVA: 0x7FFAC34F9180
        public void GetLastError(){} // RVA: 0x7FFAC47CC910
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFAC34F9180
        public void GetPlayerDescription(){} // RVA: 0x7FFAC2F3C380
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFAC3006850
        public void GetSeekableTimes(){} // RVA: 0x7FFAC31D0140
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void GetTextureProperties(){} // RVA: 0x7FFAC47CC920
        public void SetTextureProperties(){} // RVA: 0x7FFAC47CC940
        public void ApplyTextureProperties(){} // RVA: 0x7FFAC47CC9D0
        public void UpdateDisplayFrameRate(){} // RVA: 0x7FFAC47CCB80
        public void IsExpectingNewVideoFrame(){} // RVA: 0x7FFAC47CCC50
        public void IsPlaybackStalled(){} // RVA: 0x7FFAC47CCD50
        public void LoadSubtitlesSRT(){} // RVA: 0x7FFAC47CCF80
        public void UpdateSubtitles(){} // RVA: 0x7FFAC47CD140
        public void GetSubtitleIndex(){} // RVA: 0x7FFAC47CD2A0
        public void GetSubtitleText(){} // RVA: 0x7FFAC47CD2C0
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void GetCurrentTimeFrames(){} // RVA: 0x7FFAC47CD340
        public void GetDurationFrames(){} // RVA: 0x7FFAC47CD430
        public void GetMaxFrameNumber(){} // RVA: 0x7FFAC47CD4F0
        public void SeekToFrameRelative(){} // RVA: 0x7FFAC47CD510
        public void SeekToFrame(){} // RVA: 0x7FFAC47CD660
        public void UpdateBufferedDisplay(){} // RVA: 0x7FFAC47CD770
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFAC34F9180
        public void GetBufferedFramesState(){} // RVA: 0x7FFAC47CD840
        public void SetSlaves(){} // RVA: 0x7FFAC2F21310
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFAC2F21310
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFAC2F21310
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void UpdateTextCue(){} // RVA: 0x7FFAC47CD860
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFAC2C59D00
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFAC2C58E90
        public void GetVideoTracks(){} // RVA: 0x7FFAC2F60010
        public void GetAudioTracks(){} // RVA: 0x7FFAC32EF640
        public void GetTextTracks(){} // RVA: 0x7FFAC354DFB0
        public void GetActiveVideoTrack(){} // RVA: 0x7FFAC47CDA20
        public void GetActiveAudioTrack(){} // RVA: 0x7FFAC47CDA70
        public void GetActiveTextTrack(){} // RVA: 0x7FFAC47CDAC0
        public void SetActiveVideoTrack(){} // RVA: 0x7FFAC47CDB10
        public void SetActiveAudioTrack(){} // RVA: 0x7FFAC47CDB30
        public void SetActiveTextTrack(){} // RVA: 0x7FFAC47CDB50
        public void InternalIsChangedTracks(){} // RVA: 0x7FFAC2C5A310
        public void InternalGetTrackCount(){} // RVA: 0x7FFAC2C600D0
        public void InternalSetActiveTrack(){}
        public void InternalGetTrackInfo(){}
        public void InitTracks(){} // RVA: 0x7FFAC47CDB70
        public void UpdateTracks(){} // RVA: 0x7FFAC47CDD00
        public void PopulateTrackCollection(){} // RVA: 0x7FFAC47CDDB0
        public void SetActiveTrack(){} // RVA: 0x7FFAC47CDFA0
    }

    public class BufferedFramesState : ValueType
    {
        public int freeFrameCount; // 0x10
        public int bufferedFrameCount; // 0x14
        public long minTimeStamp; // 0x18
        public long maxTimeStamp; // 0x20
        public int prerolledCount; // 0x28
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer Player; // 0x20
        public 0x6B27F8A0 ScaleMode; // 0x28
        public UnityEngine.Color Color; // 0x2C
        public bool AllowTransparency; // 0x3C
        public bool UseDepth; // 0x3D
        public int Depth; // 0x40
        public bool IsAreaFullScreen; // 0x44
        public float AreaX; // 0x48
        public float AreaY; // 0x4C
        public float AreaWidth; // 0x50
        public float AreaHeight; // 0x54
        public bool ShowAreaInEditor; // 0x58
        public UnityEngine.Shader _shaderAlphaPacking;
        public UnityEngine.Material _material; // 0x60

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Player(){} // RVA: 0x7FFAC47B8E10
        public void get_ScaleMode(){} // RVA: 0x7FFAC32EC4C0
        public void set_ScaleMode(){} // RVA: 0x7FFAC369A6E0
        public void get_Color(){} // RVA: 0x7FFAC47B8F40
        public void set_Color(){} // RVA: 0x7FFAC47B8F50
        public void get_AllowTransparency(){} // RVA: 0x7FFAC30864E0
        public void set_AllowTransparency(){} // RVA: 0x7FFAC30864F0
        public void get_UseDepth(){} // RVA: 0x7FFAC3F707D0
        public void set_UseDepth(){} // RVA: 0x7FFAC47B8F60
        public void get_Depth(){} // RVA: 0x7FFAC2FC2080
        public void set_Depth(){} // RVA: 0x7FFAC2FC2090
        public void get_IsAreaFullScreen(){} // RVA: 0x7FFAC45A8350
        public void set_IsAreaFullScreen(){} // RVA: 0x7FFAC45A8340
        public void get_AreaX(){} // RVA: 0x7FFAC45C0DE0
        public void set_AreaX(){} // RVA: 0x7FFAC45C0F70
        public void get_AreaY(){} // RVA: 0x7FFAC3735280
        public void set_AreaY(){} // RVA: 0x7FFAC37346A0
        public void get_AreaWidth(){} // RVA: 0x7FFAC2F89460
        public void set_AreaWidth(){} // RVA: 0x7FFAC2F89470
        public void get_AreaHeight(){} // RVA: 0x7FFAC3391600
        public void set_AreaHeight(){} // RVA: 0x7FFAC33914E0
        public void get_ShowAreaInEditor(){} // RVA: 0x7FFAC313F600
        public void set_ShowAreaInEditor(){} // RVA: 0x7FFAC3892770
        public void Start(){} // RVA: 0x7FFAC47B8F70
        public void Update(){} // RVA: 0x7FFAC47B9210
        public void OnDestroy(){} // RVA: 0x7FFAC47B92F0
        public void GetRequiredShader(){} // RVA: 0x7FFAC47B9430
        public void SetupMaterial(){} // RVA: 0x7FFAC47B97E0
        public void OnGUI(){} // RVA: 0x7FFAC47B9C30
        public void GetAreaRect(){} // RVA: 0x7FFAC47BA3E0
        public void .ctor(){} // RVA: 0x7FFAC47BA660
    }

    public class DisplayUGUI : MaskableGraphic
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer Player; // 0xE0
        public UnityEngine.Texture DefaultTexture; // 0xE8
        public UnityEngine.Rect UVRect; // 0xF0
        public bool ApplyNativeSize; // 0x100
        public 0x6B27F8A0 ScaleMode; // 0x104
        public bool NoDefaultDisplay; // 0x108
        public bool DisplayInEditor; // 0x109
        public int mainTexture; // 0x10C
        public int CurrentMediaPlayer; // 0x110
        public 0x6B274E78 uvRect; // 0x114
        public bool _flipY; // 0x118
        public UnityEngine.Texture _lastTexture; // 0x120
        public UnityEngine.Shader _shaderStereoPacking;
        public UnityEngine.Shader _shaderAlphaPacking; // 0x8
        public UnityEngine.Shader _shaderAndroidOES; // 0x10
        public UnityEngine.Shader _shaderAndroidOESAlphaPacking; // 0x18
        public bool _isUserMaterial; // 0x128
        public UnityEngine.Material _material; // 0x130
        public System.Collections.Generic.List`1<UnityEngine.UIVertex> _vertices; // 0x138
        public System.Collections.Generic.List`1<int> QuadIndices; // 0x20

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFAC2FA2900
        public void set_Player(){} // RVA: 0x7FFAC47AFF60
        public void get_DefaultTexture(){} // RVA: 0x7FFAC2FA2970
        public void set_DefaultTexture(){} // RVA: 0x7FFAC47AFF70
        public void get_UVRect(){} // RVA: 0x7FFAC47B00F0
        public void set_UVRect(){} // RVA: 0x7FFAC47B0100
        public void get_ApplyNativeSize(){} // RVA: 0x7FFAC3C8B9C0
        public void set_ApplyNativeSize(){} // RVA: 0x7FFAC3C8DFF0
        public void get_ScaleMode(){} // RVA: 0x7FFAC47B0110
        public void set_ScaleMode(){} // RVA: 0x7FFAC451E020
        public void get_NoDefaultDisplay(){} // RVA: 0x7FFAC4196030
        public void set_NoDefaultDisplay(){} // RVA: 0x7FFAC4196040
        public void get_DisplayInEditor(){} // RVA: 0x7FFAC45CA6A0
        public void set_DisplayInEditor(){} // RVA: 0x7FFAC45C9FB0
        public void Awake(){} // RVA: 0x7FFAC47B0120
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFAC47B0270
        public void ChangeMediaPlayer(){} // RVA: 0x7FFAC47B03E0
        public void EnsureShader(){} // RVA: 0x7FFAC47B0760
        public void EnsureAlphaPackingShader(){} // RVA: 0x7FFAC47B0920
        public void EnsureStereoPackingShader(){} // RVA: 0x7FFAC47B0A10
        public void EnsureAndroidOESShader(){} // RVA: 0x7FFAC47B0B00
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x7FFAC47B0BF0
        public void Start(){} // RVA: 0x7FFAC47B0CE0
        public void OnDestroy(){} // RVA: 0x7FFAC47B0E90
        public void GetRequiredShader(){} // RVA: 0x7FFAC47B1020
        public void get_mainTexture(){} // RVA: 0x7FFAC47B1620
        public void HasValidTexture(){} // RVA: 0x7FFAC47B1820
        public void UpdateInternalMaterial(){} // RVA: 0x7FFAC47B1A80
        public void LateUpdate(){} // RVA: 0x7FFAC47B1F10
        public void get_CurrentMediaPlayer(){} // RVA: 0x7FFAC2FA2900
        public void set_CurrentMediaPlayer(){} // RVA: 0x7FFAC47B25A0
        public void get_uvRect(){} // RVA: 0x7FFAC47B00F0
        public void set_uvRect(){} // RVA: 0x7FFAC47B2730
        public void SetNativeSize(){} // RVA: 0x7FFAC47B27A0
        public void OnPopulateMesh(){} // RVA: 0x7FFAC47B2C00
        public void _OnFillVBO(){} // RVA: 0x7FFAC47B2CB0
        public void GetDrawingDimensions(){} // RVA: 0x7FFAC47B3170
        public void .ctor(){} // RVA: 0x7FFAC47B3930
        public void .cctor(){} // RVA: 0x7FFAC47B3AB0
    }

    public class Helper : Object
    {
        public string AVProVideoVersion;
        public string UnityBaseTextureName;
        public string UnityBaseTextureName_URP;
        public string UnityBaseTextureName_HDRP;
        public double SecondsToHNS;
        public double MilliSecondsToHNS;
        public UnityEngine.Matrix4x4 PortraitMatrix;
        public UnityEngine.Matrix4x4 PortraitFlippedMatrix; // 0x40
        public UnityEngine.Matrix4x4 LandscapeFlippedMatrix; // 0x80

        // ── Methods ──
        public void GetPath(){} // RVA: 0x7FFAC47CE5F0
        public void GetFilePath(){} // RVA: 0x7FFAC47CE770
        public void GetFriendlyResolutionName(){} // RVA: 0x7FFAC47CE9C0
        public void GetErrorMessage(){} // RVA: 0x7FFAC47CED30
        public void GetPlatformName(){} // RVA: 0x7FFAC47CEEC0
        public void GetPlatformNames(){} // RVA: 0x7FFAC47CEF70
        public void LogInfo(){} // RVA: 0x7FFAC47CF380
        public void GetUnityAudioSampleRate(){} // RVA: 0x7FFAC47CF4E0
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x7FFAC47CF590
        public void GetTimelineRange(){} // RVA: 0x7FFAC47CF670
        public void GetTimeString(){} // RVA: 0x7FFAC47CF6D0
        public void GetOrientation(){} // RVA: 0x7FFAC47CFB30
        public void GetMatrixForOrientation(){} // RVA: 0x7FFAC47CFD40
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x7FFAC47CFF60
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x7FFAC47D0000
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x7FFAC47D0040
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7FFAC47D0190
        public void GetShortPathName(){} // RVA: 0x7FFAC47D02F0
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x7FFAC47D03E0
        public void GetReadableTexture(){} // RVA: 0x7FFAC47D0BD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC47D0EF0
    }

    public class HttpHeader : ValueType
    {
        public string name; // 0x10
        public string value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void IsComplete(){} // RVA: 0x7FFAC47E2D10
        public void ToValidatedString(){} // RVA: 0x7FFAC47E2D40
        public void IsValid(){} // RVA: 0x7FFAC47E2F40 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFAC47E2EE0
    }

    public class HttpHeaderData : Object
    {
        public System.Collections.Generic.List`1<RenderHeads.Media.AVProVideo.HttpHeader> Item; // 0x10

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFAC47E2F80
        public void get_Item(){} // RVA: 0x7FFAC47E3060
        public void Clear(){} // RVA: 0x7FFAC47E30F0
        public void Add(){} // RVA: 0x7FFAC47E3160
        public void IsModified(){} // RVA: 0x7FFAC47E3290
        public void ToValidatedString(){} // RVA: 0x7FFAC47E32E0
        public void .ctor(){} // RVA: 0x7FFAC47E3510
    }

    public class IAudioTracks
    {
        // ── Methods ──
        public void GetAudioTracks(){} // RVA: 0x7FFAC2C58E90
        public void GetActiveAudioTrack(){} // RVA: 0x7FFAC2C58E90
        public void SetActiveAudioTrack(){} // RVA: 0x7FFAC2C70A40
    }

    public class IBufferedDisplay
    {
        // ── Methods ──
        public void UpdateBufferedDisplay(){} // RVA: 0x7FFAC2C58E90
        public void GetBufferedFramesState(){}
        public void SetSlaves(){} // RVA: 0x7FFAC2C70A40
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFAC2C72BC0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFAC2C71060
    }

    public class IMediaCache
    {
        // ── Methods ──
        public void IsMediaCachingSupported(){} // RVA: 0x7FFAC2C59D00
        public void AddMediaToCache(){} // RVA: 0x7FFAC2C7AF60
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7FFAC2C70A40
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7FFAC2C70A40
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7FFAC2C70A40
        public void RemoveMediaFromCache(){} // RVA: 0x7FFAC2C70A40
        public void GetCachedMediaStatus(){} // RVA: 0x7FFAC2C637A0
    }

    public class IMediaControl
    {
        // ── Methods ──
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFAC2C59F60
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFAC2C5A7E0
        public void AddChunkToMediaBuffer(){}
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFAC2C59D00
        public void CloseMedia(){} // RVA: 0x7FFAC2C70980
        public void SetLooping(){} // RVA: 0x7FFAC2C71060
        public void IsLooping(){} // RVA: 0x7FFAC2C59D00
        public void HasMetaData(){} // RVA: 0x7FFAC2C59D00
        public void CanPlay(){} // RVA: 0x7FFAC2C59D00
        public void IsPlaying(){} // RVA: 0x7FFAC2C59D00
        public void IsSeeking(){} // RVA: 0x7FFAC2C59D00
        public void IsPaused(){} // RVA: 0x7FFAC2C59D00
        public void IsFinished(){} // RVA: 0x7FFAC2C59D00
        public void IsBuffering(){} // RVA: 0x7FFAC2C59D00
        public void Play(){} // RVA: 0x7FFAC2C70980
        public void Pause(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Rewind(){} // RVA: 0x7FFAC2C70980
        public void Seek(){} // RVA: 0x7FFAC2C72080
        public void SeekFast(){} // RVA: 0x7FFAC2C72080
        public void SeekWithTolerance(){} // RVA: 0x7FFAC2E8DC40
        public void SeekToFrame(){} // RVA: 0x7FFAC2C74400
        public void SeekToFrameRelative(){} // RVA: 0x7FFAC2C74400
        public void GetCurrentTime(){} // RVA: 0x7FFAC2C5EB60
        public void GetCurrentTimeFrames(){}
        public void GetProgramDateTime(){} // RVA: 0x7FFAC2C58E90
        public void GetPlaybackRate(){} // RVA: 0x7FFAC2C6D880
        public void SetPlaybackRate(){} // RVA: 0x7FFAC2C7E480
        public void MuteAudio(){} // RVA: 0x7FFAC2C71060
        public void IsMuted(){} // RVA: 0x7FFAC2C59D00
        public void SetVolume(){} // RVA: 0x7FFAC2C7E480
        public void SetBalance(){} // RVA: 0x7FFAC2C7E480
        public void GetVolume(){} // RVA: 0x7FFAC2C6D880
        public void GetBalance(){} // RVA: 0x7FFAC2C6D880
        public void GetSeekableTimes(){} // RVA: 0x7FFAC2C58E90
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2C58E90
        public void GetLastError(){} // RVA: 0x7FFAC2C59960
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFAC2C58E90
        public void SetTextureProperties(){}
        public void GetTextureProperties(){} // RVA: 0x7FFAC2C7AF60
        public void GrabAudio(){}
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFAC2C59960
        public void GetAudioChannelCount(){} // RVA: 0x7FFAC2C59960
        public void GetAudioChannelMask(){} // RVA: 0x7FFAC2C59960
        public void AudioConfigurationChanged(){} // RVA: 0x7FFAC2C71060
        public void SetAudioChannelMode(){} // RVA: 0x7FFAC2C70ED0
        public void SetAudioHeadRotation(){} // RVA: 0x7FFAC2C70A40
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFAC2C70980
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFAC2C71060
        public void SetAudioFocusProperties(){}
        public void SetAudioFocusRotation(){} // RVA: 0x7FFAC2C70A40
        public void ResetAudioFocus(){} // RVA: 0x7FFAC2C70980
        public void WaitForNextFrame(){} // RVA: 0x7FFAC2C5C920
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFAC2C71060
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFAC2C70A40
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFAC2C70A40
        public void IsExternalPlaybackActive(){} // RVA: 0x7FFAC2C59D00
        public void SetAllowsExternalPlayback(){} // RVA: 0x7FFAC2C71060
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IMediaInfo
    {
        // ── Methods ──
        public void GetDuration(){} // RVA: 0x7FFAC2C5EB60
        public void GetDurationFrames(){}
        public void GetMaxFrameNumber(){}
        public void GetVideoWidth(){} // RVA: 0x7FFAC2C59960
        public void GetVideoHeight(){} // RVA: 0x7FFAC2C59960
        public void GetVideoFrameRate(){} // RVA: 0x7FFAC2C6D880
        public void GetVideoDisplayRate(){} // RVA: 0x7FFAC2C6D880
        public void HasVideo(){} // RVA: 0x7FFAC2C59D00
        public void HasAudio(){} // RVA: 0x7FFAC2C59D00
        public void GetPlayerDescription(){} // RVA: 0x7FFAC2C58E90
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFAC2C59D00
        public void IsPlaybackStalled(){} // RVA: 0x7FFAC2C59D00
        public void GetTextureTransform(){} // RVA: 0x7FFAC2C58E90
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7FFAC2C58E90
        public void IsExternalPlaybackSupported(){} // RVA: 0x7FFAC2C59D00
        public void GetDecoderPerformance(){}
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC2C70980
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void EndUpdate(){} // RVA: 0x7FFAC2C70980
        public void BeginRender(){} // RVA: 0x7FFAC2C70980
        public void Render(){} // RVA: 0x7FFAC2C70980
        public void GetNativePlayerHandle(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMediaSubtitles
    {
        // ── Methods ──
        public void LoadSubtitlesSRT(){} // RVA: 0x7FFAC2C59F60
        public void GetSubtitleIndex(){} // RVA: 0x7FFAC2C59960
        public void GetSubtitleText(){} // RVA: 0x7FFAC2C58E90
    }

    public class ITextTracks
    {
        // ── Methods ──
        public void GetTextTracks(){} // RVA: 0x7FFAC2C58E90
        public void GetActiveTextTrack(){} // RVA: 0x7FFAC2C58E90
        public void SetActiveTextTrack(){} // RVA: 0x7FFAC2C70A40
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC2C58E90
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0x7FFAC2C59960
        public void GetTexture(){} // RVA: 0x7FFAC2C67DE0
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC2C59960
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFAC2C59D00
        public void GetTextureTimeStamp(){} // RVA: 0x7FFAC2C58E90
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFAC2C6D880
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC2C59D00
        public void GetTextureStereoPacking(){} // RVA: 0x7FFAC2C59960
        public void GetTextureTransparency(){} // RVA: 0x7FFAC2C59960
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFAC2C59960
        public void GetYpCbCrTransform(){}
    }

    public class IVideoTracks
    {
        // ── Methods ──
        public void GetVideoTracks(){} // RVA: 0x7FFAC2C58E90
        public void GetActiveVideoTrack(){} // RVA: 0x7FFAC2C58E90
        public void SetActiveVideoTrack(){} // RVA: 0x7FFAC2C70A40
    }

    public class KeyAuthData : Object
    {
        public string keyServerToken; // 0x10
        public string overrideDecryptionKeyBase64; // 0x18
        public byte[] overrideDecryptionKey; // 0x20

        // ── Methods ──
        public void IsModified(){} // RVA: 0x7FFAC47E35D0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC47E3600
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC47E3670
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LazyShaderProperty : ValueType
    {
        public string Name; // 0x10
        public int Id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E74F0
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void get_Id(){} // RVA: 0x7FFAC47E7560
    }

    public class MediaCachingOptions : Object
    {
        public double minimumRequiredBitRate; // 0x10
        public UnityEngine.Vector2 minimumRequiredResolution; // 0x18
        public double maximumRequiredBitRate; // 0x20
        public UnityEngine.Vector2 maximumRequiredResolution; // 0x28
        public string title; // 0x30
        public byte[] artwork; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MediaHints : ValueType
    {
        public 0x6B274D18 Default; // 0x10
        public 0x6B274DC8 alphaPacking; // 0x14
        public 0x6B274BB8 stereoPacking; // 0x18
        public RenderHeads.Media.AVProVideo.MediaHints defaultHints;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFAC47D1940
        public void .cctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MediaPath : Object
    {
        public 0x6B274A58 PathType; // 0x10
        public string Path; // 0x18

        // ── Methods ──
        public void get_PathType(){} // RVA: 0x7FFAC2F6E5C0
        public void set_PathType(){} // RVA: 0x7FFAC2F240C0
        public void get_Path(){} // RVA: 0x7FFAC2F247C0
        public void set_Path(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC47D1580 | overloaded x3
        public void GetResolvedFullPath(){} // RVA: 0x7FFAC47D1690
        public void op_Equality(){} // RVA: 0x7FFAC47D1760
        public void op_Inequality(){} // RVA: 0x7FFAC47D1780
        public void Equals(){} // RVA: 0x7FFAC47D17C0
        public void GetHashCode(){} // RVA: 0x7FFAC47D1900
    }

    public class MediaPlayer : MonoBehaviour
    {
        public 0x6B274A00 MediaSource; // 0x20
        public RenderHeads.Media.AVProVideo.MediaReference MediaReference; // 0x28
        public RenderHeads.Media.AVProVideo.MediaPath MediaPath; // 0x30
        public RenderHeads.Media.AVProVideo.MediaHints FallbackMediaHints; // 0x38
        public bool AutoOpen; // 0x44
        public bool AutoStart; // 0x45
        public bool Loop; // 0x46
        public float AudioVolume; // 0x48
        public float AudioBalance; // 0x4C
        public bool AudioMuted; // 0x50
        public UnityEngine.AudioSource AudioSource; // 0x58
        public float PlaybackRate; // 0x60
        public bool UseResampler; // 0x64
        public 0x6B276268 ResampleMode; // 0x68
        public int ResampleBufferSize; // 0x6C
        public RenderHeads.Media.AVProVideo.Resampler FrameResampler; // 0x70
        public 0x6B274ED0 VideoLayoutMapping; // 0x78
        public 0x6B17BF70 TextureFilterMode; // 0x7C
        public 0x6B17BFC8 TextureWrapMode; // 0x80
        public int TextureAnisoLevel; // 0x84
        public bool SideloadSubtitles; // 0x88
        public RenderHeads.Media.AVProVideo.MediaPath SubtitlePath; // 0x90
        public UnityEngine.Transform AudioHeadTransform; // 0x98
        public bool AudioFocusEnabled; // 0xA0
        public UnityEngine.Transform AudioFocusTransform; // 0xA8
        public float AudioFocusWidthDegrees; // 0xB0
        public float AudioFocusOffLevelDB; // 0xB4
        public RenderHeads.Media.AVProVideo.HttpHeaderData HttpHeaders; // 0xB8
        public RenderHeads.Media.AVProVideo.KeyAuthData KeyAuth; // 0xC0
        public RenderHeads.Media.AVProVideo.MediaPlayerEvent Events; // 0xC8
        public int EventMask; // 0xD0
        public bool PauseMediaOnAppPause; // 0xD4
        public bool PlayMediaOnAppUnpause; // 0xD5
        public bool Persistent; // 0xD6
        public 0x6B274F28 ForceFileFormat; // 0xD8
        public RenderHeads.Media.AVProVideo.BaseMediaPlayer Info; // 0xE0
        public RenderHeads.Media.AVProVideo.IMediaControl Control; // 0xE8
        public RenderHeads.Media.AVProVideo.ITextureProducer Player; // 0xF0
        public RenderHeads.Media.AVProVideo.IMediaInfo TextureProducer; // 0xF8
        public RenderHeads.Media.AVProVideo.IMediaPlayer Subtitles; // 0x100
        public RenderHeads.Media.AVProVideo.IMediaSubtitles VideoTracks; // 0x108
        public RenderHeads.Media.AVProVideo.IMediaCache AudioTracks; // 0x110
        public RenderHeads.Media.AVProVideo.IBufferedDisplay TextTracks; // 0x118
        public RenderHeads.Media.AVProVideo.IVideoTracks Cache; // 0x120
        public RenderHeads.Media.AVProVideo.IAudioTracks BufferedDisplay; // 0x128
        public RenderHeads.Media.AVProVideo.ITextTracks MediaOpened; // 0x130
        public System.IDisposable PlatformOptionsWindows; // 0x138
        public bool PlatformOptionsMacOSX; // 0x140
        public bool PlatformOptionsIOS; // 0x141
        public bool PlatformOptionsTVOS; // 0x142
        public UnityEngine.Coroutine PlatformOptionsAndroid; // 0x148
        public bool PlatformOptionsWindowsUWP;
        public bool PlatformOptionsWebGL; // 0x1
        public RenderHeads.Media.AVProVideo.MediaPath _queueSubtitlePath; // 0x150
        public UnityEngine.Coroutine _loadSubtitlesRoutine; // 0x158
        public UnityEngine.Camera _dummyCamera; // 0x8
        public bool enableAVProInProton; // 0x10
        public bool _eventFired_MetaDataReady; // 0x160
        public bool _eventFired_ReadyToPlay; // 0x161
        public bool _eventFired_Started; // 0x162
        public bool _eventFired_FirstFrameReady; // 0x163
        public bool _eventFired_FinishedPlaying; // 0x164
        public bool _eventState_PlaybackBuffering; // 0x165
        public bool _eventState_PlaybackSeeking; // 0x166
        public bool _eventState_PlaybackStalled; // 0x167
        public int _eventState_PreviousWidth; // 0x168
        public int _eventState_PreviousHeight; // 0x16C
        public int _previousSubtitleIndex; // 0x170
        public bool _finishedFrameOpenCheck; // 0x174
        public OptionsWindows _optionsWindows; // 0x178
        public OptionsApple _optionsMacOSX; // 0x180
        public OptionsApple _optionsIOS; // 0x188
        public OptionsApple _optionsTVOS; // 0x190
        public OptionsAndroid _optionsAndroid; // 0x198
        public OptionsWindowsUWP _optionsWindowsUWP; // 0x1A0
        public OptionsWebGL _optionsWebGL; // 0x1A8
        public string m_VideoPath; // 0x1B0
        public 0x6B273CF0 m_VideoLocation; // 0x1B8

        // ── Methods ──
        public void get_MediaSource(){} // RVA: 0x7FFAC30DBBE0
        public void set_MediaSource(){} // RVA: 0x7FFAC35DB7A0
        public void get_MediaReference(){} // RVA: 0x7FFAC2F4F130
        public void set_MediaReference(){} // RVA: 0x7FFAC2F22E90
        public void get_MediaPath(){} // RVA: 0x7FFAC31D95E0
        public void set_MediaPath(){} // RVA: 0x7FFAC2F4F890
        public void get_FallbackMediaHints(){} // RVA: 0x7FFAC2F87F40
        public void set_FallbackMediaHints(){} // RVA: 0x7FFAC2F87F60
        public void get_AutoOpen(){} // RVA: 0x7FFAC45A8350
        public void set_AutoOpen(){} // RVA: 0x7FFAC45A8340
        public void get_AutoStart(){} // RVA: 0x7FFAC47BA6D0
        public void set_AutoStart(){} // RVA: 0x7FFAC47BA6E0
        public void get_Loop(){} // RVA: 0x7FFAC47BA6F0
        public void set_Loop(){} // RVA: 0x7FFAC47BA750
        public void get_AudioVolume(){} // RVA: 0x7FFAC47BA7C0
        public void set_AudioVolume(){} // RVA: 0x7FFAC47BA820
        public void get_AudioBalance(){} // RVA: 0x7FFAC47BA8B0
        public void set_AudioBalance(){} // RVA: 0x7FFAC47BA910
        public void get_AudioMuted(){} // RVA: 0x7FFAC47BA9A0
        public void set_AudioMuted(){} // RVA: 0x7FFAC47BAA00
        public void get_AudioSource(){} // RVA: 0x7FFAC2FE9500
        public void set_AudioSource(){} // RVA: 0x7FFAC2FE9510
        public void get_PlaybackRate(){} // RVA: 0x7FFAC47BAA70
        public void set_PlaybackRate(){} // RVA: 0x7FFAC47BAAD0
        public void get_UseResampler(){} // RVA: 0x7FFAC3F45FE0
        public void set_UseResampler(){} // RVA: 0x7FFAC47BAB40
        public void get_ResampleMode(){} // RVA: 0x7FFAC47BAB50
        public void set_ResampleMode(){} // RVA: 0x7FFAC47BAB60
        public void get_ResampleBufferSize(){} // RVA: 0x7FFAC47BAB70
        public void set_ResampleBufferSize(){} // RVA: 0x7FFAC47BAB80
        public void get_FrameResampler(){} // RVA: 0x7FFAC2FE9590
        public void get_VideoLayoutMapping(){} // RVA: 0x7FFAC4596EF0
        public void set_VideoLayoutMapping(){} // RVA: 0x7FFAC45963A0
        public void get_TextureFilterMode(){} // RVA: 0x7FFAC47BAB90
        public void set_TextureFilterMode(){} // RVA: 0x7FFAC47BAC90
        public void get_TextureWrapMode(){} // RVA: 0x7FFAC47BAD10
        public void set_TextureWrapMode(){} // RVA: 0x7FFAC47BAE10
        public void get_TextureAnisoLevel(){} // RVA: 0x7FFAC47BAE90
        public void set_TextureAnisoLevel(){} // RVA: 0x7FFAC47BAF90
        public void get_SideloadSubtitles(){} // RVA: 0x7FFAC3E003A0
        public void set_SideloadSubtitles(){} // RVA: 0x7FFAC3E0C170
        public void get_SubtitlePath(){} // RVA: 0x7FFAC32EF640
        public void set_SubtitlePath(){} // RVA: 0x7FFAC354E360
        public void set_AudioHeadTransform(){} // RVA: 0x7FFAC354E3C0
        public void get_AudioHeadTransform(){} // RVA: 0x7FFAC354DFB0
        public void get_AudioFocusEnabled(){} // RVA: 0x7FFAC45C9D50
        public void set_AudioFocusEnabled(){} // RVA: 0x7FFAC37B1910
        public void get_AudioFocusTransform(){} // RVA: 0x7FFAC354B1A0
        public void set_AudioFocusTransform(){} // RVA: 0x7FFAC334B370
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x7FFAC3E7CCE0
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x7FFAC3CEFCE0
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x7FFAC47BB010
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x7FFAC47BB020
        public void get_HttpHeaders(){} // RVA: 0x7FFAC2F8C0B0
        public void set_HttpHeaders(){} // RVA: 0x7FFAC2F8C0C0
        public void get_KeyAuth(){} // RVA: 0x7FFAC2F8C120
        public void set_KeyAuth(){} // RVA: 0x7FFAC2F8C130
        public void get_Events(){} // RVA: 0x7FFAC47BB030
        public void get_EventMask(){} // RVA: 0x7FFAC3696B20
        public void set_EventMask(){} // RVA: 0x7FFAC4591C30
        public void get_PauseMediaOnAppPause(){} // RVA: 0x7FFAC47BB0F0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x7FFAC47BB100
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x7FFAC47BB110
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x7FFAC47BB120
        public void get_Persistent(){} // RVA: 0x7FFAC47BB130
        public void set_Persistent(){} // RVA: 0x7FFAC47BB140
        public void get_ForceFileFormat(){} // RVA: 0x7FFAC47BB150
        public void set_ForceFileFormat(){} // RVA: 0x7FFAC47BB160
        public void get_Info(){} // RVA: 0x7FFAC3331F50
        public void get_Control(){} // RVA: 0x7FFAC2FA2970
        public void get_Player(){} // RVA: 0x7FFAC34F6C80
        public void get_TextureProducer(){} // RVA: 0x7FFAC2F8C2A0
        public void get_Subtitles(){} // RVA: 0x7FFAC36D1F40
        public void get_VideoTracks(){} // RVA: 0x7FFAC313CBB0
        public void get_AudioTracks(){} // RVA: 0x7FFAC35466F0
        public void get_TextTracks(){} // RVA: 0x7FFAC3544340
        public void get_Cache(){} // RVA: 0x7FFAC354B170
        public void get_BufferedDisplay(){} // RVA: 0x7FFAC33BC6D0
        public void get_MediaOpened(){} // RVA: 0x7FFAC47BB170
        public void Awake(){} // RVA: 0x7FFAC47BB180
        public void Initialise(){} // RVA: 0x7FFAC47BB220
        public void Start(){} // RVA: 0x7FFAC47BBC20
        public void OpenMedia(){} // RVA: 0x7FFAC47BBEE0 | overloaded x4
        public void InternalOpenMedia(){} // RVA: 0x7FFAC47BBF10
        public void SetLoadOptions(){} // RVA: 0x7FFAC47BC700
        public void SetPlaybackOptions(){} // RVA: 0x7FFAC47BC7D0
        public void CloseMedia(){} // RVA: 0x7FFAC47BC900
        public void RewindPrerollPause(){} // RVA: 0x7FFAC47BCAA0
        public void Play(){} // RVA: 0x7FFAC47BCB90
        public void Pause(){} // RVA: 0x7FFAC47BCC30
        public void Stop(){} // RVA: 0x7FFAC47BCCB0
        public void Rewind(){} // RVA: 0x7FFAC47BCD10
        public void SeekToLiveTime(){} // RVA: 0x7FFAC47BCDA0
        public void Update(){} // RVA: 0x7FFAC47BCE40
        public void LateUpdate(){} // RVA: 0x7FFAC47BD070
        public void UpdateResampler(){} // RVA: 0x7FFAC47BD250
        public void OnEnable(){} // RVA: 0x7FFAC47BD3E0
        public void OnDisable(){} // RVA: 0x7FFAC47BD460
        public void OnDestroy(){} // RVA: 0x7FFAC47BD500
        public void ForceDispose(){} // RVA: 0x7FFAC47BDB60
        public void AllPlayersDispose(){} // RVA: 0x7FFAC47BDC10
        public void HandleApplicationQuit(){} // RVA: 0x7FFAC47BDD50
        public void StartRenderCoroutine(){} // RVA: 0x7FFAC47BE070
        public void StopRenderCoroutine(){} // RVA: 0x7FFAC47BE190
        public void FinalRenderCapture(){} // RVA: 0x7FFAC47BE210
        public void GetPlatform(){} // RVA: 0x7FFAC34F9180
        public void GetCurrentPlatformOptions(){} // RVA: 0x7FFAC336D860
        public void GetPlatformVideoApiString(){} // RVA: 0x7FFAC47BE2B0
        public void GetPlatformFileOffset(){} // RVA: 0x7FFAC34F9180
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x7FFAC47BE330
        public void GetResolvedFilePath(){} // RVA: 0x7FFAC47BE3E0
        public void CreateMediaPlayer(){} // RVA: 0x7FFAC47BE700 | overloaded x2
        public void CreateMediaPlayerNull(){} // RVA: 0x7FFAC47BE690
        public void UpdateAudioFocus(){} // RVA: 0x7FFAC47BEAB0
        public void UpdateAudioHeadTransform(){} // RVA: 0x7FFAC47BED30
        public void UpdateErrors(){} // RVA: 0x7FFAC47BEF50
        public void IsUsingAndroidOESPath(){} // RVA: 0x7FFAC47BF200
        public void OnApplicationFocus(){} // RVA: 0x7FFAC2F21310
        public void OnApplicationPause(){} // RVA: 0x7FFAC2F21310
        public void ResetEvents(){} // RVA: 0x7FFAC47BF250
        public void UpdateEvents(){} // RVA: 0x7FFAC47BF280
        public void IsHandleEvent(){} // RVA: 0x7FFAC47BF760
        public void FireEventIfPossible(){} // RVA: 0x7FFAC47BF790
        public void CanFireEvent(){} // RVA: 0x7FFAC47BF820
        public void ForceWaitForNewFrame(){} // RVA: 0x7FFAC47BFCC0
        public void GetDummyCamera(){} // RVA: 0x7FFAC47BFEF0
        public void ExtractFrameCoroutine(){} // RVA: 0x7FFAC47C0360
        public void ExtractFrameAsync(){} // RVA: 0x7FFAC47C04E0
        public void ExtractFrame(){} // RVA: 0x7FFAC47C0870 | overloaded x2
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFAC47C0B10
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x7FFAC47C0C10
        public void AddChunkToVideoBuffer(){} // RVA: 0x7FFAC47C0E90
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x7FFAC47C0FB0
        public void OpenMediaFromBufferInternal(){} // RVA: 0x7FFAC47C1040
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x7FFAC47C12A0
        public void AddChunkToBufferInternal(){} // RVA: 0x7FFAC47C0E90
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x7FFAC47C0FB0
        public void get_PlatformOptionsWindows(){} // RVA: 0x7FFAC336D860
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7FFAC354B1B0
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFAC35410C0
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7FFAC3540F60
        public void get_PlatformOptionsAndroid(){} // RVA: 0x7FFAC3541C80
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x7FFAC354E2E0
        public void get_PlatformOptionsWebGL(){} // RVA: 0x7FFAC3548F80
        public void EnableSubtitles(){} // RVA: 0x7FFAC47C1480
        public void LoadSubtitlesCoroutine(){} // RVA: 0x7FFAC47C18D0
        public void DisableSubtitles(){} // RVA: 0x7FFAC47C1A30
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC47C1BA0
        public void .ctor(){} // RVA: 0x7FFAC47C1D20
    }

    public class MediaPlayerEvent : UnityEvent`3
    {
        public System.Collections.Generic.List`1<UnityEngine.Events.UnityAction`3<RenderHeads.Media.AVProVideo.MediaPlayer,0x6B2744D8,0x6B274E20>> _listeners; // 0x30

        // ── Methods ──
        public void HasListeners(){} // RVA: 0x7FFAC47CE0D0
        public void AddListener(){} // RVA: 0x7FFAC47CE160
        public void RemoveListener(){} // RVA: 0x7FFAC47CE2E0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC47CE3E0
        public void .ctor(){} // RVA: 0x7FFAC47CE450
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47CE090
    }

    public class MediaPlaylist : Object
    {
        public System.Collections.Generic.List`1<MediaItem> Items; // 0x10

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC2F3C380
        public void HasItemAt(){} // RVA: 0x7FFAC47C3CF0
        public void .ctor(){} // RVA: 0x7FFAC47C3D60
    }

    public class MediaReference : ScriptableObject
    {
        public string Alias; // 0x18
        public RenderHeads.Media.AVProVideo.MediaPath MediaPath; // 0x20
        public RenderHeads.Media.AVProVideo.MediaHints Hints; // 0x28
        public RenderHeads.Media.AVProVideo.MediaReference _macOS; // 0x38
        public RenderHeads.Media.AVProVideo.MediaReference _windows; // 0x40
        public RenderHeads.Media.AVProVideo.MediaReference _android; // 0x48
        public RenderHeads.Media.AVProVideo.MediaReference _iOS; // 0x50
        public RenderHeads.Media.AVProVideo.MediaReference _tvOS; // 0x58
        public RenderHeads.Media.AVProVideo.MediaReference _windowsUWP; // 0x60
        public RenderHeads.Media.AVProVideo.MediaReference _webGL; // 0x68

        // ── Methods ──
        public void get_Alias(){} // RVA: 0x7FFAC2F247C0
        public void set_Alias(){} // RVA: 0x7FFAC2F87E80
        public void get_MediaPath(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MediaPath(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Hints(){} // RVA: 0x7FFAC2F9C700
        public void set_Hints(){} // RVA: 0x7FFAC2F9C720
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x7FFAC47B48F0
        public void GetPlatformMediaReference(){} // RVA: 0x7FFAC47B49C0
        public void .ctor(){} // RVA: 0x7FFAC47B4A40
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        public bool _isPlaying; // 0xA8
        public bool _isPaused; // 0xA9
        public double _currentTime; // 0xB0
        public float _volume; // 0xB8
        public float _playbackRate; // 0xBC
        public bool _bLoop; // 0xC0
        public int _Width; // 0xC4
        public int _height; // 0xC8
        public UnityEngine.Texture2D _texture; // 0xD0
        public UnityEngine.Texture2D _texture_AVPro; // 0xD8
        public UnityEngine.Texture2D _texture_AVPro1; // 0xE0
        public float _fakeFlipTime; // 0xE8
        public int _frameCount; // 0xEC
        public float FrameRate;

        // ── Methods ──
        public void GetVersion(){} // RVA: 0x7FFAC47D2DD0
        public void GetExpectedVersion(){} // RVA: 0x7FFAC47D2E10
        public void OpenMedia(){} // RVA: 0x7FFAC47D2E30
        public void CloseMedia(){} // RVA: 0x7FFAC47D3170
        public void SetLooping(){} // RVA: 0x7FFAC2F424D0
        public void IsLooping(){} // RVA: 0x7FFAC2F424C0
        public void HasMetaData(){} // RVA: 0x7FFAC3006850
        public void CanPlay(){} // RVA: 0x7FFAC3006850
        public void HasAudio(){} // RVA: 0x7FFAC2F21320
        public void HasVideo(){} // RVA: 0x7FFAC2F21320
        public void Play(){} // RVA: 0x7FFAC47D31B0
        public void Pause(){} // RVA: 0x7FFAC47D31D0
        public void Stop(){} // RVA: 0x7FFAC47D31E0
        public void IsSeeking(){} // RVA: 0x7FFAC2F21320
        public void IsPlaying(){} // RVA: 0x7FFAC3141F10
        public void IsPaused(){} // RVA: 0x7FFAC3CEFA00
        public void IsFinished(){} // RVA: 0x7FFAC47D31F0
        public void IsBuffering(){} // RVA: 0x7FFAC2F21320
        public void GetDuration(){} // RVA: 0x7FFAC47D3240
        public void GetVideoWidth(){} // RVA: 0x7FFAC47D3250
        public void GetVideoHeight(){} // RVA: 0x7FFAC3641480
        public void GetVideoDisplayRate(){} // RVA: 0x7FFAC37430B0
        public void GetTexture(){} // RVA: 0x7FFAC303E100
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC47D3260
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFAC314F980
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC2F21320
        public void Seek(){} // RVA: 0x7FFAC47D3270
        public void SeekFast(){} // RVA: 0x7FFAC47D3270
        public void GetCurrentTime(){} // RVA: 0x7FFAC47D3280
        public void SetPlaybackRate(){} // RVA: 0x7FFAC47D3290
        public void GetPlaybackRate(){} // RVA: 0x7FFAC47D32A0
        public void MuteAudio(){} // RVA: 0x7FFAC2F21310
        public void IsMuted(){} // RVA: 0x7FFAC3006850
        public void SetVolume(){} // RVA: 0x7FFAC47D32B0
        public void GetVolume(){} // RVA: 0x7FFAC47D32C0
        public void GetVideoFrameRate(){} // RVA: 0x7FFAC37432E0
        public void Update(){} // RVA: 0x7FFAC47D32D0
        public void Render(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void InternalSetActiveTrack(){} // RVA: 0x7FFAC2F21320
        public void InternalIsChangedTracks(){} // RVA: 0x7FFAC2F21320
        public void InternalGetTrackCount(){} // RVA: 0x7FFAC34F9180
        public void InternalGetTrackInfo(){} // RVA: 0x7FFAC34F9180
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFAC2F21320
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC47D35C0
    }

    public class OptionsAppleExtensions : Object
    {
        // ── Methods ──
        public void GenerateMipmaps(){} // RVA: 0x7FFAC47C3C00
        public void SetGenerateMipMaps(){} // RVA: 0x7FFAC47C3C10
        public void AllowExternalPlayback(){} // RVA: 0x7FFAC47C3C30
        public void SetAllowExternalPlayback(){} // RVA: 0x7FFAC47C3C40
        public void PlayWithoutBuffering(){} // RVA: 0x7FFAC47C3C60
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFAC47C3C70
        public void UseSinglePlayerItem(){} // RVA: 0x7FFAC47C3C90
        public void SetUseSinglePlayerItem(){} // RVA: 0x7FFAC47C3CA0
        public void ResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7FFAC47C3CC0
        public void SetResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7FFAC47C3CD0
    }

    public class PlaybackQualityStats : Object
    {
        public int SkippedFrames; // 0x10
        public int DuplicateFrames; // 0x14
        public int UnityDroppedFrames; // 0x18
        public float PerfectFramesT; // 0x1C
        public string VSyncStatus; // 0x20
        public int PerfectFrames; // 0x28
        public int TotalFrames; // 0x2C
        public bool LogIssues; // 0x30
        public int _sameFrameCount; // 0x34
        public long _lastTimeStamp; // 0x38
        public RenderHeads.Media.AVProVideo.BaseMediaPlayer _player; // 0x40

        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0x7FFAC2F6E5C0
        public void set_SkippedFrames(){} // RVA: 0x7FFAC2F240C0
        public void get_DuplicateFrames(){} // RVA: 0x7FFAC33D5A20
        public void set_DuplicateFrames(){} // RVA: 0x7FFAC33D4990
        public void get_UnityDroppedFrames(){} // RVA: 0x7FFAC3157800
        public void set_UnityDroppedFrames(){} // RVA: 0x7FFAC392CD10
        public void get_PerfectFramesT(){} // RVA: 0x7FFAC2FEE570
        public void set_PerfectFramesT(){} // RVA: 0x7FFAC2FEE580
        public void get_VSyncStatus(){} // RVA: 0x7FFAC2F4F0C0
        public void set_VSyncStatus(){} // RVA: 0x7FFAC2F4F0D0
        public void get_PerfectFrames(){} // RVA: 0x7FFAC32EC4C0
        public void set_PerfectFrames(){} // RVA: 0x7FFAC369A6E0
        public void get_TotalFrames(){} // RVA: 0x7FFAC3C891D0
        public void set_TotalFrames(){} // RVA: 0x7FFAC45B6490
        public void get_LogIssues(){} // RVA: 0x7FFAC2F47450
        public void set_LogIssues(){} // RVA: 0x7FFAC2F47460
        public void Reset(){} // RVA: 0x7FFAC47D20E0
        public void Start(){} // RVA: 0x7FFAC47D2130
        public void Update(){} // RVA: 0x7FFAC47D2730
        public void IsGameViewVSyncEnabled(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        public UnityEngine.Shader CurrentPlayer; // 0x1C0
        public RenderHeads.Media.AVProVideo.MediaPlayer NextPlayer; // 0x1C8
        public RenderHeads.Media.AVProVideo.MediaPlayer Playlist; // 0x1D0
        public bool PlaylistIndex; // 0x1D8
        public bool PlaylistItem; // 0x1D9
        public 0x6B274060 DefaultTransition; // 0x1DC
        public RenderHeads.Media.AVProVideo.MediaPlaylist DefaultTransitionDuration; // 0x1E0
        public bool DefaultTransitionEasing; // 0x1E8
        public 0x6B274008 AutoCloseVideo; // 0x1EC
        public float LoopMode; // 0x1F0
        public 0x6B274168 AutoProgress; // 0x1F4
        public RenderHeads.Media.AVProVideo.LazyShaderProperty Info;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty Control; // 0x10
        public bool TextureProducer; // 0x1F8
        public int AudioVolume; // 0x1FC
        public RenderHeads.Media.AVProVideo.MediaPlayer AudioMuted; // 0x200
        public UnityEngine.Material _material; // 0x208
        public 0x6B274008 _currentTransition; // 0x210
        public string _currentTransitionName; // 0x218
        public float _currentTransitionDuration; // 0x220
        public 0x6B274168 _currentTransitionEasing; // 0x224
        public float _textureTimer; // 0x228
        public float _transitionTimer; // 0x22C
        public System.Func`2<float,float> _easeFunc; // 0x230
        public UnityEngine.RenderTexture _rt; // 0x238
        public MediaItem _currentItem; // 0x240
        public MediaItem _nextItem; // 0x248
        public float _playlistAudioVolume; // 0x250
        public bool _playlistAudioMuted; // 0x254

        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x7FFAC47C3FE0
        public void get_NextPlayer(){} // RVA: 0x7FFAC3544790
        public void get_Playlist(){} // RVA: 0x7FFAC33F8150
        public void get_PlaylistIndex(){} // RVA: 0x7FFAC47C4130
        public void get_PlaylistItem(){} // RVA: 0x7FFAC47C4140
        public void get_DefaultTransition(){} // RVA: 0x7FFAC47C4230
        public void set_DefaultTransition(){} // RVA: 0x7FFAC47C4240
        public void get_DefaultTransitionDuration(){} // RVA: 0x7FFAC47C4250
        public void set_DefaultTransitionDuration(){} // RVA: 0x7FFAC47C4260
        public void get_DefaultTransitionEasing(){} // RVA: 0x7FFAC47C4270
        public void set_DefaultTransitionEasing(){} // RVA: 0x7FFAC47C4280
        public void get_AutoCloseVideo(){} // RVA: 0x7FFAC47C4290
        public void set_AutoCloseVideo(){} // RVA: 0x7FFAC47C42A0
        public void get_LoopMode(){} // RVA: 0x7FFAC47C42B0
        public void set_LoopMode(){} // RVA: 0x7FFAC47C42C0
        public void get_AutoProgress(){} // RVA: 0x7FFAC47C42D0
        public void set_AutoProgress(){} // RVA: 0x7FFAC47C42E0
        public void get_Info(){} // RVA: 0x7FFAC47C42F0
        public void get_Control(){} // RVA: 0x7FFAC47C4400
        public void get_TextureProducer(){} // RVA: 0x7FFAC47C4510
        public void get_AudioVolume(){} // RVA: 0x7FFAC47C4640
        public void set_AudioVolume(){} // RVA: 0x7FFAC47C4650
        public void get_AudioMuted(){} // RVA: 0x7FFAC47C47A0
        public void set_AudioMuted(){} // RVA: 0x7FFAC47C47B0
        public void Play(){} // RVA: 0x7FFAC47C48E0
        public void Pause(){} // RVA: 0x7FFAC47C49F0
        public void IsPaused(){} // RVA: 0x7FFAC47C4AF0
        public void SwapPlayers(){} // RVA: 0x7FFAC47C4B00
        public void GetCurrentTexture(){} // RVA: 0x7FFAC47C54F0
        public void GetNextTexture(){} // RVA: 0x7FFAC47C5650
        public void Awake(){} // RVA: 0x7FFAC47C57A0
        public void OnDestroy(){} // RVA: 0x7FFAC47C5B50
        public void Start(){} // RVA: 0x7FFAC47C5E90
        public void OnVideoEvent(){} // RVA: 0x7FFAC47C60F0
        public void PrevItem(){} // RVA: 0x7FFAC47C64B0
        public void NextItem(){} // RVA: 0x7FFAC47C64C0
        public void CanJumpToItem(){} // RVA: 0x7FFAC47C6540
        public void JumpToItem(){} // RVA: 0x7FFAC47C6620
        public void OpenVideoFile(){} // RVA: 0x7FFAC47C67F0
        public void IsTransitioning(){} // RVA: 0x7FFAC47C6BA0
        public void SetTransition(){} // RVA: 0x7FFAC47C6CA0
        public void Update(){} // RVA: 0x7FFAC47C6E70
        public void GetTexture(){} // RVA: 0x7FFAC35413D0
        public void GetTextureCount(){} // RVA: 0x7FFAC47C7510
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC47C7590
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFAC47C7610
        public void GetTextureTimeStamp(){} // RVA: 0x7FFAC47C7690
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFAC47C7710
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC47C7790
        public void GetYpCbCrTransform(){} // RVA: 0x7FFAC47C7810
        public void GetTextureStereoPacking(){} // RVA: 0x7FFAC47C78C0
        public void GetTextureTransparency(){} // RVA: 0x7FFAC47C7940
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFAC47C79C0
        public void GetTransitionName(){} // RVA: 0x7FFAC47C7A40
        public void .ctor(){} // RVA: 0x7FFAC47C7D70
        public void .cctor(){} // RVA: 0x7FFAC47C8010
    }

    public class Resampler : Object
    {
        public System.Collections.Generic.List`1<TimestampedRenderTexture[]> DroppedFrames; // 0x10
        public RenderHeads.Media.AVProVideo.MediaPlayer FrameDisplayedTimer; // 0x18
        public UnityEngine.RenderTexture[] BaseTimestamp; // 0x20
        public int ElapsedTimeSinceBase; // 0x28
        public int LastT; // 0x2C
        public int TextureTimeStamp; // 0x30
        public long OutputTexture; // 0x38
        public float _elapsedTimeSinceBase; // 0x40
        public UnityEngine.Material _blendMat; // 0x48
        public 0x6B276268 _resampleMode; // 0x50
        public string _name; // 0x58
        public long _lastTimeStamp; // 0x60
        public int _droppedFrames; // 0x68
        public long _lastDisplayedTimestamp; // 0x70
        public int _frameDisplayedTimer; // 0x78
        public long _currentDisplayedTimestamp; // 0x80
        public float <LastT>k__BackingField; // 0x88
        public long <TextureTimeStamp>k__BackingField; // 0x90
        public string ShaderPropT;
        public string ShaderPropAftertex;
        public int _propAfterTex; // 0x98
        public int _propT; // 0x9C
        public float _videoFrameRate; // 0xA0

        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x7FFAC47BAB50
        public void get_FrameDisplayedTimer(){} // RVA: 0x7FFAC4596EF0
        public void get_BaseTimestamp(){} // RVA: 0x7FFAC31D0140
        public void set_BaseTimestamp(){} // RVA: 0x7FFAC35233F0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7FFAC30E80B0
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7FFAC30EFD80
        public void get_LastT(){} // RVA: 0x7FFAC34325D0
        public void set_LastT(){} // RVA: 0x7FFAC342DD70
        public void get_TextureTimeStamp(){} // RVA: 0x7FFAC32EF640
        public void set_TextureTimeStamp(){} // RVA: 0x7FFAC3705AA0
        public void OnVideoEvent(){} // RVA: 0x7FFAC47E3870
        public void .ctor(){} // RVA: 0x7FFAC47E3950
        public void get_OutputTexture(){} // RVA: 0x7FFAC2F4F0C0
        public void Reset(){} // RVA: 0x7FFAC47E3E90
        public void Release(){} // RVA: 0x7FFAC47E3EB0
        public void ReleaseRenderTextures(){} // RVA: 0x7FFAC47E4040
        public void ConstructRenderTextures(){} // RVA: 0x7FFAC47E4390
        public void CheckRenderTexturesValid(){} // RVA: 0x7FFAC47E4970
        public void FindBeforeFrameIndex(){} // RVA: 0x7FFAC47E4DE0
        public void FindClosestFrame(){} // RVA: 0x7FFAC47E5020
        public void PointUpdate(){} // RVA: 0x7FFAC47E5200
        public void SampleFrame(){} // RVA: 0x7FFAC47E5530
        public void SampleFrames(){} // RVA: 0x7FFAC47E5700
        public void LinearUpdate(){} // RVA: 0x7FFAC47E5AD0
        public void InvalidateBuffer(){} // RVA: 0x7FFAC47E5CF0
        public void GuessFrameRate(){} // RVA: 0x7FFAC47E5DF0
        public void Update(){} // RVA: 0x7FFAC47E60B0
        public void UpdateTimestamp(){} // RVA: 0x7FFAC47E6DD0
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer MediaPlayer; // 0x20
        public RenderHeads.Media.AVProVideo.VideoResolveOptions VideoResolveOptions; // 0x28
        public 0x6B276478 ExternalTexture; // 0x58
        public UnityEngine.RenderTexture TargetTexture; // 0x60
        public UnityEngine.Material _materialResolve; // 0x68
        public bool _isMaterialSetup; // 0x70
        public bool _isMaterialDirty; // 0x71
        public bool _isMaterialOES; // 0x72
        public UnityEngine.RenderTexture _internalTexture; // 0x78
        public int _textureFrameCount; // 0x80
        public UnityEngine.Material _materialBlit; // 0x88
        public int _srcTexId; // 0x90

        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MediaPlayer(){} // RVA: 0x7FFAC47C8A90
        public void get_VideoResolveOptions(){} // RVA: 0x7FFAC47C8AA0
        public void set_VideoResolveOptions(){} // RVA: 0x7FFAC47C8AC0
        public void get_ExternalTexture(){} // RVA: 0x7FFAC2FBF370
        public void set_ExternalTexture(){} // RVA: 0x7FFAC2FBF380
        public void get_TargetTexture(){} // RVA: 0x7FFAC47C8AE0
        public void SetMaterialDirty(){} // RVA: 0x7FFAC30D1E70
        public void ChangeMediaPlayer(){} // RVA: 0x7FFAC47C8BC0
        public void Start(){} // RVA: 0x7FFAC47C8D60
        public void LateUpdate(){} // RVA: 0x7FFAC47C9050
        public void Resolve(){} // RVA: 0x7FFAC47C9060
        public void OnDisable(){} // RVA: 0x7FFAC47C9850
        public void OnDestroy(){} // RVA: 0x7FFAC47C99C0
        public void .ctor(){} // RVA: 0x7FFAC47C9B00
    }

    public class Subtitle : Object
    {
        public int index; // 0x10
        public string text; // 0x18
        public double timeStart; // 0x20
        public double timeEnd; // 0x28

        // ── Methods ──
        public void IsBefore(){} // RVA: 0x7FFAC47E6DF0
        public void IsTime(){} // RVA: 0x7FFAC47E6E10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubtitlePlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubtitleUtils : Object
    {
        // ── Methods ──
        public void ParseTimeToSeconds(){} // RVA: 0x7FFAC47E6E30
        public void ParseSubtitlesSRT(){} // RVA: 0x7FFAC47E6FE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubtitlesUGUI : MonoBehaviour
    {
        public RenderHeads.Media.AVProVideo.MediaPlayer Player; // 0x20
        public UnityEngine.UI.Text Text; // 0x28
        public UnityEngine.UI.Image _backgroundImage; // 0x30
        public int _backgroundHorizontalPadding; // 0x38
        public int _backgroundVerticalPadding; // 0x3C
        public int _maxCharacters; // 0x40

        // ── Methods ──
        public void set_Player(){} // RVA: 0x7FFAC47B3BE0
        public void get_Player(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Text(){} // RVA: 0x7FFAC2F22E90
        public void get_Text(){} // RVA: 0x7FFAC2F4F130
        public void Start(){} // RVA: 0x7FFAC47B3BF0
        public void OnDestroy(){} // RVA: 0x7FFAC47B3C00
        public void Update(){} // RVA: 0x7FFAC47B3C10
        public void ChangeMediaPlayer(){} // RVA: 0x7FFAC47B3C20
        public void SetText(){} // RVA: 0x7FFAC47B3F60
        public void PrepareText(){} // RVA: 0x7FFAC47B3FA0
        public void UpdateBackgroundRect(){} // RVA: 0x7FFAC47B4110
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFAC47B43C0
        public void .ctor(){} // RVA: 0x7FFAC47B4610
    }

    public class TextCue : Object
    {
        public string Text; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Text(){} // RVA: 0x7FFAC2F3C380
        public void set_Text(){} // RVA: 0x7FFAC2F22E30
    }

    public class TextTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E2CE0 | overloaded x2
    }

    public class TextTracks : TrackCollection`1
    {
        public object TrackType;

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFAC3026CB0
        public void .ctor(){} // RVA: 0x7FFAC47E2C30
    }

    public class TextureFrame : ValueType
    {
        public UIntPtr texturePointer; // 0x10
        public UIntPtr auxTexturePointer; // 0x18
        public long timeStamp; // 0x20
        public uint frameCounter; // 0x28
        public uint writtenFrameCount; // 0x2C
        public 0x6B275450 flags; // 0x30
        public UIntPtr internalNativePointer; // 0x34
    }

    public class TimeRange : ValueType
    {
        public double StartTime; // 0x10
        public double EndTime; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47D1AB0
        public void get_StartTime(){} // RVA: 0x7FFAC47D1AC0
        public void get_EndTime(){} // RVA: 0x7FFAC47D1AD0
        public void get_Duration(){} // RVA: 0x7FFAC47D1AE0
    }

    public class TimeRanges : Object
    {
        public RenderHeads.Media.AVProVideo.TimeRange[] Item; // 0x10
        public double Count; // 0x18
        public double MinTime; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47D1E50 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC47D1B80
        public void get_Item(){} // RVA: 0x7FFAC47D1BA0
        public void ToString(){} // RVA: 0x7FFAC47D1BE0
        public void CalculateRange(){} // RVA: 0x7FFAC47D1F50
        public void get_Count(){} // RVA: 0x7FFAC3510620
        public void get_MinTime(){} // RVA: 0x7FFAC4422FA0
        public void get_MaxTime(){} // RVA: 0x7FFAC44ED560
        public void get_Duration(){} // RVA: 0x7FFAC47D20D0
    }

    public class TrackBase : Object
    {
        public int Uid; // 0x10
        public 0x6B275C90 TrackType; // 0x14
        public string DisplayName; // 0x18
        public string Name; // 0x20
        public string Language; // 0x28
        public bool IsDefault; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E27D0 | overloaded x2
        public void get_Uid(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Uid(){} // RVA: 0x7FFAC2F240C0
        public void get_TrackType(){} // RVA: 0x7FFAC33D5A20
        public void set_TrackType(){} // RVA: 0x7FFAC33D4990
        public void get_DisplayName(){} // RVA: 0x7FFAC2F247C0
        public void set_DisplayName(){} // RVA: 0x7FFAC2F87E80
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Name(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Language(){} // RVA: 0x7FFAC2F4F130
        public void set_Language(){} // RVA: 0x7FFAC2F22E90
        public void get_IsDefault(){} // RVA: 0x7FFAC2F47450
        public void set_IsDefault(){} // RVA: 0x7FFAC2F47460
        public void CreateDisplayName(){} // RVA: 0x7FFAC47E2A50
    }

    public class TrackCollection : Object
    {
        public 0x6B275C90 TrackType; // 0x10

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFAC2F6E5C0
        public void set_TrackType(){} // RVA: 0x7FFAC2F240C0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void HasActiveTrack(){} // RVA: 0x7FFAC2C59D00
        public void IsActiveTrack(){} // RVA: 0x7FFAC2C59F60
        public void SetActiveTrack(){} // RVA: 0x7FFAC2C70A40
        public void SetFirstTrackActive(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TrackCollection`1 : TrackCollection
    {
        public T Item;
        public System.Collections.Generic.List`1<T> ActiveTrack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_ActiveTrack(){} // RVA: 0x7FFAC2E8DC40
        public void set_ActiveTrack(){} // RVA: 0x7FFAC2E8DC40
        public void HasActiveTrack(){} // RVA: 0x7FFAC2C59D00
        public void IsActiveTrack(){} // RVA: 0x7FFAC2C59F60
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void SetActiveTrack(){} // RVA: 0x7FFAC2C70A40
        public void SetFirstTrackActive(){} // RVA: 0x7FFAC2C70980
        public void get_Count(){} // RVA: 0x7FFAC2C59960
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        public UnityEngine.Camera Camera; // 0x20
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropWorldCameraPosition;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropWorldCameraRight; // 0x10
        public UnityEngine.Camera _foundCamera; // 0x28

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Camera(){} // RVA: 0x7FFAC2F4F0D0
        public void Awake(){} // RVA: 0x7FFAC47C9BD0
        public void Start(){} // RVA: 0x7FFAC47C9CE0
        public void LogXRDeviceDetails(){} // RVA: 0x7FFAC47C9CF0
        public void IsMultiPassVrEnabled(){} // RVA: 0x7FFAC47CA270
        public void LateUpdate(){} // RVA: 0x7FFAC47CA310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void .cctor(){} // RVA: 0x7FFAC47CAC40
    }

    public class VideoRender : Object
    {
        public string Shader_IMGUI;
        public string Shader_Resolve;
        public string Shader_ResolveOES;
        public string Shader_Preview;
        public string Keyword_AlphaPackTopBottom;
        public string Keyword_AlphaPackLeftRight;
        public string Keyword_AlphaPackNone;
        public string Keyword_StereoTopBottom;
        public string Keyword_StereoLeftRight;
        public string Keyword_StereoCustomUV;
        public string Keyword_StereoTwoTextures;
        public string Keyword_StereoNone;
        public string Keyword_StereoDebug;
        public string Keyword_LayoutEquirect180;
        public string Keyword_LayoutNone;
        public string Keyword_ForceEyeNone;
        public string Keyword_ForceEyeLeft;
        public string Keyword_ForceEyeRight;
        public string Keyword_ApplyGamma;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropChromaTex;
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropVertScale; // 0x10
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropApplyGamma; // 0x20
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropStereo; // 0x30
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropAlphaPack; // 0x40
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropLayout; // 0x50
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropViewMatrix; // 0x60
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropTextureMatrix; // 0x70
        public string Keyword_UseHSBC; // 0x80
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropHue; // 0x88
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropSaturation; // 0x98
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropContrast; // 0xA8
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropBrightness; // 0xB8
        public RenderHeads.Media.AVProVideo.LazyShaderProperty PropInvGamma; // 0xC8

        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x7FFAC47E75D0
        public void CreateIMGUIMaterial(){} // RVA: 0x7FFAC47E7670
        public void SetupLayoutMaterial(){} // RVA: 0x7FFAC47E76F0
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x7FFAC47E7870
        public void SetupStereoMaterial(){} // RVA: 0x7FFAC47E79C0
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x7FFAC47E7C80
        public void SetupAlphaPackedMaterial(){} // RVA: 0x7FFAC47E7D50
        public void SetupGammaMaterial(){} // RVA: 0x7FFAC47E7EA0
        public void SetupTextureMatrix(){} // RVA: 0x7FFAC2F21310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x7FFAC47E7FA0
        public void GetTexture(){} // RVA: 0x7FFAC47E80E0
        public void SetupMaterialForMedia(){} // RVA: 0x7FFAC47E8290
        public void SetupMaterial(){} // RVA: 0x7FFAC47E88E0
        public void SetupResolveMaterial(){} // RVA: 0x7FFAC47E90F0
        public void ResolveVideoToRenderTexture(){} // RVA: 0x7FFAC47E9580
        public void GetResolveTextureSize(){} // RVA: 0x7FFAC47E9EB0
        public void RequiresResolve(){} // RVA: 0x7FFAC47E9F60
        public void DrawTexture(){} // RVA: 0x7FFAC47EA010
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC47EA7F0
    }

    public class VideoResolveOptions : ValueType
    {
        public bool applyHSBC; // 0x10
        public float hue; // 0x14
        public float saturation; // 0x18
        public float brightness; // 0x1C
        public float contrast; // 0x20
        public float gamma; // 0x24
        public UnityEngine.Color tint; // 0x28
        public bool generateMipmaps; // 0x38
        public 0x6B274C68 aspectRatio; // 0x3C

        // ── Methods ──
        public void IsColourAdjust(){} // RVA: 0x7FFAC47D19B0
        public void ResetColourAdjust(){} // RVA: 0x7FFAC47D1A10
        public void Create(){} // RVA: 0x7FFAC47D1A40
    }

    public class VideoTrack : TrackBase
    {
        public int Bitrate; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47E2C70 | overloaded x2
        public void get_Bitrate(){} // RVA: 0x7FFAC358A870
        public void set_Bitrate(){} // RVA: 0x7FFAC3588350
    }

    public class VideoTracks : TrackCollection`1
    {
        public object TrackType;

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC47E2BB0
    }

    public class WebGL : Object
    {
    }

    public class Windows : Object
    {
        public string AudioDeviceOutputName_Vive;
        public string AudioDeviceOutputName_Rift;
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        public 0x6B274FD8 _audioOutput; // 0xA8
        public string _audioDeviceOutputName; // 0xB0
        public System.Collections.Generic.List`1<string> _preferredFilters; // 0xB8
        public 0x6B2753A0 _audio360ChannelMode; // 0xC0
        public bool _useCustomMovParser; // 0xC4
        public bool _useStereoDetection; // 0xC5
        public bool _useHapNotchLC; // 0xC6
        public bool _useTextTrackSupport; // 0xC7
        public bool _useFacebookAudio360Support; // 0xC8
        public bool _useAudioDelay; // 0xC9
        public int _decoderParallelFrameCount; // 0xCC
        public int _decodePrerollFrameCount; // 0xD0
        public bool _isPlaying; // 0xD4
        public bool _isPaused; // 0xD5
        public bool _audioMuted; // 0xD6
        public float _volume; // 0xD8
        public float _balance; // 0xDC
        public bool _isLooping; // 0xE0
        public bool _canPlay; // 0xE1
        public bool _hasMetaData; // 0xE2
        public int _width; // 0xE4
        public int _height; // 0xE8
        public float _frameRate; // 0xEC
        public bool _hasAudio; // 0xF0
        public bool _hasVideo; // 0xF1
        public bool _isTextureTopDown; // 0xF2
        public UIntPtr _nativeTexture; // 0xF8
        public UnityEngine.Texture2D _texture; // 0x100
        public UnityEngine.RenderTexture _resolvedTexture; // 0x108
        public UIntPtr _instance; // 0x110
        public 0x6B274F80 _videoApi; // 0x118
        public bool _useHardwareDecoding; // 0x11C
        public bool _useTextureMips; // 0x11D
        public bool _use10BitTextures; // 0x11E
        public bool _hintAlphaChannel; // 0x11F
        public bool _useLowLatency; // 0x120
        public bool _supportsLinearColorSpace; // 0x121
        public RenderHeads.Media.AVProVideo.TextureFrame _textureFrame; // 0x122
        public bool _isInitialised;
        public string _version; // 0x8
        public UIntPtr _nativeFunction_UnityRenderEvent; // 0x10
        public int _lastUpdateAllTexturesFrame; // 0x18
        public 0x6B2746E8 _frameSelectionMode; // 0x150
        public bool _pauseOnPrerollComplete; // 0x154
        public RenderHeads.Media.AVProVideo.IBufferedDisplay _masterDisplay; // 0x158
        public RenderHeads.Media.AVProVideo.IBufferedDisplay[] _slaveDisplays; // 0x160
        public double _displayClockTime; // 0x168
        public double _timeAccumulation; // 0x170
        public bool _needsInitialFrame; // 0x178

        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x7FFAC47D35F0
        public void DeinitPlatform(){} // RVA: 0x7FFAC47D3AC0
        public void GetAudioChannelCount(){} // RVA: 0x7FFAC47D3B70
        public void GetAudioChannelMask(){} // RVA: 0x7FFAC47D3BF0
        public void .ctor(){} // RVA: 0x7FFAC47D3EE0 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFAC47D4140
        public void GetVersion(){} // RVA: 0x7FFAC47D4480
        public void GetExpectedVersion(){} // RVA: 0x7FFAC47D44E0
        public void UseNativeMips(){} // RVA: 0x7FFAC47D4520
        public void OpenMedia(){} // RVA: 0x7FFAC47D4530
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFAC47D4D00
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFAC47D51D0
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFAC47D52A0
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFAC47D5360
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x7FFAC47D57B0
        public void CloseMedia(){} // RVA: 0x7FFAC47D5980
        public void SetLooping(){} // RVA: 0x7FFAC47D5B20
        public void IsLooping(){} // RVA: 0x7FFAC304CF80
        public void HasMetaData(){} // RVA: 0x7FFAC47D5BB0
        public void HasAudio(){} // RVA: 0x7FFAC2FA2AD0
        public void HasVideo(){} // RVA: 0x7FFAC3E66790
        public void CanPlay(){} // RVA: 0x7FFAC47D5BC0
        public void Play(){} // RVA: 0x7FFAC47D5BD0
        public void Pause(){} // RVA: 0x7FFAC47D5C60
        public void Stop(){} // RVA: 0x7FFAC47D5C60
        public void IsSeeking(){} // RVA: 0x7FFAC47D5C80
        public void IsPlaying(){} // RVA: 0x7FFAC47D5D10
        public void IsPaused(){} // RVA: 0x7FFAC47D5D90
        public void IsFinished(){} // RVA: 0x7FFAC47D5DD0
        public void IsBuffering(){} // RVA: 0x7FFAC47D5EC0
        public void GetDuration(){} // RVA: 0x7FFAC47D5F50
        public void GetVideoWidth(){} // RVA: 0x7FFAC47D5FD0
        public void GetVideoHeight(){} // RVA: 0x7FFAC47D5FE0
        public void GetVideoFrameRate(){} // RVA: 0x7FFAC47D5FF0
        public void GetTexture(){} // RVA: 0x7FFAC47D6000
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC47D6110
        public void GetTextureTimeStamp(){} // RVA: 0x7FFAC47D6120
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFAC47D61A0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC3E634D0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFAC47D6250
        public void Seek(){} // RVA: 0x7FFAC47D62D0
        public void SeekFast(){} // RVA: 0x7FFAC47D6390
        public void GetCurrentTime(){} // RVA: 0x7FFAC47D6450
        public void SetPlaybackRate(){} // RVA: 0x7FFAC47D64D0
        public void GetPlaybackRate(){} // RVA: 0x7FFAC47D6560
        public void MuteAudio(){} // RVA: 0x7FFAC47D65E0
        public void IsMuted(){} // RVA: 0x7FFAC47BB130
        public void SetVolume(){} // RVA: 0x7FFAC47D6670
        public void GetVolume(){} // RVA: 0x7FFAC47D6710
        public void SetBalance(){} // RVA: 0x7FFAC47D6720
        public void GetBalance(){} // RVA: 0x7FFAC33CE4B0
        public void IsPlaybackStalled(){} // RVA: 0x7FFAC47D67C0
        public void WaitForNextFrame(){} // RVA: 0x7FFAC47D6870
        public void SetAudioChannelMode(){} // RVA: 0x7FFAC47D6A80
        public void SetAudioHeadRotation(){} // RVA: 0x7FFAC47D6B10
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFAC47D6B50
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFAC47D6C70
        public void SetAudioFocusProperties(){} // RVA: 0x7FFAC47D6C80
        public void SetAudioFocusRotation(){} // RVA: 0x7FFAC47D6C90
        public void ResetAudioFocus(){} // RVA: 0x7FFAC47D6CD0
        public void Update(){} // RVA: 0x7FFAC47D6D40
        public void ReleaseTexture(){} // RVA: 0x7FFAC47D7580
        public void UpdateTexture(){} // RVA: 0x7FFAC47D7820
        public void EndUpdate(){} // RVA: 0x7FFAC47D7FC0
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFAC47D8040
        public void OnTextureSizeChanged(){} // RVA: 0x7FFAC2F21310
        public void BeginRender(){} // RVA: 0x7FFAC47D80C0
        public void Render(){} // RVA: 0x7FFAC47D8110
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void GrabAudio(){} // RVA: 0x7FFAC47D8170
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFAC47D8230
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFAC47D82B0
        public void GetDecoderPerformance(){} // RVA: 0x7FFAC47D82C0
        public void IssueRenderThreadEvent(){} // RVA: 0x7FFAC47D8370
        public void GetPluginVersion(){} // RVA: 0x7FFAC47D8490
        public void InternalSetActiveTrack(){} // RVA: 0x7FFAC47D8560
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFAC47D8610
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFAC47D86A0
        public void InternalIsChangedTracks(){} // RVA: 0x7FFAC47D8770
        public void InternalGetTrackCount(){} // RVA: 0x7FFAC47D8810
        public void InternalGetTrackInfo(){} // RVA: 0x7FFAC47D88B0
        public void UpdateTimeRanges(){} // RVA: 0x7FFAC47D8D00
        public void UpdateTimeRange(){} // RVA: 0x7FFAC47D8D70
        public void FlushFrameBuffering(){} // RVA: 0x7FFAC47D8E80
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFAC47D8FD0
        public void LogBufferState(){} // RVA: 0x7FFAC47D97C0
        public void SetBufferedDisplayTime(){} // RVA: 0x7FFAC47D9B90
        public void GetBufferedFramesState(){} // RVA: 0x7FFAC47D9C50
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFAC47D9CF0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFAC47D9E10
        public void SetSlaves(){} // RVA: 0x7FFAC47D9E40
        public void IsPrerollComplete(){} // RVA: 0x7FFAC47D9FB0
        public void .cctor(){} // RVA: 0x7FFAC47DA140
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        public bool AuthenticationData; // 0xA8
        public bool _use10BitTextures; // 0xA9
        public bool _useLowLiveLatency; // 0xAA
        public RenderHeads.Media.AVProVideo.AuthData _nextAuthData; // 0xB0
        public bool _isInitialised;
        public string _version; // 0x8
        public ulong _frameTimeStamp; // 0xB8
        public UIntPtr _playerInstance; // 0xC0
        public EyeTexture[] _eyeTextures; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47DD8E0 | overloaded x2
        public void CanPlay(){} // RVA: 0x7FFAC47DDBC0
        public void Dispose(){} // RVA: 0x7FFAC47DDBE0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFAC2F21320
        public void GetCurrentTime(){} // RVA: 0x7FFAC47DDD60
        public void GetDuration(){} // RVA: 0x7FFAC47DDDE0
        public void GetPlaybackRate(){} // RVA: 0x7FFAC47DDDF0
        public void GetTexture(){} // RVA: 0x7FFAC47DDE70
        public void GetTextureCount(){} // RVA: 0x7FFAC47DDEC0
        public void GetTextureFrameCount(){} // RVA: 0x7FFAC431B350
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFAC47DDFD0
        public void GetVersion(){} // RVA: 0x7FFAC47DE050
        public void GetExpectedVersion(){} // RVA: 0x7FFAC47DE0B0
        public void GetVideoFrameRate(){} // RVA: 0x7FFAC47DE0F0
        public void GetVideoWidth(){} // RVA: 0x7FFAC47DE1A0
        public void GetVideoHeight(){} // RVA: 0x7FFAC47DE2E0
        public void GetVolume(){} // RVA: 0x7FFAC47DE420
        public void SetBalance(){} // RVA: 0x7FFAC47DE4A0
        public void GetBalance(){} // RVA: 0x7FFAC47DE530
        public void HasAudio(){} // RVA: 0x7FFAC47DE5B0
        public void HasMetaData(){} // RVA: 0x7FFAC47DE5F0
        public void HasVideo(){} // RVA: 0x7FFAC47DE620
        public void IsBuffering(){} // RVA: 0x7FFAC47DE660
        public void IsFinished(){} // RVA: 0x7FFAC47DE680
        public void IsLooping(){} // RVA: 0x7FFAC47DE730
        public void IsMuted(){} // RVA: 0x7FFAC47DE7C0
        public void IsPaused(){} // RVA: 0x7FFAC47DE850
        public void IsPlaying(){} // RVA: 0x7FFAC47DE870
        public void IsSeeking(){} // RVA: 0x7FFAC47DE890
        public void MuteAudio(){} // RVA: 0x7FFAC47DE8B0
        public void OpenMedia(){} // RVA: 0x7FFAC47DE940
        public void CloseMedia(){} // RVA: 0x7FFAC47DEB50
        public void Pause(){} // RVA: 0x7FFAC47DEBF0
        public void Play(){} // RVA: 0x7FFAC47DEC70
        public void Render(){} // RVA: 0x7FFAC47DECF0
        public void Update_Textures(){} // RVA: 0x7FFAC47DED70
        public void get_AuthenticationData(){} // RVA: 0x7FFAC2F8C040
        public void set_AuthenticationData(){} // RVA: 0x7FFAC47DF280
        public void RequiresVerticalFlip(){} // RVA: 0x7FFAC3006850
        public void Seek(){} // RVA: 0x7FFAC47DF2F0
        public void SeekFast(){} // RVA: 0x7FFAC47CC700
        public void SetLooping(){} // RVA: 0x7FFAC47DF380
        public void SetPlaybackRate(){} // RVA: 0x7FFAC47DF410
        public void SetVolume(){} // RVA: 0x7FFAC47DF4A0
        public void Stop(){} // RVA: 0x7FFAC47DF530
        public void UpdateTimeRanges(){} // RVA: 0x7FFAC47DF550
        public void UpdateTimeRange(){} // RVA: 0x7FFAC47DF5C0
        public void GetProgramDateTime(){} // RVA: 0x7FFAC47DF6D0
        public void Update(){} // RVA: 0x7FFAC47DF8D0
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFAC47DFDB0
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFAC47DFE30
        public void InternalSetActiveTrack(){} // RVA: 0x7FFAC47DFEB0
        public void InternalIsChangedTracks(){} // RVA: 0x7FFAC47DFF50
        public void InternalGetTrackCount(){} // RVA: 0x7FFAC47DFFE0
        public void InternalGetTrackInfo(){} // RVA: 0x7FFAC47E0070
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFAC47E0450
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFAC47E04E0
        public void InitialisePlatform(){} // RVA: 0x7FFAC47E05B0
        public void DeinitPlatform(){} // RVA: 0x7FFAC47E0930
        public void .cctor(){} // RVA: 0x7FFAC47E0990
    }

    public class WindowsUWP : Object
    {
    }

}