// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 33
// Methods: 920

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class ApplyToBase : MonoBehaviour
    {
        public object _overrideStereoPacking; // 0x335D9930

        // ── Original Methods ──
        public void get_Player(){} // RVA: 0x7ffaa89600c0
        public void set_Player(){} // RVA: 0x7ffaaa1d2d20
        public void get_AutomaticStereoPacking(){} // RVA: 0x7ffaa8b0edb0
        public void set_AutomaticStereoPacking(){} // RVA: 0x7ffaaa1d2d30
        public void get_OverrideStereoPacking(){} // RVA: 0x7ffaa96cc980
        public void set_OverrideStereoPacking(){} // RVA: 0x7ffaaa1d2d40
        public void get_StereoRedGreenTint(){} // RVA: 0x7ffaa8958450
        public void set_StereoRedGreenTint(){} // RVA: 0x7ffaaa1d2d50
        public void Awake(){} // RVA: 0x7ffaaa1d2d60
        public void ChangeMediaPlayer(){} // RVA: 0x7ffaaa1d2d70
        public void OnMediaPlayerEvent(){} // RVA: 0x7ffaaa1d30e0
        public void ForceUpdate(){} // RVA: 0x7ffaaa1d3100
        public void Start(){} // RVA: 0x7ffaaa1d3180
        public void OnEnable(){} // RVA: 0x7ffaaa1d31c0
        public void OnDisable(){} // RVA: 0x7ffaaa1d31f0
        public void OnDestroy(){} // RVA: 0x7ffaaa1d3210
        public void SaveProperties(){} // RVA: 0x7ffaa8932310
        public void RestoreProperties(){} // RVA: 0x7ffaa8932310
        public void Apply(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8969bb0
    }

    public class ApplyToMaterial : ApplyToBase
    {
        public object _texturePropertyName; // 0x337C4F10
        public object _lastTextureApplied; // 0x337C4F10
        public object _originalScale; // 0x337C4F10
        public object _id; // 0x82695350
        public object DefaultTexture; // 0x17000004
        public object Material; // 0x17000005

        // ── Original Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7ffaa8bf45b0
        public void set_DefaultTexture(){} // RVA: 0x7ffaaa1bcae0
        public void get_Material(){} // RVA: 0x7ffaa89af740
        public void set_Material(){} // RVA: 0x7ffaaa1bcc50
        public void get_TexturePropertyName(){} // RVA: 0x7ffaa89ad730
        public void set_TexturePropertyName(){} // RVA: 0x7ffaaa1bcdc0
        public void get_Offset(){} // RVA: 0x7ffaaa1bcf40
        public void set_Offset(){} // RVA: 0x7ffaaa1bcf60
        public void get_Scale(){} // RVA: 0x7ffaaa1bcfb0
        public void set_Scale(){} // RVA: 0x7ffaaa1bcfd0
        public void LateUpdate(){} // RVA: 0x7ffaa8b17b80
        public void Apply(){} // RVA: 0x7ffaaa1bd020
        public void ApplyMapping(){} // RVA: 0x7ffaaa1bd5b0
        public void SaveProperties(){} // RVA: 0x7ffaaa1bdca0
        public void RestoreProperties(){} // RVA: 0x7ffaaa1bdff0
        public void .ctor(){} // RVA: 0x7ffaaa1be1d0
    }

    public class ApplyToMesh : ApplyToBase
    {
        public object _materialIndex; // 0x33CC63D0
        public object _scale; // 0x33CC63D0

        // ── Original Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7ffaa8bf45b0
        public void set_DefaultTexture(){} // RVA: 0x7ffaaa1be3b0
        public void get_MeshRenderer(){} // RVA: 0x7ffaa89af740
        public void set_MeshRenderer(){} // RVA: 0x7ffaaa1be530
        public void get_MaterialIndex(){} // RVA: 0x7ffaa89d30c0
        public void set_MaterialIndex(){} // RVA: 0x7ffaa89d30d0
        public void ChangeDefaultTexture(){} // RVA: 0x7ffaaa1be3b0
        public void ChangeRenderer(){} // RVA: 0x7ffaaa1be540
        public void get_TexturePropertyName(){} // RVA: 0x7ffaa89d30e0
        public void set_TexturePropertyName(){} // RVA: 0x7ffaaa1be7d0
        public void get_Offset(){} // RVA: 0x7ffaaa1bcfb0
        public void set_Offset(){} // RVA: 0x7ffaaa1bcfd0
        public void get_Scale(){} // RVA: 0x7ffaaa1be950
        public void set_Scale(){} // RVA: 0x7ffaaa1be970
        public void LateUpdate(){} // RVA: 0x7ffaa8b17b80
        public void Apply(){} // RVA: 0x7ffaaa1be9c0
        public void ApplyMapping(){} // RVA: 0x7ffaaa1bef60
        public void OnEnable(){} // RVA: 0x7ffaaa1bf6b0
        public void OnDisable(){} // RVA: 0x7ffaaa1bf9b0
        public void .ctor(){} // RVA: 0x7ffaaa1bf9e0
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_Channel(){} // RVA: 0x7ffaa89600c0
        public void set_Channel(){} // RVA: 0x7ffaa89600d0
        public void Reset(){} // RVA: 0x7ffaaa1bfb30
        public void ChangeChannelCount(){} // RVA: 0x7ffaaa1bfbf0
        public void OnAudioFilterRead(){} // RVA: 0x7ffaaa1bfd40
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class AudioOutput : MonoBehaviour
    {
        public object _channelMask; // 0x3361A150

        // ── Original Methods ──
        public void get_Player(){} // RVA: 0x7ffaa89600c0
        public void set_Player(){} // RVA: 0x7ffaaa1bff30
        public void get_OutputMode(){} // RVA: 0x7ffaa8d14570
        public void set_OutputMode(){} // RVA: 0x7ffaa90c0cd0
        public void get_ChannelMask(){} // RVA: 0x7ffaa96cc980
        public void set_ChannelMask(){} // RVA: 0x7ffaa9fdb500
        public void Awake(){} // RVA: 0x7ffaaa1bff40
        public void Start(){} // RVA: 0x7ffaaa1bffd0
        public void OnAudioConfigurationChanged(){} // RVA: 0x7ffaaa1c0060
        public void OnDestroy(){} // RVA: 0x7ffaaa1c01b0
        public void Update(){} // RVA: 0x7ffaaa1c01c0
        public void ChangeMediaPlayer(){} // RVA: 0x7ffaaa1c0300
        public void OnMediaPlayerEvent(){} // RVA: 0x7ffaaa1c0a10
        public void ApplyAudioSettings(){} // RVA: 0x7ffaa8932310
        public void OnAudioFilterRead(){} // RVA: 0x7ffaaa1c0ad0
        public void .ctor(){} // RVA: 0x7ffaaa1c0ca0
        // ── Binary Analysis Named ──
        public void GetAudioSource(){} // RVA: 0x7ffaa8bf45b0
    }

    public class AudioOutputManager : Object
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaa1d3220
        public void .ctor(){} // RVA: 0x7ffaaa1d33a0
        public void RequestAudio(){} // RVA: 0x7ffaaa1d3460
        public void ZeroAudio(){} // RVA: 0x7ffaaa1d3df0
        public void GrabAudio(){} // RVA: 0x7ffaaa1d3e30
    }

    public class BaseMediaPlayer : Object
    {
        public object _defaultTextureFilterMode; // 0x33541150
        public object _mediaHints; // 0x33541150
        public object _displayRateTimer; // 0x33541150
        public object _stallDetectionTimer; // 0x33541150
        public object _subtitles; // 0x33541150
        public object _playbackQualityStats; // 0x33541150
        public object _audioTracks; // 0x33541150

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa1d3f50
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7ffaa8932320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7ffaa8932320
        public void AddChunkToMediaBuffer(){} // RVA: 0x7ffaa8932320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7ffaa8932320
        public void CloseMedia(){} // RVA: 0x7ffaaa1d44e0
        public void IsLooping(){} // RVA: 0x7ffaa864a040
        public void HasMetaData(){} // RVA: 0x7ffaa864a040
        public void CanPlay(){} // RVA: 0x7ffaa864a040
        public void Play(){} // RVA: 0x7ffaa8660cc0
        public void Pause(){} // RVA: 0x7ffaa8660cc0
        public void Stop(){} // RVA: 0x7ffaa8660cc0
        public void Rewind(){} // RVA: 0x7ffaaa1d45d0
        public void Seek(){} // RVA: 0x7ffaa86623c0
        public void SeekFast(){} // RVA: 0x7ffaa86623c0
        public void SeekWithTolerance(){} // RVA: 0x7ffaaa1d45f0
        public void HasAudio(){} // RVA: 0x7ffaa864a040
        public void HasVideo(){} // RVA: 0x7ffaa864a040
        public void IsVideoStereo(){} // RVA: 0x7ffaaa1d4670
        public void IsSeeking(){} // RVA: 0x7ffaa864a040
        public void IsPlaying(){} // RVA: 0x7ffaa864a040
        public void IsPaused(){} // RVA: 0x7ffaa864a040
        public void IsFinished(){} // RVA: 0x7ffaa864a040
        public void IsBuffering(){} // RVA: 0x7ffaa864a040
        public void WaitForNextFrame(){} // RVA: 0x7ffaa8932320
        public void SupportsTextureFrameCount(){} // RVA: 0x7ffaa8a17850
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaa864a040
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7ffaa8649ca0
        public void MuteAudio(){} // RVA: 0x7ffaa86613a0
        public void IsMuted(){} // RVA: 0x7ffaa864a040
        public void GrabAudio(){} // RVA: 0x7ffaa8f22da0
        public void AudioConfigurationChanged(){} // RVA: 0x7ffaa8932310
        public void ResetAudioHeadRotation(){} // RVA: 0x7ffaa8932310
        public void ResetAudioFocus(){} // RVA: 0x7ffaa8932310
        public void IsMediaCachingSupported(){} // RVA: 0x7ffaa8932320
        public void AddMediaToCache(){} // RVA: 0x7ffaa8932310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7ffaa8932310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7ffaa8932310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7ffaa8932310
        public void RemoveMediaFromCache(){} // RVA: 0x7ffaa8932310
        public void IsExternalPlaybackSupported(){} // RVA: 0x7ffaa8932320
        public void IsExternalPlaybackActive(){} // RVA: 0x7ffaa8932320
        public void Update(){} // RVA: 0x7ffaa8660cc0
        public void Render(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void EndUpdate(){} // RVA: 0x7ffaa8932310
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7ffaa8a17850
        public void ApplyTextureProperties(){} // RVA: 0x7ffaaa1d48c0
        public void UpdateDisplayFrameRate(){} // RVA: 0x7ffaaa1d4a70
        public void IsExpectingNewVideoFrame(){} // RVA: 0x7ffaaa1d4b40
        public void IsPlaybackStalled(){} // RVA: 0x7ffaaa1d4c40
        public void LoadSubtitlesSRT(){} // RVA: 0x7ffaaa1d4e70
        public void UpdateSubtitles(){} // RVA: 0x7ffaaa1d5030
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void SeekToFrameRelative(){} // RVA: 0x7ffaaa1d5400
        public void SeekToFrame(){} // RVA: 0x7ffaaa1d5550
        public void UpdateBufferedDisplay(){} // RVA: 0x7ffaaa1d5660
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7ffaa8f22da0
        public void UpdateTextCue(){} // RVA: 0x7ffaaa1d5750
        public void InternalIsChangedTextCue(){} // RVA: 0x7ffaa864a040
        public void InternalGetCurrentTextCue(){} // RVA: 0x7ffaa86491d0
        public void InternalIsChangedTracks(){} // RVA: 0x7ffaa864a650
        public void InternalGetTrackCount(){} // RVA: 0x7ffaa8650410
        public void InternalSetActiveTrack(){}
        public void InternalGetTrackInfo(){}
        public void InitTracks(){} // RVA: 0x7ffaaa1d5a60
        public void UpdateTracks(){} // RVA: 0x7ffaaa1d5bf0
        public void PopulateTrackCollection(){} // RVA: 0x7ffaaa1d5ca0
        // ── Binary Analysis Named ──
        public void GetVersion(){} // RVA: 0x7ffaa86491d0
        public void GetExpectedVersion(){} // RVA: 0x7ffaa86491d0
        public void SetLooping(){} // RVA: 0x7ffaa86613a0
        public void GetCurrentTime(){} // RVA: 0x7ffaa864eea0
        public void GetProgramDateTime(){} // RVA: 0x7ffaaa1d4610
        public void GetPlaybackRate(){} // RVA: 0x7ffaa865dbc0
        public void SetPlaybackRate(){} // RVA: 0x7ffaa866e7c0
        public void GetDuration(){} // RVA: 0x7ffaa864eea0
        public void GetVideoWidth(){} // RVA: 0x7ffaa8649ca0
        public void GetVideoHeight(){} // RVA: 0x7ffaa8649ca0
        public void GetVideoFrameRate(){} // RVA: 0x7ffaa865dbc0
        public void GetVideoDisplayRate(){} // RVA: 0x7ffaa899a460
        public void GetTextureCount(){} // RVA: 0x7ffaa8a24af0
        public void GetTexture(){} // RVA: 0x7ffaa8658120
        public void GetTextureFrameCount(){} // RVA: 0x7ffaa8649ca0
        public void GetTextureTimeStamp(){} // RVA: 0x7ffaaa1d46a0
        public void GetTextureTransform(){} // RVA: 0x7ffaaa1d46b0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7ffaa99e01b0
        public void GetYpCbCrTransform(){} // RVA: 0x7ffaaa1d4720
        public void GetTextureStereoPacking(){} // RVA: 0x7ffaaa1d4780
        public void GetTextureTransparency(){} // RVA: 0x7ffaa8d14570
        public void GetTextureAlphaPacking(){} // RVA: 0x7ffaaa1d47b0
        public void SetVolume(){} // RVA: 0x7ffaa866e7c0
        public void SetBalance(){} // RVA: 0x7ffaa8932310
        public void GetVolume(){} // RVA: 0x7ffaa865dbc0
        public void GetBalance(){} // RVA: 0x7ffaa916f990
        public void GetAudioChannelCount(){} // RVA: 0x7ffaa8ce12f0
        public void GetAudioChannelMask(){} // RVA: 0x7ffaa8f22da0
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7ffaa8f22da0
        public void SetAudioHeadRotation(){} // RVA: 0x7ffaa8932310
        public void SetAudioChannelMode(){} // RVA: 0x7ffaa8932310
        public void SetAudioFocusEnabled(){} // RVA: 0x7ffaa8932310
        public void SetAudioFocusProperties(){} // RVA: 0x7ffaa8932310
        public void SetAudioFocusRotation(){} // RVA: 0x7ffaa8932310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7ffaaa1d47f0
        public void SetPlayWithoutBuffering(){} // RVA: 0x7ffaa8932310
        public void GetCachedMediaStatus(){} // RVA: 0x7ffaa8f22da0
        public void SetAllowsExternalPlayback(){} // RVA: 0x7ffaa8932310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7ffaa8932310
        public void SetKeyServerAuthToken(){} // RVA: 0x7ffaa8932310
        public void SetOverrideDecryptionKey(){} // RVA: 0x7ffaa8932310
        public void BeginRender(){} // RVA: 0x7ffaa8932310
        public void GetDecoderPerformance(){} // RVA: 0x7ffaa8932320
        public void GetNativePlayerHandle(){} // RVA: 0x7ffaa8f22da0
        public void GetLastError(){} // RVA: 0x7ffaaa1d4800
        public void GetLastExtendedErrorCode(){} // RVA: 0x7ffaa8f22da0
        public void GetPlayerDescription(){} // RVA: 0x7ffaa894d380
        public void GetSeekableTimes(){} // RVA: 0x7ffaa8bf45b0
        public void GetBufferedTimes(){} // RVA: 0x7ffaa89af740
        public void GetTextureProperties(){} // RVA: 0x7ffaaa1d4810
        public void SetTextureProperties(){} // RVA: 0x7ffaaa1d4830
        public void GetSubtitleIndex(){} // RVA: 0x7ffaaa1d5190
        public void GetSubtitleText(){} // RVA: 0x7ffaaa1d51b0
        public void GetCurrentTimeFrames(){} // RVA: 0x7ffaaa1d5230
        public void GetDurationFrames(){} // RVA: 0x7ffaaa1d5320
        public void GetMaxFrameNumber(){} // RVA: 0x7ffaaa1d53e0
        public void GetBufferedFramesState(){} // RVA: 0x7ffaaa1d5730
        public void SetSlaves(){} // RVA: 0x7ffaa8932310
        public void SetBufferedDisplayMode(){} // RVA: 0x7ffaa8932310
        public void SetBufferedDisplayOptions(){} // RVA: 0x7ffaa8932310
        public void GetPlaybackQualityStats(){} // RVA: 0x7ffaa8af68f0
        public void GetCurrentTextCue(){} // RVA: 0x7ffaa8d1a3b0
        public void GetVideoTracks(){} // RVA: 0x7ffaa8971010
        public void GetAudioTracks(){} // RVA: 0x7ffaa8d1b980
        public void GetTextTracks(){} // RVA: 0x7ffaa8f75d20
        public void GetActiveVideoTrack(){} // RVA: 0x7ffaaa1d5910
        public void GetActiveAudioTrack(){} // RVA: 0x7ffaaa1d5960
        public void GetActiveTextTrack(){} // RVA: 0x7ffaaa1d59b0
        public void SetActiveVideoTrack(){} // RVA: 0x7ffaaa1d5a00
        public void SetActiveAudioTrack(){} // RVA: 0x7ffaaa1d5a20
        public void SetActiveTextTrack(){} // RVA: 0x7ffaaa1d5a40
        public void SetActiveTrack(){} // RVA: 0x7ffaaa1d5e90
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        public object _color; // 0x33856980
        public object _depth; // 0x33856980
        public object _areaY; // 0x33856980
        public object _showAreaInEditor; // 0x33856980

        // ── Original Methods ──
        public void get_Player(){} // RVA: 0x7ffaa89600c0
        public void set_Player(){} // RVA: 0x7ffaaa1c0d00
        public void get_ScaleMode(){} // RVA: 0x7ffaa8d14570
        public void set_ScaleMode(){} // RVA: 0x7ffaa90c0cd0
        public void get_Color(){} // RVA: 0x7ffaaa1c0e30
        public void set_Color(){} // RVA: 0x7ffaaa1c0e40
        public void get_AllowTransparency(){} // RVA: 0x7ffaa8a974e0
        public void set_AllowTransparency(){} // RVA: 0x7ffaa8a974f0
        public void get_UseDepth(){} // RVA: 0x7ffaa999d3b0
        public void set_UseDepth(){} // RVA: 0x7ffaaa1c0e50
        public void get_Depth(){} // RVA: 0x7ffaa89d3080
        public void set_Depth(){} // RVA: 0x7ffaa89d3090
        public void get_IsAreaFullScreen(){} // RVA: 0x7ffaa9fc9180
        public void set_IsAreaFullScreen(){} // RVA: 0x7ffaa9fc9190
        public void get_AreaX(){} // RVA: 0x7ffaa9fe53d0
        public void set_AreaX(){} // RVA: 0x7ffaa9fe6140
        public void get_AreaY(){} // RVA: 0x7ffaa9168110
        public void set_AreaY(){} // RVA: 0x7ffaa9167b70
        public void get_AreaWidth(){} // RVA: 0x7ffaa899a460
        public void set_AreaWidth(){} // RVA: 0x7ffaa899a470
        public void get_AreaHeight(){} // RVA: 0x7ffaa8dbada0
        public void set_AreaHeight(){} // RVA: 0x7ffaa8db9c30
        public void get_ShowAreaInEditor(){} // RVA: 0x7ffaa8b6c110
        public void set_ShowAreaInEditor(){} // RVA: 0x7ffaa92bb760
        public void Start(){} // RVA: 0x7ffaaa1c0e60
        public void Update(){} // RVA: 0x7ffaaa1c1100
        public void OnDestroy(){} // RVA: 0x7ffaaa1c11e0
        public void OnGUI(){} // RVA: 0x7ffaaa1c1b20
        public void .ctor(){} // RVA: 0x7ffaaa1c2550
        // ── Binary Analysis Named ──
        public void GetRequiredShader(){} // RVA: 0x7ffaaa1c1320
        public void SetupMaterial(){} // RVA: 0x7ffaaa1c16d0
        public void GetAreaRect(){} // RVA: 0x7ffaaa1c22d0
    }

    public class DisplayUGUI : MaskableGraphic
    {
        public object _uvRect; // 0x33416340
        public object _noDefaultDisplay; // 0x33416340
        public object _lastHeight; // 0x33416340
        public object _lastTexture; // 0x33416340
        public object _shaderAndroidOES; // 0x33416340
        public object _material; // 0x33416340

        // ── Original Methods ──
        public void get_Player(){} // RVA: 0x7ffaa89b3900
        public void set_Player(){} // RVA: 0x7ffaaa1b7e50
        public void get_DefaultTexture(){} // RVA: 0x7ffaa89b3970
        public void set_DefaultTexture(){} // RVA: 0x7ffaaa1b7e60
        public void get_UVRect(){} // RVA: 0x7ffaaa1b7fe0
        public void set_UVRect(){} // RVA: 0x7ffaaa1b7ff0
        public void get_ApplyNativeSize(){} // RVA: 0x7ffaa96c9090
        public void set_ApplyNativeSize(){} // RVA: 0x7ffaa96c8b10
        public void get_ScaleMode(){} // RVA: 0x7ffaaa1b8000
        public void set_ScaleMode(){} // RVA: 0x7ffaa9f3c2c0
        public void get_NoDefaultDisplay(){} // RVA: 0x7ffaa9bdabb0
        public void set_NoDefaultDisplay(){} // RVA: 0x7ffaa9bdabc0
        public void get_DisplayInEditor(){} // RVA: 0x7ffaa9fee6b0
        public void set_DisplayInEditor(){} // RVA: 0x7ffaa9fee670
        public void Awake(){} // RVA: 0x7ffaaa1b8010
        public void OnMediaPlayerEvent(){} // RVA: 0x7ffaaa1b8160
        public void ChangeMediaPlayer(){} // RVA: 0x7ffaaa1b82d0
        public void EnsureShader(){} // RVA: 0x7ffaaa1b8650
        public void EnsureAlphaPackingShader(){} // RVA: 0x7ffaaa1b8810
        public void EnsureStereoPackingShader(){} // RVA: 0x7ffaaa1b8900
        public void EnsureAndroidOESShader(){} // RVA: 0x7ffaaa1b89f0
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x7ffaaa1b8ae0
        public void Start(){} // RVA: 0x7ffaaa1b8bd0
        public void OnDestroy(){} // RVA: 0x7ffaaa1b8d80
        public void get_mainTexture(){} // RVA: 0x7ffaaa1b9510
        public void HasValidTexture(){} // RVA: 0x7ffaaa1b9710
        public void UpdateInternalMaterial(){} // RVA: 0x7ffaaa1b9970
        public void LateUpdate(){} // RVA: 0x7ffaaa1b9e00
        public void get_CurrentMediaPlayer(){} // RVA: 0x7ffaa89b3900
        public void set_CurrentMediaPlayer(){} // RVA: 0x7ffaaa1ba490
        public void get_uvRect(){} // RVA: 0x7ffaaa1b7fe0
        public void set_uvRect(){} // RVA: 0x7ffaaa1ba620
        public void OnPopulateMesh(){} // RVA: 0x7ffaaa1baaf0
        public void _OnFillVBO(){} // RVA: 0x7ffaaa1baba0
        public void .ctor(){} // RVA: 0x7ffaaa1bb820
        public void .cctor(){} // RVA: 0x7ffaaa1bb9a0
        // ── Binary Analysis Named ──
        public void GetRequiredShader(){} // RVA: 0x7ffaaa1b8f10
        public void SetNativeSize(){} // RVA: 0x7ffaaa1ba690
        public void GetDrawingDimensions(){} // RVA: 0x7ffaaa1bb060
    }

    public class Helper : Object
    {
        public object UnityBaseTextureName_URP; // 0x338766A0
        public object MilliSecondsToHNS; // 0x338766A0
        public object LandscapeFlippedMatrix; // 0x338766A0

        // ── Original Methods ──
        public void LogInfo(){} // RVA: 0x7ffaaa1d7270
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x7ffaaa1d7e50
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x7ffaaa1d7ef0
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x7ffaaa1d7f30
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7ffaaa1d8080
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x7ffaaa1d82d0
        public void .cctor(){} // RVA: 0x7ffaaa1d8de0
        // ── Binary Analysis Named ──
        public void GetPath(){} // RVA: 0x7ffaaa1d64e0
        public void GetFilePath(){} // RVA: 0x7ffaaa1d6660
        public void GetFriendlyResolutionName(){} // RVA: 0x7ffaaa1d68b0
        public void GetErrorMessage(){} // RVA: 0x7ffaaa1d6c20
        public void GetPlatformName(){} // RVA: 0x7ffaaa1d6db0
        public void GetPlatformNames(){} // RVA: 0x7ffaaa1d6e60
        public void GetUnityAudioSampleRate(){} // RVA: 0x7ffaaa1d73d0
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x7ffaaa1d7480
        public void GetTimelineRange(){} // RVA: 0x7ffaaa1d7560
        public void GetTimeString(){} // RVA: 0x7ffaaa1d75c0
        public void GetOrientation(){} // RVA: 0x7ffaaa1d7a20
        public void GetMatrixForOrientation(){} // RVA: 0x7ffaaa1d7c30
        public void GetShortPathName(){} // RVA: 0x7ffaaa1d81e0
        public void GetReadableTexture(){} // RVA: 0x7ffaaa1d8ac0
        public void GetReadableTexture(){} // RVA: 0x7ffaaa1d8ac0
    }

    public class HttpHeader : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
        public void IsComplete(){} // RVA: 0x7ffaaa1eac00
        public void ToValidatedString(){} // RVA: 0x7ffaaa1eac30
        public void IsValid(){} // RVA: 0x7ffaaa1eae30
        public void IsAscii(){} // RVA: 0x7ffaaa1eadd0
        public void IsValid(){} // RVA: 0x7ffaaa1eae30
    }

    public class IMediaPlayer
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa8660cc0
        public void Update(){} // RVA: 0x7ffaa8660cc0
        public void EndUpdate(){} // RVA: 0x7ffaa8660cc0
        public void Render(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void BeginRender(){} // RVA: 0x7ffaa8660cc0
        public void GetNativePlayerHandle(){} // RVA: 0x7ffaa86491d0
    }

    public class ITextureProducer
    {
        // ── Original Methods ──
        public void SupportsTextureFrameCount(){} // RVA: 0x7ffaa864a040
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void GetTextureCount(){} // RVA: 0x7ffaa8649ca0
        public void GetTexture(){} // RVA: 0x7ffaa8658120
        public void GetTextureFrameCount(){} // RVA: 0x7ffaa8649ca0
        public void GetTextureTimeStamp(){} // RVA: 0x7ffaa86491d0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7ffaa865dbc0
        public void GetTextureStereoPacking(){} // RVA: 0x7ffaa8649ca0
        public void GetTextureTransparency(){} // RVA: 0x7ffaa8649ca0
        public void GetTextureAlphaPacking(){} // RVA: 0x7ffaa8649ca0
        public void GetYpCbCrTransform(){}
    }

    public class KeyAuthData : Object
    {
        public object overrideDecryptionKey; // 0x334151E0

        // ── Original Methods ──
        public void IsModified(){} // RVA: 0x7ffaaa1eb4c0
        public void OnBeforeSerialize(){} // RVA: 0x7ffaaa1eb4f0
        public void OnAfterDeserialize(){} // RVA: 0x7ffaaa1eb560
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class MediaHints : ValueType
    {
        public object stereoPacking; // 0x36807580

        // ── Original Methods ──
        public void get_Default(){} // RVA: 0x7ffaaa1d9830
        public void .cctor(){} // RVA: 0x7ffaa8932310
    }

    public class MediaPlayer : MonoBehaviour
    {
        public object _mediaPath; // 0x33784CC0
        public object _autoPlayOnStart; // 0x33784CC0
        public object _audioBalance; // 0x33784CC0
        public object _playbackRate; // 0x33784CC0
        public object _resampleBufferSize; // 0x33784CC0
        public object _textureFilterMode; // 0x33784CC0
        public object _sideloadSubtitles; // 0x33784CC0
        public object _audioFocusEnabled; // 0x33784CC0
        public object _audioFocusOffLevelDB; // 0x33784CC0
        public object _events; // 0x33784CC0
        public object _playMediaOnAppUnpause; // 0x33784CC0
        public object _baseMediaPlayer; // 0x33784CC0
        public object _infoInterface; // 0x33784CC0
        public object _cacheInterface; // 0x33784CC0
        public object _audioTracksInterface; // 0x33784CC0
        public object _isMediaOpened; // 0x33784CC0
        public object _renderingCoroutine; // 0x33784CC0
        public object _queueSubtitlePath; // 0x33784CC0
        public object enableAVProInProton; // 0x33784CC0
        public object _eventFired_Started; // 0x33784CC0
        public object _eventState_PlaybackBuffering; // 0x33784CC0
        public object _eventState_PreviousWidth; // 0x33784CC0
        public object _finishedFrameOpenCheck; // 0x33784CC0
        public object _optionsIOS; // 0x33784CC0
        public object _optionsWindowsUWP; // 0x33784CC0
        public object m_VideoLocation; // 0x33784CC0
        public object stereoPacking; // 0x36807580

        // ── Original Methods ──
        public void get_MediaSource(){} // RVA: 0x7ffaa8aeced0
        public void set_MediaSource(){} // RVA: 0x7ffaa900aa90
        public void get_MediaReference(){} // RVA: 0x7ffaa8960130
        public void set_MediaReference(){} // RVA: 0x7ffaa8933e90
        public void get_MediaPath(){} // RVA: 0x7ffaa8bfcc80
        public void set_MediaPath(){} // RVA: 0x7ffaa8960890
        public void get_FallbackMediaHints(){} // RVA: 0x7ffaa8998f40
        public void set_FallbackMediaHints(){} // RVA: 0x7ffaa8998f60
        public void get_AutoOpen(){} // RVA: 0x7ffaa9fc9180
        public void set_AutoOpen(){} // RVA: 0x7ffaa9fc9190
        public void get_AutoStart(){} // RVA: 0x7ffaaa1c25c0
        public void set_AutoStart(){} // RVA: 0x7ffaaa1c25d0
        public void get_Loop(){} // RVA: 0x7ffaaa1c25e0
        public void set_Loop(){} // RVA: 0x7ffaaa1c2640
        public void get_AudioVolume(){} // RVA: 0x7ffaaa1c26b0
        public void set_AudioVolume(){} // RVA: 0x7ffaaa1c2710
        public void get_AudioBalance(){} // RVA: 0x7ffaaa1c27a0
        public void set_AudioBalance(){} // RVA: 0x7ffaaa1c2800
        public void get_AudioMuted(){} // RVA: 0x7ffaaa1c2890
        public void set_AudioMuted(){} // RVA: 0x7ffaaa1c28f0
        public void get_AudioSource(){} // RVA: 0x7ffaa89fa500
        public void set_AudioSource(){} // RVA: 0x7ffaa89fa510
        public void get_PlaybackRate(){} // RVA: 0x7ffaaa1c2960
        public void set_PlaybackRate(){} // RVA: 0x7ffaaa1c29c0
        public void get_UseResampler(){} // RVA: 0x7ffaa9970570
        public void set_UseResampler(){} // RVA: 0x7ffaaa1c2a30
        public void get_ResampleMode(){} // RVA: 0x7ffaaa1c2a40
        public void set_ResampleMode(){} // RVA: 0x7ffaaa1c2a50
        public void get_ResampleBufferSize(){} // RVA: 0x7ffaaa1c2a60
        public void set_ResampleBufferSize(){} // RVA: 0x7ffaaa1c2a70
        public void get_FrameResampler(){} // RVA: 0x7ffaa89fa590
        public void get_VideoLayoutMapping(){} // RVA: 0x7ffaa9fb1a70
        public void set_VideoLayoutMapping(){} // RVA: 0x7ffaa9fb1a60
        public void get_TextureFilterMode(){} // RVA: 0x7ffaaa1c2a80
        public void set_TextureFilterMode(){} // RVA: 0x7ffaaa1c2b80
        public void get_TextureWrapMode(){} // RVA: 0x7ffaaa1c2c00
        public void set_TextureWrapMode(){} // RVA: 0x7ffaaa1c2d00
        public void get_TextureAnisoLevel(){} // RVA: 0x7ffaaa1c2d80
        public void set_TextureAnisoLevel(){} // RVA: 0x7ffaaa1c2e80
        public void get_SideloadSubtitles(){} // RVA: 0x7ffaa98372b0
        public void set_SideloadSubtitles(){} // RVA: 0x7ffaa9836fb0
        public void get_SubtitlePath(){} // RVA: 0x7ffaa8d1b980
        public void set_SubtitlePath(){} // RVA: 0x7ffaa8f7b070
        public void set_AudioHeadTransform(){} // RVA: 0x7ffaa8f7b0d0
        public void get_AudioHeadTransform(){} // RVA: 0x7ffaa8f75d20
        public void get_AudioFocusEnabled(){} // RVA: 0x7ffaa9feeae0
        public void set_AudioFocusEnabled(){} // RVA: 0x7ffaa91d7fd0
        public void get_AudioFocusTransform(){} // RVA: 0x7ffaa8f74720
        public void set_AudioFocusTransform(){} // RVA: 0x7ffaa8d71dc0
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x7ffaa988d6d0
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x7ffaa970e680
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x7ffaaa1c2f00
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x7ffaaa1c2f10
        public void get_HttpHeaders(){} // RVA: 0x7ffaa899d0b0
        public void set_HttpHeaders(){} // RVA: 0x7ffaa899d0c0
        public void get_KeyAuth(){} // RVA: 0x7ffaa899d120
        public void set_KeyAuth(){} // RVA: 0x7ffaa899d130
        public void get_Events(){} // RVA: 0x7ffaaa1c2f20
        public void get_EventMask(){} // RVA: 0x7ffaa90bdfd0
        public void set_EventMask(){} // RVA: 0x7ffaa9fb8260
        public void get_PauseMediaOnAppPause(){} // RVA: 0x7ffaaa1c2fe0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x7ffaaa1c2ff0
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x7ffaaa1c3000
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x7ffaaa1c3010
        public void get_Persistent(){} // RVA: 0x7ffaaa1c3020
        public void set_Persistent(){} // RVA: 0x7ffaaa1c3030
        public void get_ForceFileFormat(){} // RVA: 0x7ffaaa1c3040
        public void set_ForceFileFormat(){} // RVA: 0x7ffaaa1c3050
        public void get_Info(){} // RVA: 0x7ffaa8d57210
        public void get_Control(){} // RVA: 0x7ffaa89b3970
        public void get_Player(){} // RVA: 0x7ffaa8f205f0
        public void get_TextureProducer(){} // RVA: 0x7ffaa899d2a0
        public void get_Subtitles(){} // RVA: 0x7ffaa9102670
        public void get_VideoTracks(){} // RVA: 0x7ffaa8b68c40
        public void get_AudioTracks(){} // RVA: 0x7ffaa8f78450
        public void get_TextTracks(){} // RVA: 0x7ffaa8f7aa40
        public void get_Cache(){} // RVA: 0x7ffaa8f76f40
        public void get_BufferedDisplay(){} // RVA: 0x7ffaa8de7450
        public void get_MediaOpened(){} // RVA: 0x7ffaaa1c3060
        public void Awake(){} // RVA: 0x7ffaaa1c3070
        public void Initialise(){} // RVA: 0x7ffaaa1c3110
        public void Start(){} // RVA: 0x7ffaaa1c3b10
        public void OpenMedia(){} // RVA: 0x7ffaaa1c3dd0
        public void OpenMedia(){} // RVA: 0x7ffaaa1c3dd0
        public void OpenMedia(){} // RVA: 0x7ffaaa1c3dd0
        public void OpenMedia(){} // RVA: 0x7ffaaa1c3dd0
        public void InternalOpenMedia(){} // RVA: 0x7ffaaa1c3e00
        public void CloseMedia(){} // RVA: 0x7ffaaa1c47f0
        public void RewindPrerollPause(){} // RVA: 0x7ffaaa1c4990
        public void Play(){} // RVA: 0x7ffaaa1c4a80
        public void Pause(){} // RVA: 0x7ffaaa1c4b20
        public void Stop(){} // RVA: 0x7ffaaa1c4ba0
        public void Rewind(){} // RVA: 0x7ffaaa1c4c00
        public void SeekToLiveTime(){} // RVA: 0x7ffaaa1c4c90
        public void Update(){} // RVA: 0x7ffaaa1c4d30
        public void LateUpdate(){} // RVA: 0x7ffaaa1c4f60
        public void UpdateResampler(){} // RVA: 0x7ffaaa1c5140
        public void OnEnable(){} // RVA: 0x7ffaaa1c52d0
        public void OnDisable(){} // RVA: 0x7ffaaa1c5350
        public void OnDestroy(){} // RVA: 0x7ffaaa1c53f0
        public void ForceDispose(){} // RVA: 0x7ffaaa1c5a50
        public void AllPlayersDispose(){} // RVA: 0x7ffaaa1c5b00
        public void HandleApplicationQuit(){} // RVA: 0x7ffaaa1c5c40
        public void StartRenderCoroutine(){} // RVA: 0x7ffaaa1c5f60
        public void StopRenderCoroutine(){} // RVA: 0x7ffaaa1c6080
        public void FinalRenderCapture(){} // RVA: 0x7ffaaa1c6100
        public void CreateMediaPlayer(){} // RVA: 0x7ffaaa1c65f0
        public void CreateMediaPlayerNull(){} // RVA: 0x7ffaaa1c6580
        public void CreateMediaPlayer(){} // RVA: 0x7ffaaa1c65f0
        public void UpdateAudioFocus(){} // RVA: 0x7ffaaa1c69a0
        public void UpdateAudioHeadTransform(){} // RVA: 0x7ffaaa1c6c20
        public void UpdateErrors(){} // RVA: 0x7ffaaa1c6e40
        public void IsUsingAndroidOESPath(){} // RVA: 0x7ffaaa1c70f0
        public void OnApplicationFocus(){} // RVA: 0x7ffaa8932310
        public void OnApplicationPause(){} // RVA: 0x7ffaa8932310
        public void ResetEvents(){} // RVA: 0x7ffaaa1c7140
        public void UpdateEvents(){} // RVA: 0x7ffaaa1c7170
        public void IsHandleEvent(){} // RVA: 0x7ffaaa1c7650
        public void FireEventIfPossible(){} // RVA: 0x7ffaaa1c7680
        public void CanFireEvent(){} // RVA: 0x7ffaaa1c7710
        public void ForceWaitForNewFrame(){} // RVA: 0x7ffaaa1c7bb0
        public void ExtractFrameCoroutine(){} // RVA: 0x7ffaaa1c8250
        public void ExtractFrameAsync(){} // RVA: 0x7ffaaa1c83d0
        public void ExtractFrame(){} // RVA: 0x7ffaaa1c8760
        public void ExtractFrame(){} // RVA: 0x7ffaaa1c8760
        public void OpenMediaFromBuffer(){} // RVA: 0x7ffaaa1c8a00
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x7ffaaa1c8b00
        public void AddChunkToVideoBuffer(){} // RVA: 0x7ffaaa1c8d80
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x7ffaaa1c8ea0
        public void OpenMediaFromBufferInternal(){} // RVA: 0x7ffaaa1c8f30
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x7ffaaa1c9190
        public void AddChunkToBufferInternal(){} // RVA: 0x7ffaaa1c8d80
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x7ffaaa1c8ea0
        public void get_PlatformOptionsWindows(){} // RVA: 0x7ffaa8d92160
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7ffaa8f74160
        public void get_PlatformOptionsIOS(){} // RVA: 0x7ffaa8f6f0b0
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7ffaa8f77bc0
        public void get_PlatformOptionsAndroid(){} // RVA: 0x7ffaa8f75d50
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x7ffaa8f74750
        public void get_PlatformOptionsWebGL(){} // RVA: 0x7ffaa8f6f0e0
        public void EnableSubtitles(){} // RVA: 0x7ffaaa1c9370
        public void LoadSubtitlesCoroutine(){} // RVA: 0x7ffaaa1c97c0
        public void DisableSubtitles(){} // RVA: 0x7ffaaa1c9920
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaa1c9a90
        public void .ctor(){} // RVA: 0x7ffaaa1c9c10
        // ── Binary Analysis Named ──
        public void SetLoadOptions(){} // RVA: 0x7ffaaa1c45f0
        public void SetPlaybackOptions(){} // RVA: 0x7ffaaa1c46c0
        public void GetPlatform(){} // RVA: 0x7ffaa8f22da0
        public void GetCurrentPlatformOptions(){} // RVA: 0x7ffaa8d92160
        public void GetPlatformVideoApiString(){} // RVA: 0x7ffaaa1c61a0
        public void GetPlatformFileOffset(){} // RVA: 0x7ffaa8f22da0
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x7ffaaa1c6220
        public void GetResolvedFilePath(){} // RVA: 0x7ffaaa1c62d0
        public void GetDummyCamera(){} // RVA: 0x7ffaaa1c7de0
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa1d5f80
    }

    public class MediaReference : ScriptableObject
    {
        public object _hints; // 0x3390E960
        public object _android; // 0x3390E960
        public object _windowsUWP; // 0x3390E960

        // ── Original Methods ──
        public void get_Alias(){} // RVA: 0x7ffaa89357c0
        public void set_Alias(){} // RVA: 0x7ffaa8998e80
        public void get_MediaPath(){} // RVA: 0x7ffaa89600c0
        public void set_MediaPath(){} // RVA: 0x7ffaa89600d0
        public void get_Hints(){} // RVA: 0x7ffaa89ad700
        public void set_Hints(){} // RVA: 0x7ffaa89ad720
        public void .ctor(){} // RVA: 0x7ffaaa1bc930
        // ── Binary Analysis Named ──
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x7ffaaa1bc7e0
        public void GetPlatformMediaReference(){} // RVA: 0x7ffaaa1bc8b0
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        public object _currentTime; // 0x3368C030
        public object _bLoop; // 0x3368C030
        public object _texture; // 0x3368C030
        public object _fakeFlipTime; // 0x3368C030
        public object Buffered; // 0x84F30710

        // ── Original Methods ──
        public void OpenMedia(){} // RVA: 0x7ffaaa1dad20
        public void CloseMedia(){} // RVA: 0x7ffaaa1db060
        public void IsLooping(){} // RVA: 0x7ffaa89534c0
        public void HasMetaData(){} // RVA: 0x7ffaa8a17850
        public void CanPlay(){} // RVA: 0x7ffaa8a17850
        public void HasAudio(){} // RVA: 0x7ffaa8932320
        public void HasVideo(){} // RVA: 0x7ffaa8932320
        public void Play(){} // RVA: 0x7ffaaa1db0a0
        public void Pause(){} // RVA: 0x7ffaaa1db0c0
        public void Stop(){} // RVA: 0x7ffaaa1db0d0
        public void IsSeeking(){} // RVA: 0x7ffaa8932320
        public void IsPlaying(){} // RVA: 0x7ffaa8b704c0
        public void IsPaused(){} // RVA: 0x7ffaa970e3a0
        public void IsFinished(){} // RVA: 0x7ffaaa1db0e0
        public void IsBuffering(){} // RVA: 0x7ffaa8932320
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7ffaa8b7a7f0
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaa8932320
        public void Seek(){} // RVA: 0x7ffaaa1db160
        public void SeekFast(){} // RVA: 0x7ffaaa1db160
        public void MuteAudio(){} // RVA: 0x7ffaa8932310
        public void IsMuted(){} // RVA: 0x7ffaa8a17850
        public void Update(){} // RVA: 0x7ffaaa1db1c0
        public void Render(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void InternalSetActiveTrack(){} // RVA: 0x7ffaa8932320
        public void InternalIsChangedTracks(){} // RVA: 0x7ffaa8932320
        public void InternalGetTrackCount(){} // RVA: 0x7ffaa8f22da0
        public void InternalGetTrackInfo(){} // RVA: 0x7ffaa8f22da0
        public void InternalIsChangedTextCue(){} // RVA: 0x7ffaa8932320
        public void InternalGetCurrentTextCue(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaaa1db4b0
        // ── Binary Analysis Named ──
        public void GetVersion(){} // RVA: 0x7ffaaa1dacc0
        public void GetExpectedVersion(){} // RVA: 0x7ffaaa1dad00
        public void SetLooping(){} // RVA: 0x7ffaa89534d0
        public void GetDuration(){} // RVA: 0x7ffaaa1db130
        public void GetVideoWidth(){} // RVA: 0x7ffaaa1db140
        public void GetVideoHeight(){} // RVA: 0x7ffaa906c660
        public void GetVideoDisplayRate(){} // RVA: 0x7ffaa916edd0
        public void GetTexture(){} // RVA: 0x7ffaa8a4f100
        public void GetTextureFrameCount(){} // RVA: 0x7ffaaa1db150
        public void GetCurrentTime(){} // RVA: 0x7ffaaa1db170
        public void SetPlaybackRate(){} // RVA: 0x7ffaaa1db180
        public void GetPlaybackRate(){} // RVA: 0x7ffaaa1db190
        public void SetVolume(){} // RVA: 0x7ffaaa1db1a0
        public void GetVolume(){} // RVA: 0x7ffaaa1db1b0
        public void GetVideoFrameRate(){} // RVA: 0x7ffaa916f990
    }

    public class PlaybackQualityStats : Object
    {
        public object _unityDroppedFrames; // 0x336D5E90, was: <UnityDroppedFrames>k__Backing
        public object _perfectFrames; // 0x336D5E90, was: <PerfectFrames>k__BackingField
        public object _sameFrameCount; // 0x336D5E90

        // ── Original Methods ──
        public void get_SkippedFrames(){} // RVA: 0x7ffaa897f5c0
        public void set_SkippedFrames(){} // RVA: 0x7ffaa89350c0
        public void get_DuplicateFrames(){} // RVA: 0x7ffaa8e046c0
        public void set_DuplicateFrames(){} // RVA: 0x7ffaa8e03640
        public void get_UnityDroppedFrames(){} // RVA: 0x7ffaa8b945a0
        public void set_UnityDroppedFrames(){} // RVA: 0x7ffaa9357830
        public void get_PerfectFramesT(){} // RVA: 0x7ffaa89ff570
        public void set_PerfectFramesT(){} // RVA: 0x7ffaa89ff580
        public void get_VSyncStatus(){} // RVA: 0x7ffaa89600c0
        public void set_VSyncStatus(){} // RVA: 0x7ffaa89600d0
        public void get_PerfectFrames(){} // RVA: 0x7ffaa8d14570
        public void set_PerfectFrames(){} // RVA: 0x7ffaa90c0cd0
        public void get_TotalFrames(){} // RVA: 0x7ffaa96cc980
        public void set_TotalFrames(){} // RVA: 0x7ffaa9fdb500
        public void get_LogIssues(){} // RVA: 0x7ffaa8958450
        public void set_LogIssues(){} // RVA: 0x7ffaa8958460
        public void Reset(){} // RVA: 0x7ffaaa1d9fd0
        public void Start(){} // RVA: 0x7ffaaa1da020
        public void Update(){} // RVA: 0x7ffaaa1da620
        public void IsGameViewVSyncEnabled(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        public object _playerB; // 0x33C4D360
        public object _playlistLoopMode; // 0x33C4D360
        public object _defaultTransition; // 0x33C4D360
        public object PropFromTex; // 0x33C4D360
        public object _playlistIndex; // 0x33C4D360
        public object _currentTransition; // 0x33C4D360
        public object _currentTransitionEasing; // 0x33C4D360
        public object _easeFunc; // 0x33C4D360
        public object _nextItem; // 0x33C4D360

        // ── Original Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x7ffaaa1cbed0
        public void get_NextPlayer(){} // RVA: 0x7ffaa8f7aa00
        public void get_Playlist(){} // RVA: 0x7ffaa8e19790
        public void get_PlaylistIndex(){} // RVA: 0x7ffaaa1cc020
        public void get_PlaylistItem(){} // RVA: 0x7ffaaa1cc030
        public void get_DefaultTransition(){} // RVA: 0x7ffaaa1cc120
        public void set_DefaultTransition(){} // RVA: 0x7ffaaa1cc130
        public void get_DefaultTransitionDuration(){} // RVA: 0x7ffaaa1cc140
        public void set_DefaultTransitionDuration(){} // RVA: 0x7ffaaa1cc150
        public void get_DefaultTransitionEasing(){} // RVA: 0x7ffaaa1cc160
        public void set_DefaultTransitionEasing(){} // RVA: 0x7ffaaa1cc170
        public void get_AutoCloseVideo(){} // RVA: 0x7ffaaa1cc180
        public void set_AutoCloseVideo(){} // RVA: 0x7ffaaa1cc190
        public void get_LoopMode(){} // RVA: 0x7ffaaa1cc1a0
        public void set_LoopMode(){} // RVA: 0x7ffaaa1cc1b0
        public void get_AutoProgress(){} // RVA: 0x7ffaaa1cc1c0
        public void set_AutoProgress(){} // RVA: 0x7ffaaa1cc1d0
        public void get_Info(){} // RVA: 0x7ffaaa1cc1e0
        public void get_Control(){} // RVA: 0x7ffaaa1cc2f0
        public void get_TextureProducer(){} // RVA: 0x7ffaaa1cc400
        public void get_AudioVolume(){} // RVA: 0x7ffaaa1cc530
        public void set_AudioVolume(){} // RVA: 0x7ffaaa1cc540
        public void get_AudioMuted(){} // RVA: 0x7ffaaa1cc690
        public void set_AudioMuted(){} // RVA: 0x7ffaaa1cc6a0
        public void Play(){} // RVA: 0x7ffaaa1cc7d0
        public void Pause(){} // RVA: 0x7ffaaa1cc8e0
        public void IsPaused(){} // RVA: 0x7ffaaa1cc9e0
        public void SwapPlayers(){} // RVA: 0x7ffaaa1cc9f0
        public void Awake(){} // RVA: 0x7ffaaa1cd690
        public void OnDestroy(){} // RVA: 0x7ffaaa1cda40
        public void Start(){} // RVA: 0x7ffaaa1cdd80
        public void OnVideoEvent(){} // RVA: 0x7ffaaa1cdfe0
        public void PrevItem(){} // RVA: 0x7ffaaa1ce3a0
        public void NextItem(){} // RVA: 0x7ffaaa1ce3b0
        public void CanJumpToItem(){} // RVA: 0x7ffaaa1ce430
        public void JumpToItem(){} // RVA: 0x7ffaaa1ce510
        public void OpenVideoFile(){} // RVA: 0x7ffaaa1ce6e0
        public void IsTransitioning(){} // RVA: 0x7ffaaa1cea90
        public void Update(){} // RVA: 0x7ffaaa1ced60
        public void SupportsTextureFrameCount(){} // RVA: 0x7ffaaa1cf500
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaaa1cf680
        public void .ctor(){} // RVA: 0x7ffaaa1cfc60
        public void .cctor(){} // RVA: 0x7ffaaa1cff00
        // ── Binary Analysis Named ──
        public void GetCurrentTexture(){} // RVA: 0x7ffaaa1cd3e0
        public void GetNextTexture(){} // RVA: 0x7ffaaa1cd540
        public void SetTransition(){} // RVA: 0x7ffaaa1ceb90
        public void GetTexture(){} // RVA: 0x7ffaa8f6ff20
        public void GetTextureCount(){} // RVA: 0x7ffaaa1cf400
        public void GetTextureFrameCount(){} // RVA: 0x7ffaaa1cf480
        public void GetTextureTimeStamp(){} // RVA: 0x7ffaaa1cf580
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7ffaaa1cf600
        public void GetYpCbCrTransform(){} // RVA: 0x7ffaaa1cf700
        public void GetTextureStereoPacking(){} // RVA: 0x7ffaaa1cf7b0
        public void GetTextureTransparency(){} // RVA: 0x7ffaaa1cf830
        public void GetTextureAlphaPacking(){} // RVA: 0x7ffaaa1cf8b0
        public void GetTransitionName(){} // RVA: 0x7ffaaa1cf930
    }

    public class Resampler : Object
    {
        public object _outputTexture; // 0x3390DCB0
        public object _bufferSize; // 0x3390DCB0
        public object _blendMat; // 0x3390DCB0
        public object _lastTimeStamp; // 0x3390DCB0
        public object _frameDisplayedTimer; // 0x3390DCB0
        public object _textureTimeStamp; // 0x3390DCB0, was: <TextureTimeStamp>k__BackingFi
        public object _propAfterTex; // 0x3390DCB0

        // ── Original Methods ──
        public void get_DroppedFrames(){} // RVA: 0x7ffaaa1c2a40
        public void get_FrameDisplayedTimer(){} // RVA: 0x7ffaa9fb1a70
        public void get_BaseTimestamp(){} // RVA: 0x7ffaa8bf45b0
        public void set_BaseTimestamp(){} // RVA: 0x7ffaa8f4e3b0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7ffaa8af93a0
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7ffaa8b01070
        public void get_LastT(){} // RVA: 0x7ffaa8e593a0
        public void set_LastT(){} // RVA: 0x7ffaa8e5c0a0
        public void get_TextureTimeStamp(){} // RVA: 0x7ffaa8d1b980
        public void set_TextureTimeStamp(){} // RVA: 0x7ffaa9132e80
        public void OnVideoEvent(){} // RVA: 0x7ffaaa1eb760
        public void .ctor(){} // RVA: 0x7ffaaa1eb840
        public void get_OutputTexture(){} // RVA: 0x7ffaa89600c0
        public void Reset(){} // RVA: 0x7ffaaa1ebd80
        public void Release(){} // RVA: 0x7ffaaa1ebda0
        public void ReleaseRenderTextures(){} // RVA: 0x7ffaaa1ebf30
        public void ConstructRenderTextures(){} // RVA: 0x7ffaaa1ec280
        public void FindBeforeFrameIndex(){} // RVA: 0x7ffaaa1eccd0
        public void FindClosestFrame(){} // RVA: 0x7ffaaa1ecf10
        public void PointUpdate(){} // RVA: 0x7ffaaa1ed0f0
        public void SampleFrame(){} // RVA: 0x7ffaaa1ed420
        public void SampleFrames(){} // RVA: 0x7ffaaa1ed5f0
        public void LinearUpdate(){} // RVA: 0x7ffaaa1ed9c0
        public void InvalidateBuffer(){} // RVA: 0x7ffaaa1edbe0
        public void GuessFrameRate(){} // RVA: 0x7ffaaa1edce0
        public void Update(){} // RVA: 0x7ffaaa1edfa0
        public void UpdateTimestamp(){} // RVA: 0x7ffaaa1eecc0
        // ── Binary Analysis Named ──
        public void CheckRenderTexturesValid(){} // RVA: 0x7ffaaa1ec860
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        public object _resolveFlags; // 0x3366FA10
        public object _isMaterialSetup; // 0x3366FA10
        public object _internalTexture; // 0x3366FA10
        public object _srcTexId; // 0x3366FA10
        public object saturation; // 0x84ECBB10
        public object gamma; // 0x84ECBB10

        // ── Original Methods ──
        public void get_MediaPlayer(){} // RVA: 0x7ffaa89600c0
        public void set_MediaPlayer(){} // RVA: 0x7ffaaa1d0980
        public void get_VideoResolveOptions(){} // RVA: 0x7ffaaa1d0990
        public void set_VideoResolveOptions(){} // RVA: 0x7ffaaa1d09b0
        public void get_ExternalTexture(){} // RVA: 0x7ffaa89d0370
        public void set_ExternalTexture(){} // RVA: 0x7ffaa89d0380
        public void get_TargetTexture(){} // RVA: 0x7ffaaa1d09d0
        public void ChangeMediaPlayer(){} // RVA: 0x7ffaaa1d0ab0
        public void Start(){} // RVA: 0x7ffaaa1d0c50
        public void LateUpdate(){} // RVA: 0x7ffaaa1d0f40
        public void Resolve(){} // RVA: 0x7ffaaa1d0f50
        public void OnDisable(){} // RVA: 0x7ffaaa1d1740
        public void OnDestroy(){} // RVA: 0x7ffaaa1d18b0
        public void .ctor(){} // RVA: 0x7ffaaa1d19f0
        // ── Binary Analysis Named ──
        public void SetMaterialDirty(){} // RVA: 0x7ffaa8ae30c0
    }

    public class Subtitle : Object
    {
        public object timeStart; // 0x33AAF5D0

        // ── Original Methods ──
        public void IsBefore(){} // RVA: 0x7ffaaa1eece0
        public void IsTime(){} // RVA: 0x7ffaaa1eed00
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SubtitlesUGUI : MonoBehaviour
    {
        public object _backgroundImage; // 0x3354BE30
        public object _maxCharacters; // 0x3354BE30
        public object Player; // 0x1700000B
        public object Text; // 0x1700000C

        // ── Original Methods ──
        public void set_Player(){} // RVA: 0x7ffaaa1bbad0
        public void get_Player(){} // RVA: 0x7ffaa89600c0
        public void set_Text(){} // RVA: 0x7ffaa8933e90
        public void get_Text(){} // RVA: 0x7ffaa8960130
        public void Start(){} // RVA: 0x7ffaaa1bbae0
        public void OnDestroy(){} // RVA: 0x7ffaaa1bbaf0
        public void Update(){} // RVA: 0x7ffaaa1bbb00
        public void ChangeMediaPlayer(){} // RVA: 0x7ffaaa1bbb10
        public void PrepareText(){} // RVA: 0x7ffaaa1bbe90
        public void UpdateBackgroundRect(){} // RVA: 0x7ffaaa1bc000
        public void OnMediaPlayerEvent(){} // RVA: 0x7ffaaa1bc2b0
        public void .ctor(){} // RVA: 0x7ffaaa1bc500
        // ── Binary Analysis Named ──
        public void SetText(){} // RVA: 0x7ffaaa1bbe50
    }

    public class TextCue : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_Text(){} // RVA: 0x7ffaa894d380
        public void set_Text(){} // RVA: 0x7ffaa8933e30
    }

    public class TrackBase : Object
    {
        public object _displayName; // 0x333DC510, was: <DisplayName>k__BackingField
        public object _isDefault; // 0x333DC510, was: <IsDefault>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa1ea6c0
        public void .ctor(){} // RVA: 0x7ffaaa1ea6c0
        public void get_Uid(){} // RVA: 0x7ffaa897f5c0
        public void set_Uid(){} // RVA: 0x7ffaa89350c0
        public void get_TrackType(){} // RVA: 0x7ffaa8e046c0
        public void set_TrackType(){} // RVA: 0x7ffaa8e03640
        public void get_DisplayName(){} // RVA: 0x7ffaa89357c0
        public void set_DisplayName(){} // RVA: 0x7ffaa8998e80
        public void get_Name(){} // RVA: 0x7ffaa89600c0
        public void set_Name(){} // RVA: 0x7ffaa89600d0
        public void get_Language(){} // RVA: 0x7ffaa8960130
        public void set_Language(){} // RVA: 0x7ffaa8933e90
        public void get_IsDefault(){} // RVA: 0x7ffaa8958450
        public void set_IsDefault(){} // RVA: 0x7ffaa8958460
        public void CreateDisplayName(){} // RVA: 0x7ffaaa1ea940
    }

    public class TrackCollection : Object
    {
        // ── Original Methods ──
        public void get_TrackType(){} // RVA: 0x7ffaa897f5c0
        public void set_TrackType(){} // RVA: 0x7ffaa89350c0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Add(){} // RVA: 0x7ffaa8660d80
        public void HasActiveTrack(){} // RVA: 0x7ffaa864a040
        public void IsActiveTrack(){} // RVA: 0x7ffaa864a2a0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void SetActiveTrack(){} // RVA: 0x7ffaa8660d80
        public void SetFirstTrackActive(){} // RVA: 0x7ffaa8660cc0
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void get_ActiveTrack(){} // RVA: 0x7ffaa887e5c0
        public void set_ActiveTrack(){} // RVA: 0x7ffaa887e5c0
        public void HasActiveTrack(){} // RVA: 0x7ffaa864a040
        public void IsActiveTrack(){} // RVA: 0x7ffaa864a2a0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Add(){} // RVA: 0x7ffaa8660d80
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void SetActiveTrack(){} // RVA: 0x7ffaa8660d80
        public void SetFirstTrackActive(){} // RVA: 0x7ffaa8660cc0
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        public object PropWorldCameraRight; // 0x3390EE60

        // ── Original Methods ──
        public void get_Camera(){} // RVA: 0x7ffaa89600c0
        public void set_Camera(){} // RVA: 0x7ffaa89600d0
        public void Awake(){} // RVA: 0x7ffaaa1d1ac0
        public void Start(){} // RVA: 0x7ffaaa1d1bd0
        public void LogXRDeviceDetails(){} // RVA: 0x7ffaaa1d1be0
        public void IsMultiPassVrEnabled(){} // RVA: 0x7ffaaa1d2160
        public void LateUpdate(){} // RVA: 0x7ffaaa1d2200
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaaa1d2b30
    }

    public class VideoRender : Object
    {
        public object Shader_ResolveOES; // 0x339FEDB0
        public object Keyword_AlphaPackLeftRight; // 0x339FEDB0
        public object Keyword_StereoLeftRight; // 0x339FEDB0
        public object Keyword_StereoNone; // 0x339FEDB0
        public object Keyword_LayoutNone; // 0x339FEDB0
        public object Keyword_ForceEyeRight; // 0x339FEDB0
        public object PropVertScale; // 0x339FEDB0
        public object PropAlphaPack; // 0x339FEDB0
        public object PropTextureMatrix; // 0x339FEDB0
        public object PropSaturation; // 0x339FEDB0
        public object PropInvGamma; // 0x339FEDB0
        public object E33B94EF0E1FECD53849D083EEBE3E8A40DA9DDB1FAD7BDE4AF5ABDF4B6796DD; // 0x84F327B0
        public object TotalTypes; // 0x84F32E90

        // ── Original Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x7ffaaa1ef4c0
        public void CreateIMGUIMaterial(){} // RVA: 0x7ffaaa1ef560
        public void ResolveVideoToRenderTexture(){} // RVA: 0x7ffaaa1f1470
        public void RequiresResolve(){} // RVA: 0x7ffaaa1f1e50
        public void DrawTexture(){} // RVA: 0x7ffaaa1f1f00
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaa1f26e0
        // ── Binary Analysis Named ──
        public void SetupLayoutMaterial(){} // RVA: 0x7ffaaa1ef5e0
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x7ffaaa1ef760
        public void SetupStereoMaterial(){} // RVA: 0x7ffaaa1ef8b0
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x7ffaaa1efb70
        public void SetupAlphaPackedMaterial(){} // RVA: 0x7ffaaa1efc40
        public void SetupGammaMaterial(){} // RVA: 0x7ffaaa1efd90
        public void SetupTextureMatrix(){} // RVA: 0x7ffaa8932310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x7ffaaa1efe90
        public void GetTexture(){} // RVA: 0x7ffaaa1effd0
        public void SetupMaterialForMedia(){} // RVA: 0x7ffaaa1f0180
        public void SetupMaterial(){} // RVA: 0x7ffaaa1f07d0
        public void SetupResolveMaterial(){} // RVA: 0x7ffaaa1f0fe0
        public void GetResolveTextureSize(){} // RVA: 0x7ffaaa1f1da0
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        public object _preferredFilters; // 0x335401B0
        public object _useStereoDetection; // 0x335401B0
        public object _useFacebookAudio360Support; // 0x335401B0
        public object _decodePrerollFrameCount; // 0x335401B0
        public object _audioMuted; // 0x335401B0
        public object _isLooping; // 0x335401B0
        public object _width; // 0x335401B0
        public object _hasAudio; // 0x335401B0
        public object _nativeTexture; // 0x335401B0
        public object _instance; // 0x335401B0
        public object _useTextureMips; // 0x335401B0
        public object _useLowLatency; // 0x335401B0
        public object _isInitialised; // 0x335401B0
        public object _lastUpdateAllTexturesFrame; // 0x335401B0
        public object _masterDisplay; // 0x335401B0
        public object _timeAccumulation; // 0x335401B0
        public object `Ǐf; // 0x66DE1A7C
        public object @Ij;
        public object get_Token; // 0xB41F4950

        // ── Original Methods ──
        public void InitialisePlatform(){} // RVA: 0x7ffaaa1db4e0
        public void DeinitPlatform(){} // RVA: 0x7ffaaa1db9b0
        public void .ctor(){} // RVA: 0x7ffaaa1dbdd0
        public void .ctor(){} // RVA: 0x7ffaaa1dbdd0
        public void UseNativeMips(){} // RVA: 0x7ffaaa1dc410
        public void OpenMedia(){} // RVA: 0x7ffaaa1dc420
        public void OpenMediaFromBuffer(){} // RVA: 0x7ffaaa1dcbf0
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7ffaaa1dd0c0
        public void AddChunkToMediaBuffer(){} // RVA: 0x7ffaaa1dd190
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7ffaaa1dd250
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x7ffaaa1dd6a0
        public void CloseMedia(){} // RVA: 0x7ffaaa1dd870
        public void IsLooping(){} // RVA: 0x7ffaa8a5df80
        public void HasMetaData(){} // RVA: 0x7ffaaa1ddaa0
        public void HasAudio(){} // RVA: 0x7ffaa89b3ad0
        public void HasVideo(){} // RVA: 0x7ffaa98b1d50
        public void CanPlay(){} // RVA: 0x7ffaaa1ddab0
        public void Play(){} // RVA: 0x7ffaaa1ddac0
        public void Pause(){} // RVA: 0x7ffaaa1ddb50
        public void Stop(){} // RVA: 0x7ffaaa1ddb50
        public void IsSeeking(){} // RVA: 0x7ffaaa1ddb70
        public void IsPlaying(){} // RVA: 0x7ffaaa1ddc00
        public void IsPaused(){} // RVA: 0x7ffaaa1ddc80
        public void IsFinished(){} // RVA: 0x7ffaaa1ddcc0
        public void IsBuffering(){} // RVA: 0x7ffaaa1dddb0
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaa98b8b50
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7ffaaa1de140
        public void Seek(){} // RVA: 0x7ffaaa1de1c0
        public void SeekFast(){} // RVA: 0x7ffaaa1de280
        public void MuteAudio(){} // RVA: 0x7ffaaa1de4d0
        public void IsMuted(){} // RVA: 0x7ffaaa1c3020
        public void IsPlaybackStalled(){} // RVA: 0x7ffaaa1de6b0
        public void WaitForNextFrame(){} // RVA: 0x7ffaaa1de760
        public void ResetAudioHeadRotation(){} // RVA: 0x7ffaaa1dea40
        public void ResetAudioFocus(){} // RVA: 0x7ffaaa1debc0
        public void Update(){} // RVA: 0x7ffaaa1dec30
        public void ReleaseTexture(){} // RVA: 0x7ffaaa1df470
        public void UpdateTexture(){} // RVA: 0x7ffaaa1df710
        public void EndUpdate(){} // RVA: 0x7ffaaa1dfeb0
        public void OnTextureSizeChanged(){} // RVA: 0x7ffaa8932310
        public void Render(){} // RVA: 0x7ffaaa1e0000
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void GrabAudio(){} // RVA: 0x7ffaaa1e0060
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7ffaaa1e01a0
        public void IssueRenderThreadEvent(){} // RVA: 0x7ffaaa1e0260
        public void InternalSetActiveTrack(){} // RVA: 0x7ffaaa1e0450
        public void InternalIsChangedTextCue(){} // RVA: 0x7ffaaa1e0500
        public void InternalGetCurrentTextCue(){} // RVA: 0x7ffaaa1e0590
        public void InternalIsChangedTracks(){} // RVA: 0x7ffaaa1e0660
        public void InternalGetTrackCount(){} // RVA: 0x7ffaaa1e0700
        public void InternalGetTrackInfo(){} // RVA: 0x7ffaaa1e07a0
        public void UpdateTimeRanges(){} // RVA: 0x7ffaaa1e0bf0
        public void UpdateTimeRange(){} // RVA: 0x7ffaaa1e0c60
        public void FlushFrameBuffering(){} // RVA: 0x7ffaaa1e0d70
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7ffaaa1e0ec0
        public void LogBufferState(){} // RVA: 0x7ffaaa1e16b0
        public void IsPrerollComplete(){} // RVA: 0x7ffaaa1e1ea0
        public void .cctor(){} // RVA: 0x7ffaaa1e2030
        // ── Binary Analysis Named ──
        public void GetAudioChannelCount(){} // RVA: 0x7ffaaa1dba60
        public void GetAudioChannelMask(){} // RVA: 0x7ffaaa1dbae0
        public void SetOptions(){} // RVA: 0x7ffaaa1dc030
        public void GetVersion(){} // RVA: 0x7ffaaa1dc370
        public void GetExpectedVersion(){} // RVA: 0x7ffaaa1dc3d0
        public void SetLooping(){} // RVA: 0x7ffaaa1dda10
        public void GetDuration(){} // RVA: 0x7ffaaa1dde40
        public void GetVideoWidth(){} // RVA: 0x7ffaaa1ddec0
        public void GetVideoHeight(){} // RVA: 0x7ffaaa1dded0
        public void GetVideoFrameRate(){} // RVA: 0x7ffaaa1ddee0
        public void GetTexture(){} // RVA: 0x7ffaaa1ddef0
        public void GetTextureFrameCount(){} // RVA: 0x7ffaaa1de000
        public void GetTextureTimeStamp(){} // RVA: 0x7ffaaa1de010
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7ffaaa1de090
        public void GetCurrentTime(){} // RVA: 0x7ffaaa1de340
        public void SetPlaybackRate(){} // RVA: 0x7ffaaa1de3c0
        public void GetPlaybackRate(){} // RVA: 0x7ffaaa1de450
        public void SetVolume(){} // RVA: 0x7ffaaa1de560
        public void GetVolume(){} // RVA: 0x7ffaaa1de600
        public void SetBalance(){} // RVA: 0x7ffaaa1de610
        public void GetBalance(){} // RVA: 0x7ffaa8dfb710
        public void SetAudioChannelMode(){} // RVA: 0x7ffaaa1de970
        public void SetAudioHeadRotation(){} // RVA: 0x7ffaaa1dea00
        public void SetAudioFocusEnabled(){} // RVA: 0x7ffaaa1deb60
        public void SetAudioFocusProperties(){} // RVA: 0x7ffaaa1deb70
        public void SetAudioFocusRotation(){} // RVA: 0x7ffaaa1deb80
        public void GetLastExtendedErrorCode(){} // RVA: 0x7ffaaa1dff30
        public void BeginRender(){} // RVA: 0x7ffaaa1dffb0
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7ffaaa1e0120
        public void GetDecoderPerformance(){} // RVA: 0x7ffaaa1e01b0
        public void GetPluginVersion(){} // RVA: 0x7ffaaa1e0380
        public void SetBufferedDisplayTime(){} // RVA: 0x7ffaaa1e1a80
        public void GetBufferedFramesState(){} // RVA: 0x7ffaaa1e1b40
        public void SetBufferedDisplayMode(){} // RVA: 0x7ffaaa1e1be0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7ffaaa1e1d00
        public void SetSlaves(){} // RVA: 0x7ffaaa1e1d30
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        public object _useLowLiveLatency; // 0x3387E730
        public object _version; // 0x3387E730
        public object _eyeTextures; // 0x3387E730
        public object AuthenticationData; // 0x17000098

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa1e57d0
        public void .ctor(){} // RVA: 0x7ffaaa1e57d0
        public void CanPlay(){} // RVA: 0x7ffaaa1e5ab0
        public void Dispose(){} // RVA: 0x7ffaaa1e5ad0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7ffaa8932320
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7ffaaa1e5ec0
        public void HasAudio(){} // RVA: 0x7ffaaa1e64a0
        public void HasMetaData(){} // RVA: 0x7ffaaa1e64e0
        public void HasVideo(){} // RVA: 0x7ffaaa1e6510
        public void IsBuffering(){} // RVA: 0x7ffaaa1e6550
        public void IsFinished(){} // RVA: 0x7ffaaa1e6570
        public void IsLooping(){} // RVA: 0x7ffaaa1e6620
        public void IsMuted(){} // RVA: 0x7ffaaa1e66b0
        public void IsPaused(){} // RVA: 0x7ffaaa1e6740
        public void IsPlaying(){} // RVA: 0x7ffaaa1e6760
        public void IsSeeking(){} // RVA: 0x7ffaaa1e6780
        public void MuteAudio(){} // RVA: 0x7ffaaa1e67a0
        public void OpenMedia(){} // RVA: 0x7ffaaa1e6830
        public void CloseMedia(){} // RVA: 0x7ffaaa1e6a40
        public void Pause(){} // RVA: 0x7ffaaa1e6ae0
        public void Play(){} // RVA: 0x7ffaaa1e6b60
        public void Render(){} // RVA: 0x7ffaaa1e6be0
        public void Update_Textures(){} // RVA: 0x7ffaaa1e6c60
        public void get_AuthenticationData(){} // RVA: 0x7ffaa899d040
        public void set_AuthenticationData(){} // RVA: 0x7ffaaa1e7170
        public void RequiresVerticalFlip(){} // RVA: 0x7ffaa8a17850
        public void Seek(){} // RVA: 0x7ffaaa1e71e0
        public void SeekFast(){} // RVA: 0x7ffaaa1d45f0
        public void Stop(){} // RVA: 0x7ffaaa1e7420
        public void UpdateTimeRanges(){} // RVA: 0x7ffaaa1e7440
        public void UpdateTimeRange(){} // RVA: 0x7ffaaa1e74b0
        public void Update(){} // RVA: 0x7ffaaa1e77c0
        public void InternalSetActiveTrack(){} // RVA: 0x7ffaaa1e7da0
        public void InternalIsChangedTracks(){} // RVA: 0x7ffaaa1e7e40
        public void InternalGetTrackCount(){} // RVA: 0x7ffaaa1e7ed0
        public void InternalGetTrackInfo(){} // RVA: 0x7ffaaa1e7f60
        public void InternalIsChangedTextCue(){} // RVA: 0x7ffaaa1e8340
        public void InternalGetCurrentTextCue(){} // RVA: 0x7ffaaa1e83d0
        public void InitialisePlatform(){} // RVA: 0x7ffaaa1e84a0
        public void DeinitPlatform(){} // RVA: 0x7ffaaa1e8820
        public void .cctor(){} // RVA: 0x7ffaaa1e8880
        // ── Binary Analysis Named ──
        public void GetCurrentTime(){} // RVA: 0x7ffaaa1e5c50
        public void GetDuration(){} // RVA: 0x7ffaaa1e5cd0
        public void GetPlaybackRate(){} // RVA: 0x7ffaaa1e5ce0
        public void GetTexture(){} // RVA: 0x7ffaaa1e5d60
        public void GetTextureCount(){} // RVA: 0x7ffaaa1e5db0
        public void GetTextureFrameCount(){} // RVA: 0x7ffaa9d66e50
        public void GetVersion(){} // RVA: 0x7ffaaa1e5f40
        public void GetExpectedVersion(){} // RVA: 0x7ffaaa1e5fa0
        public void GetVideoFrameRate(){} // RVA: 0x7ffaaa1e5fe0
        public void GetVideoWidth(){} // RVA: 0x7ffaaa1e6090
        public void GetVideoHeight(){} // RVA: 0x7ffaaa1e61d0
        public void GetVolume(){} // RVA: 0x7ffaaa1e6310
        public void SetBalance(){} // RVA: 0x7ffaaa1e6390
        public void GetBalance(){} // RVA: 0x7ffaaa1e6420
        public void SetLooping(){} // RVA: 0x7ffaaa1e7270
        public void SetPlaybackRate(){} // RVA: 0x7ffaaa1e7300
        public void SetVolume(){} // RVA: 0x7ffaaa1e7390
        public void GetProgramDateTime(){} // RVA: 0x7ffaaa1e75c0
        public void SetKeyServerAuthToken(){} // RVA: 0x7ffaaa1e7ca0
        public void SetOverrideDecryptionKey(){} // RVA: 0x7ffaaa1e7d20
    }

}