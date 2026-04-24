// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 33
// Methods: 920

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class ApplyToBase : MonoBehaviour
    {
        public object Player;
        public object AutomaticStereoPacking;
        public object OverrideStereoPacking;
        public object StereoRedGreenTint;

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFD4E36F0C0
        public void set_Player(){} // RVA: 0x7FFD4FBEAE30
        public void get_AutomaticStereoPacking(){} // RVA: 0x7FFD4E516BA0
        public void set_AutomaticStereoPacking(){} // RVA: 0x7FFD4FBEAE40
        public void get_OverrideStereoPacking(){} // RVA: 0x7FFD4F0A91D0
        public void set_OverrideStereoPacking(){} // RVA: 0x7FFD4FBEAE50
        public void get_StereoRedGreenTint(){} // RVA: 0x7FFD4E367450
        public void set_StereoRedGreenTint(){} // RVA: 0x7FFD4FBEAE60
        public void Awake(){} // RVA: 0x7FFD4FBEAE70
        public void ChangeMediaPlayer(){} // RVA: 0x7FFD4FBEAE80
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFD4FBEB1F0
        public void ForceUpdate(){} // RVA: 0x7FFD4FBEB210
        public void Start(){} // RVA: 0x7FFD4FBEB290
        public void OnEnable(){} // RVA: 0x7FFD4FBEB2D0
        public void OnDisable(){} // RVA: 0x7FFD4FBEB300
        public void OnDestroy(){} // RVA: 0x7FFD4FBEB320
        public void SaveProperties(){} // RVA: 0x7FFD4E341310
        public void RestoreProperties(){} // RVA: 0x7FFD4E341310
        public void Apply(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class ApplyToMaterial : ApplyToBase
    {
        public object DefaultTexture;
        public object Material;
        public object TexturePropertyName;
        public object Offset;
        public object Scale;

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFD4E5F0140
        public void set_DefaultTexture(){} // RVA: 0x7FFD4FBD4BF0
        public void get_Material(){} // RVA: 0x7FFD4E3BE740
        public void set_Material(){} // RVA: 0x7FFD4FBD4D60
        public void get_TexturePropertyName(){} // RVA: 0x7FFD4E3BC730
        public void set_TexturePropertyName(){} // RVA: 0x7FFD4FBD4ED0
        public void get_Offset(){} // RVA: 0x7FFD4FBD5050
        public void set_Offset(){} // RVA: 0x7FFD4FBD5070
        public void get_Scale(){} // RVA: 0x7FFD4FBD50C0
        public void set_Scale(){} // RVA: 0x7FFD4FBD50E0
        public void LateUpdate(){} // RVA: 0x7FFD4E51EBD0
        public void Apply(){} // RVA: 0x7FFD4FBD5130
        public void ApplyMapping(){} // RVA: 0x7FFD4FBD56C0
        public void SaveProperties(){} // RVA: 0x7FFD4FBD5DB0
        public void RestoreProperties(){} // RVA: 0x7FFD4FBD6100
        public void .ctor(){} // RVA: 0x7FFD4FBD62E0
    }

    public class ApplyToMesh : ApplyToBase
    {
        public object DefaultTexture;
        public object MeshRenderer;
        public object MaterialIndex;
        public object TexturePropertyName;
        public object Offset;
        public object Scale;

        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7FFD4E5F0140
        public void set_DefaultTexture(){} // RVA: 0x7FFD4FBD64C0
        public void get_MeshRenderer(){} // RVA: 0x7FFD4E3BE740
        public void set_MeshRenderer(){} // RVA: 0x7FFD4FBD6640
        public void get_MaterialIndex(){} // RVA: 0x7FFD4E3E20C0
        public void set_MaterialIndex(){} // RVA: 0x7FFD4E3E20D0
        public void ChangeDefaultTexture(){} // RVA: 0x7FFD4FBD64C0
        public void ChangeRenderer(){} // RVA: 0x7FFD4FBD6650
        public void get_TexturePropertyName(){} // RVA: 0x7FFD4E3E20E0
        public void set_TexturePropertyName(){} // RVA: 0x7FFD4FBD68E0
        public void get_Offset(){} // RVA: 0x7FFD4FBD50C0
        public void set_Offset(){} // RVA: 0x7FFD4FBD50E0
        public void get_Scale(){} // RVA: 0x7FFD4FBD6A60
        public void set_Scale(){} // RVA: 0x7FFD4FBD6A80
        public void LateUpdate(){} // RVA: 0x7FFD4E51EBD0
        public void Apply(){} // RVA: 0x7FFD4FBD6AD0
        public void ApplyMapping(){} // RVA: 0x7FFD4FBD7070
        public void OnEnable(){} // RVA: 0x7FFD4FBD77C0
        public void OnDisable(){} // RVA: 0x7FFD4FBD7AC0
        public void .ctor(){} // RVA: 0x7FFD4FBD7AF0
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        public object Channel;

        // ── Methods ──
        public void get_Channel(){} // RVA: 0x7FFD4E36F0C0
        public void set_Channel(){} // RVA: 0x7FFD4E36F0D0
        public void Reset(){} // RVA: 0x7FFD4FBD7C40
        public void ChangeChannelCount(){} // RVA: 0x7FFD4FBD7D00
        public void OnAudioFilterRead(){} // RVA: 0x7FFD4FBD7E50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AudioOutput : MonoBehaviour
    {
        public object Player;
        public object OutputMode;
        public object ChannelMask;

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFD4E36F0C0
        public void set_Player(){} // RVA: 0x7FFD4FBD8040
        public void get_OutputMode(){} // RVA: 0x7FFD4E70C4C0
        public void set_OutputMode(){} // RVA: 0x7FFD4EABA6E0
        public void get_ChannelMask(){} // RVA: 0x7FFD4F0A91D0
        public void set_ChannelMask(){} // RVA: 0x7FFD4F9D6490
        public void Awake(){} // RVA: 0x7FFD4FBD8050
        public void Start(){} // RVA: 0x7FFD4FBD80E0
        public void OnAudioConfigurationChanged(){} // RVA: 0x7FFD4FBD8170
        public void OnDestroy(){} // RVA: 0x7FFD4FBD82C0
        public void Update(){} // RVA: 0x7FFD4FBD82D0
        public void GetAudioSource(){} // RVA: 0x7FFD4E5F0140
        public void ChangeMediaPlayer(){} // RVA: 0x7FFD4FBD8410
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFD4FBD8B20
        public void ApplyAudioSettings(){} // RVA: 0x7FFD4E341310
        public void OnAudioFilterRead(){} // RVA: 0x7FFD4FBD8BE0
        public void .ctor(){} // RVA: 0x7FFD4FBD8DB0
    }

    public class AudioOutputManager : Object
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD4FBEB330
        public void .ctor(){} // RVA: 0x7FFD4FBEB4B0
        public void RequestAudio(){} // RVA: 0x7FFD4FBEB570
        public void ZeroAudio(){} // RVA: 0x7FFD4FBEBF00
        public void GrabAudio(){} // RVA: 0x7FFD4FBEBF40
    }

    public class BaseMediaPlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FBEC060
        public void GetVersion(){} // RVA: 0x7FFD4E078E90
        public void GetExpectedVersion(){} // RVA: 0x7FFD4E078E90
        public void OpenMedia(){}
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFD4E341320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFD4E341320
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFD4E341320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFD4E341320
        public void CloseMedia(){} // RVA: 0x7FFD4FBEC5F0
        public void SetLooping(){} // RVA: 0x7FFD4E091060
        public void IsLooping(){} // RVA: 0x7FFD4E079D00
        public void HasMetaData(){} // RVA: 0x7FFD4E079D00
        public void CanPlay(){} // RVA: 0x7FFD4E079D00
        public void Play(){} // RVA: 0x7FFD4E090980
        public void Pause(){} // RVA: 0x7FFD4E090980
        public void Stop(){} // RVA: 0x7FFD4E090980
        public void Rewind(){} // RVA: 0x7FFD4FBEC6E0
        public void Seek(){} // RVA: 0x7FFD4E092080
        public void SeekFast(){} // RVA: 0x7FFD4E092080
        public void SeekWithTolerance(){} // RVA: 0x7FFD4FBEC700
        public void GetCurrentTime(){} // RVA: 0x7FFD4E07EB60
        public void GetProgramDateTime(){} // RVA: 0x7FFD4FBEC720
        public void GetPlaybackRate(){} // RVA: 0x7FFD4E08D880
        public void SetPlaybackRate(){} // RVA: 0x7FFD4E09E480
        public void GetDuration(){} // RVA: 0x7FFD4E07EB60
        public void GetVideoWidth(){} // RVA: 0x7FFD4E079960
        public void GetVideoHeight(){} // RVA: 0x7FFD4E079960
        public void GetVideoFrameRate(){} // RVA: 0x7FFD4E08D880
        public void GetVideoDisplayRate(){} // RVA: 0x7FFD4E3A9460
        public void HasAudio(){} // RVA: 0x7FFD4E079D00
        public void HasVideo(){} // RVA: 0x7FFD4E079D00
        public void IsVideoStereo(){} // RVA: 0x7FFD4FBEC780
        public void IsSeeking(){} // RVA: 0x7FFD4E079D00
        public void IsPlaying(){} // RVA: 0x7FFD4E079D00
        public void IsPaused(){} // RVA: 0x7FFD4E079D00
        public void IsFinished(){} // RVA: 0x7FFD4E079D00
        public void IsBuffering(){} // RVA: 0x7FFD4E079D00
        public void WaitForNextFrame(){} // RVA: 0x7FFD4E341320
        public void GetTextureCount(){} // RVA: 0x7FFD4E433AF0
        public void GetTexture(){} // RVA: 0x7FFD4E087DE0
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4E079960
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFD4E426850
        public void GetTextureTimeStamp(){} // RVA: 0x7FFD4FBEC7B0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4E079D00
        public void GetTextureTransform(){} // RVA: 0x7FFD4FBEC7C0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFD4F3D3CE0
        public void GetYpCbCrTransform(){} // RVA: 0x7FFD4FBEC830
        public void GetTextureStereoPacking(){} // RVA: 0x7FFD4FBEC890
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFD4E079960
        public void GetTextureTransparency(){} // RVA: 0x7FFD4E70C4C0
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFD4FBEC8C0
        public void MuteAudio(){} // RVA: 0x7FFD4E091060
        public void IsMuted(){} // RVA: 0x7FFD4E079D00
        public void SetVolume(){} // RVA: 0x7FFD4E09E480
        public void SetBalance(){} // RVA: 0x7FFD4E341310
        public void GetVolume(){} // RVA: 0x7FFD4E08D880
        public void GetBalance(){} // RVA: 0x7FFD4EB632E0
        public void GetAudioChannelCount(){} // RVA: 0x7FFD4E6DD0E0
        public void GetAudioChannelMask(){} // RVA: 0x7FFD4E919180
        public void GrabAudio(){} // RVA: 0x7FFD4E919180
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFD4E919180
        public void AudioConfigurationChanged(){} // RVA: 0x7FFD4E341310
        public void SetAudioHeadRotation(){} // RVA: 0x7FFD4E341310
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFD4E341310
        public void SetAudioChannelMode(){} // RVA: 0x7FFD4E341310
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFD4E341310
        public void SetAudioFocusProperties(){} // RVA: 0x7FFD4E341310
        public void SetAudioFocusRotation(){} // RVA: 0x7FFD4E341310
        public void ResetAudioFocus(){} // RVA: 0x7FFD4E341310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7FFD4FBEC900
        public void SetPlayWithoutBuffering(){} // RVA: 0x7FFD4E341310
        public void IsMediaCachingSupported(){} // RVA: 0x7FFD4E341320
        public void AddMediaToCache(){} // RVA: 0x7FFD4E341310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7FFD4E341310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7FFD4E341310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7FFD4E341310
        public void RemoveMediaFromCache(){} // RVA: 0x7FFD4E341310
        public void GetCachedMediaStatus(){} // RVA: 0x7FFD4E919180
        public void IsExternalPlaybackSupported(){} // RVA: 0x7FFD4E341320
        public void IsExternalPlaybackActive(){} // RVA: 0x7FFD4E341320
        public void SetAllowsExternalPlayback(){} // RVA: 0x7FFD4E341310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7FFD4E341310
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFD4E341310
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFD4E341310
        public void Update(){} // RVA: 0x7FFD4E090980
        public void BeginRender(){} // RVA: 0x7FFD4E341310
        public void Render(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void GetDecoderPerformance(){} // RVA: 0x7FFD4E341320
        public void EndUpdate(){} // RVA: 0x7FFD4E341310
        public void GetNativePlayerHandle(){} // RVA: 0x7FFD4E919180
        public void GetLastError(){} // RVA: 0x7FFD4FBEC910
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFD4E919180
        public void GetPlayerDescription(){} // RVA: 0x7FFD4E35C380
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFD4E426850
        public void GetSeekableTimes(){} // RVA: 0x7FFD4E5F0140
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void GetTextureProperties(){} // RVA: 0x7FFD4FBEC920
        public void SetTextureProperties(){} // RVA: 0x7FFD4FBEC940
        public void ApplyTextureProperties(){} // RVA: 0x7FFD4FBEC9D0
        public void UpdateDisplayFrameRate(){} // RVA: 0x7FFD4FBECB80
        public void IsExpectingNewVideoFrame(){} // RVA: 0x7FFD4FBECC50
        public void IsPlaybackStalled(){} // RVA: 0x7FFD4FBECD50
        public void LoadSubtitlesSRT(){} // RVA: 0x7FFD4FBECF80
        public void UpdateSubtitles(){} // RVA: 0x7FFD4FBED140
        public void GetSubtitleIndex(){} // RVA: 0x7FFD4FBED2A0
        public void GetSubtitleText(){} // RVA: 0x7FFD4FBED2C0
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void GetCurrentTimeFrames(){} // RVA: 0x7FFD4FBED340
        public void GetDurationFrames(){} // RVA: 0x7FFD4FBED430
        public void GetMaxFrameNumber(){} // RVA: 0x7FFD4FBED4F0
        public void SeekToFrameRelative(){} // RVA: 0x7FFD4FBED510
        public void SeekToFrame(){} // RVA: 0x7FFD4FBED660
        public void UpdateBufferedDisplay(){} // RVA: 0x7FFD4FBED770
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFD4E919180
        public void GetBufferedFramesState(){} // RVA: 0x7FFD4FBED840
        public void SetSlaves(){} // RVA: 0x7FFD4E341310
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFD4E341310
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFD4E341310
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void UpdateTextCue(){} // RVA: 0x7FFD4FBED860
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFD4E079D00
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFD4E078E90
        public void GetVideoTracks(){} // RVA: 0x7FFD4E380010
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void GetTextTracks(){} // RVA: 0x7FFD4E96DFB0
        public void GetActiveVideoTrack(){} // RVA: 0x7FFD4FBEDA20
        public void GetActiveAudioTrack(){} // RVA: 0x7FFD4FBEDA70
        public void GetActiveTextTrack(){} // RVA: 0x7FFD4FBEDAC0
        public void SetActiveVideoTrack(){} // RVA: 0x7FFD4FBEDB10
        public void SetActiveAudioTrack(){} // RVA: 0x7FFD4FBEDB30
        public void SetActiveTextTrack(){} // RVA: 0x7FFD4FBEDB50
        public void InternalIsChangedTracks(){} // RVA: 0x7FFD4E07A310
        public void InternalGetTrackCount(){} // RVA: 0x7FFD4E0800D0
        public void InternalSetActiveTrack(){}
        public void InternalGetTrackInfo(){}
        public void InitTracks(){} // RVA: 0x7FFD4FBEDB70
        public void UpdateTracks(){} // RVA: 0x7FFD4FBEDD00
        public void PopulateTrackCollection(){} // RVA: 0x7FFD4FBEDDB0
        public void SetActiveTrack(){} // RVA: 0x7FFD4FBEDFA0
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        public object Player;
        public object ScaleMode;
        public object Color;
        public object AllowTransparency;
        public object UseDepth;
        public object Depth;
        public object IsAreaFullScreen;
        public object AreaX;
        public object AreaY;
        public object AreaWidth;
        public object AreaHeight;
        public object ShowAreaInEditor;

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFD4E36F0C0
        public void set_Player(){} // RVA: 0x7FFD4FBD8E10
        public void get_ScaleMode(){} // RVA: 0x7FFD4E70C4C0
        public void set_ScaleMode(){} // RVA: 0x7FFD4EABA6E0
        public void get_Color(){} // RVA: 0x7FFD4FBD8F40
        public void set_Color(){} // RVA: 0x7FFD4FBD8F50
        public void get_AllowTransparency(){} // RVA: 0x7FFD4E4A64E0
        public void set_AllowTransparency(){} // RVA: 0x7FFD4E4A64F0
        public void get_UseDepth(){} // RVA: 0x7FFD4F3907D0
        public void set_UseDepth(){} // RVA: 0x7FFD4FBD8F60
        public void get_Depth(){} // RVA: 0x7FFD4E3E2080
        public void set_Depth(){} // RVA: 0x7FFD4E3E2090
        public void get_IsAreaFullScreen(){} // RVA: 0x7FFD4F9C8350
        public void set_IsAreaFullScreen(){} // RVA: 0x7FFD4F9C8340
        public void get_AreaX(){} // RVA: 0x7FFD4F9E0DE0
        public void set_AreaX(){} // RVA: 0x7FFD4F9E0F70
        public void get_AreaY(){} // RVA: 0x7FFD4EB55280
        public void set_AreaY(){} // RVA: 0x7FFD4EB546A0
        public void get_AreaWidth(){} // RVA: 0x7FFD4E3A9460
        public void set_AreaWidth(){} // RVA: 0x7FFD4E3A9470
        public void get_AreaHeight(){} // RVA: 0x7FFD4E7B1600
        public void set_AreaHeight(){} // RVA: 0x7FFD4E7B14E0
        public void get_ShowAreaInEditor(){} // RVA: 0x7FFD4E55F600
        public void set_ShowAreaInEditor(){} // RVA: 0x7FFD4ECB2770
        public void Start(){} // RVA: 0x7FFD4FBD8F70
        public void Update(){} // RVA: 0x7FFD4FBD9210
        public void OnDestroy(){} // RVA: 0x7FFD4FBD92F0
        public void GetRequiredShader(){} // RVA: 0x7FFD4FBD9430
        public void SetupMaterial(){} // RVA: 0x7FFD4FBD97E0
        public void OnGUI(){} // RVA: 0x7FFD4FBD9C30
        public void GetAreaRect(){} // RVA: 0x7FFD4FBDA3E0
        public void .ctor(){} // RVA: 0x7FFD4FBDA660
    }

    public class DisplayUGUI : MaskableGraphic
    {
        public object Player;
        public object DefaultTexture;
        public object UVRect;
        public object ApplyNativeSize;
        public object ScaleMode;
        public object NoDefaultDisplay;
        public object DisplayInEditor;
        public object mainTexture;
        public object CurrentMediaPlayer;
        public object uvRect;

        // ── Methods ──
        public void get_Player(){} // RVA: 0x7FFD4E3C2900
        public void set_Player(){} // RVA: 0x7FFD4FBCFF60
        public void get_DefaultTexture(){} // RVA: 0x7FFD4E3C2970
        public void set_DefaultTexture(){} // RVA: 0x7FFD4FBCFF70
        public void get_UVRect(){} // RVA: 0x7FFD4FBD00F0
        public void set_UVRect(){} // RVA: 0x7FFD4FBD0100
        public void get_ApplyNativeSize(){} // RVA: 0x7FFD4F0AB9C0
        public void set_ApplyNativeSize(){} // RVA: 0x7FFD4F0ADFF0
        public void get_ScaleMode(){} // RVA: 0x7FFD4FBD0110
        public void set_ScaleMode(){} // RVA: 0x7FFD4F93E020
        public void get_NoDefaultDisplay(){} // RVA: 0x7FFD4F5B6030
        public void set_NoDefaultDisplay(){} // RVA: 0x7FFD4F5B6040
        public void get_DisplayInEditor(){} // RVA: 0x7FFD4F9EA6A0
        public void set_DisplayInEditor(){} // RVA: 0x7FFD4F9E9FB0
        public void Awake(){} // RVA: 0x7FFD4FBD0120
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFD4FBD0270
        public void ChangeMediaPlayer(){} // RVA: 0x7FFD4FBD03E0
        public void EnsureShader(){} // RVA: 0x7FFD4FBD0760
        public void EnsureAlphaPackingShader(){} // RVA: 0x7FFD4FBD0920
        public void EnsureStereoPackingShader(){} // RVA: 0x7FFD4FBD0A10
        public void EnsureAndroidOESShader(){} // RVA: 0x7FFD4FBD0B00
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x7FFD4FBD0BF0
        public void Start(){} // RVA: 0x7FFD4FBD0CE0
        public void OnDestroy(){} // RVA: 0x7FFD4FBD0E90
        public void GetRequiredShader(){} // RVA: 0x7FFD4FBD1020
        public void get_mainTexture(){} // RVA: 0x7FFD4FBD1620
        public void HasValidTexture(){} // RVA: 0x7FFD4FBD1820
        public void UpdateInternalMaterial(){} // RVA: 0x7FFD4FBD1A80
        public void LateUpdate(){} // RVA: 0x7FFD4FBD1F10
        public void get_CurrentMediaPlayer(){} // RVA: 0x7FFD4E3C2900
        public void set_CurrentMediaPlayer(){} // RVA: 0x7FFD4FBD25A0
        public void get_uvRect(){} // RVA: 0x7FFD4FBD00F0
        public void set_uvRect(){} // RVA: 0x7FFD4FBD2730
        public void SetNativeSize(){} // RVA: 0x7FFD4FBD27A0
        public void OnPopulateMesh(){} // RVA: 0x7FFD4FBD2C00
        public void _OnFillVBO(){} // RVA: 0x7FFD4FBD2CB0
        public void GetDrawingDimensions(){} // RVA: 0x7FFD4FBD3170
        public void .ctor(){} // RVA: 0x7FFD4FBD3930
        public void .cctor(){} // RVA: 0x7FFD4FBD3AB0
    }

    public class Helper : Object
    {
        // ── Methods ──
        public void GetPath(){} // RVA: 0x7FFD4FBEE5F0
        public void GetFilePath(){} // RVA: 0x7FFD4FBEE770
        public void GetFriendlyResolutionName(){} // RVA: 0x7FFD4FBEE9C0
        public void GetErrorMessage(){} // RVA: 0x7FFD4FBEED30
        public void GetPlatformName(){} // RVA: 0x7FFD4FBEEEC0
        public void GetPlatformNames(){} // RVA: 0x7FFD4FBEEF70
        public void LogInfo(){} // RVA: 0x7FFD4FBEF380
        public void GetUnityAudioSampleRate(){} // RVA: 0x7FFD4FBEF4E0
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x7FFD4FBEF590
        public void GetTimelineRange(){} // RVA: 0x7FFD4FBEF670
        public void GetTimeString(){} // RVA: 0x7FFD4FBEF6D0
        public void GetOrientation(){} // RVA: 0x7FFD4FBEFB30
        public void GetMatrixForOrientation(){} // RVA: 0x7FFD4FBEFD40
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x7FFD4FBEFF60
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x7FFD4FBF0000
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x7FFD4FBF0040
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7FFD4FBF0190
        public void GetShortPathName(){} // RVA: 0x7FFD4FBF02F0
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x7FFD4FBF03E0
        public void GetReadableTexture(){} // RVA: 0x7FFD4FBF0BD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD4FBF0EF0
    }

    public class HttpHeader : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void IsComplete(){} // RVA: 0x7FFD4FC02D10
        public void ToValidatedString(){} // RVA: 0x7FFD4FC02D40
        public void IsValid(){} // RVA: 0x7FFD4FC02F40 | overloaded x2
        public void IsAscii(){} // RVA: 0x7FFD4FC02EE0
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E090980
        public void Update(){} // RVA: 0x7FFD4E090980
        public void EndUpdate(){} // RVA: 0x7FFD4E090980
        public void BeginRender(){} // RVA: 0x7FFD4E090980
        public void Render(){} // RVA: 0x7FFD4E090980
        public void GetNativePlayerHandle(){} // RVA: 0x7FFD4E078E90
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0x7FFD4E079960
        public void GetTexture(){} // RVA: 0x7FFD4E087DE0
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4E079960
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFD4E079D00
        public void GetTextureTimeStamp(){} // RVA: 0x7FFD4E078E90
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFD4E08D880
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4E079D00
        public void GetTextureStereoPacking(){} // RVA: 0x7FFD4E079960
        public void GetTextureTransparency(){} // RVA: 0x7FFD4E079960
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFD4E079960
        public void GetYpCbCrTransform(){}
    }

    public class KeyAuthData : Object
    {
        // ── Methods ──
        public void IsModified(){} // RVA: 0x7FFD4FC035D0
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4FC03600
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4FC03670
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MediaHints : ValueType
    {
        public object Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFD4FBF1940
        public void .cctor(){} // RVA: 0x7FFD4E341310
    }

    public class MediaPlayer : MonoBehaviour
    {
        public object MediaSource;
        public object MediaReference;
        public object MediaPath;
        public object FallbackMediaHints;
        public object AutoOpen;
        public object AutoStart;
        public object Loop;
        public object AudioVolume;
        public object AudioBalance;
        public object AudioMuted;
        public object AudioSource;
        public object PlaybackRate;
        public object UseResampler;
        public object ResampleMode;
        public object ResampleBufferSize;
        public object FrameResampler;
        public object VideoLayoutMapping;
        public object TextureFilterMode;
        public object TextureWrapMode;
        public object TextureAnisoLevel;
        public object SideloadSubtitles;
        public object SubtitlePath;
        public object AudioHeadTransform;
        public object AudioFocusEnabled;
        public object AudioFocusTransform;
        public object AudioFocusWidthDegrees;
        public object AudioFocusOffLevelDB;
        public object HttpHeaders;
        public object KeyAuth;
        public object Events;
        public object EventMask;
        public object PauseMediaOnAppPause;
        public object PlayMediaOnAppUnpause;
        public object Persistent;
        public object ForceFileFormat;
        public object Info;
        public object Control;
        public object Player;
        public object TextureProducer;
        public object Subtitles;
        public object VideoTracks;
        public object AudioTracks;
        public object TextTracks;
        public object Cache;
        public object BufferedDisplay;
        public object MediaOpened;
        public object PlatformOptionsWindows;
        public object PlatformOptionsMacOSX;
        public object PlatformOptionsIOS;
        public object PlatformOptionsTVOS;
        public object PlatformOptionsAndroid;
        public object PlatformOptionsWindowsUWP;
        public object PlatformOptionsWebGL;

        // ── Methods ──
        public void get_MediaSource(){} // RVA: 0x7FFD4E4FBBE0
        public void set_MediaSource(){} // RVA: 0x7FFD4E9FB7A0
        public void get_MediaReference(){} // RVA: 0x7FFD4E36F130
        public void set_MediaReference(){} // RVA: 0x7FFD4E342E90
        public void get_MediaPath(){} // RVA: 0x7FFD4E5F95E0
        public void set_MediaPath(){} // RVA: 0x7FFD4E36F890
        public void get_FallbackMediaHints(){} // RVA: 0x7FFD4E3A7F40
        public void set_FallbackMediaHints(){} // RVA: 0x7FFD4E3A7F60
        public void get_AutoOpen(){} // RVA: 0x7FFD4F9C8350
        public void set_AutoOpen(){} // RVA: 0x7FFD4F9C8340
        public void get_AutoStart(){} // RVA: 0x7FFD4FBDA6D0
        public void set_AutoStart(){} // RVA: 0x7FFD4FBDA6E0
        public void get_Loop(){} // RVA: 0x7FFD4FBDA6F0
        public void set_Loop(){} // RVA: 0x7FFD4FBDA750
        public void get_AudioVolume(){} // RVA: 0x7FFD4FBDA7C0
        public void set_AudioVolume(){} // RVA: 0x7FFD4FBDA820
        public void get_AudioBalance(){} // RVA: 0x7FFD4FBDA8B0
        public void set_AudioBalance(){} // RVA: 0x7FFD4FBDA910
        public void get_AudioMuted(){} // RVA: 0x7FFD4FBDA9A0
        public void set_AudioMuted(){} // RVA: 0x7FFD4FBDAA00
        public void get_AudioSource(){} // RVA: 0x7FFD4E409500
        public void set_AudioSource(){} // RVA: 0x7FFD4E409510
        public void get_PlaybackRate(){} // RVA: 0x7FFD4FBDAA70
        public void set_PlaybackRate(){} // RVA: 0x7FFD4FBDAAD0
        public void get_UseResampler(){} // RVA: 0x7FFD4F365FE0
        public void set_UseResampler(){} // RVA: 0x7FFD4FBDAB40
        public void get_ResampleMode(){} // RVA: 0x7FFD4FBDAB50
        public void set_ResampleMode(){} // RVA: 0x7FFD4FBDAB60
        public void get_ResampleBufferSize(){} // RVA: 0x7FFD4FBDAB70
        public void set_ResampleBufferSize(){} // RVA: 0x7FFD4FBDAB80
        public void get_FrameResampler(){} // RVA: 0x7FFD4E409590
        public void get_VideoLayoutMapping(){} // RVA: 0x7FFD4F9B6EF0
        public void set_VideoLayoutMapping(){} // RVA: 0x7FFD4F9B63A0
        public void get_TextureFilterMode(){} // RVA: 0x7FFD4FBDAB90
        public void set_TextureFilterMode(){} // RVA: 0x7FFD4FBDAC90
        public void get_TextureWrapMode(){} // RVA: 0x7FFD4FBDAD10
        public void set_TextureWrapMode(){} // RVA: 0x7FFD4FBDAE10
        public void get_TextureAnisoLevel(){} // RVA: 0x7FFD4FBDAE90
        public void set_TextureAnisoLevel(){} // RVA: 0x7FFD4FBDAF90
        public void get_SideloadSubtitles(){} // RVA: 0x7FFD4F2203A0
        public void set_SideloadSubtitles(){} // RVA: 0x7FFD4F22C170
        public void get_SubtitlePath(){} // RVA: 0x7FFD4E70F640
        public void set_SubtitlePath(){} // RVA: 0x7FFD4E96E360
        public void set_AudioHeadTransform(){} // RVA: 0x7FFD4E96E3C0
        public void get_AudioHeadTransform(){} // RVA: 0x7FFD4E96DFB0
        public void get_AudioFocusEnabled(){} // RVA: 0x7FFD4F9E9D50
        public void set_AudioFocusEnabled(){} // RVA: 0x7FFD4EBD1910
        public void get_AudioFocusTransform(){} // RVA: 0x7FFD4E96B1A0
        public void set_AudioFocusTransform(){} // RVA: 0x7FFD4E76B370
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x7FFD4F29CCE0
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x7FFD4F10FCE0
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x7FFD4FBDB010
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x7FFD4FBDB020
        public void get_HttpHeaders(){} // RVA: 0x7FFD4E3AC0B0
        public void set_HttpHeaders(){} // RVA: 0x7FFD4E3AC0C0
        public void get_KeyAuth(){} // RVA: 0x7FFD4E3AC120
        public void set_KeyAuth(){} // RVA: 0x7FFD4E3AC130
        public void get_Events(){} // RVA: 0x7FFD4FBDB030
        public void get_EventMask(){} // RVA: 0x7FFD4EAB6B20
        public void set_EventMask(){} // RVA: 0x7FFD4F9B1C30
        public void get_PauseMediaOnAppPause(){} // RVA: 0x7FFD4FBDB0F0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x7FFD4FBDB100
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x7FFD4FBDB110
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x7FFD4FBDB120
        public void get_Persistent(){} // RVA: 0x7FFD4FBDB130
        public void set_Persistent(){} // RVA: 0x7FFD4FBDB140
        public void get_ForceFileFormat(){} // RVA: 0x7FFD4FBDB150
        public void set_ForceFileFormat(){} // RVA: 0x7FFD4FBDB160
        public void get_Info(){} // RVA: 0x7FFD4E751F50
        public void get_Control(){} // RVA: 0x7FFD4E3C2970
        public void get_Player(){} // RVA: 0x7FFD4E916C80
        public void get_TextureProducer(){} // RVA: 0x7FFD4E3AC2A0
        public void get_Subtitles(){} // RVA: 0x7FFD4EAF1F40
        public void get_VideoTracks(){} // RVA: 0x7FFD4E55CBB0
        public void get_AudioTracks(){} // RVA: 0x7FFD4E9666F0
        public void get_TextTracks(){} // RVA: 0x7FFD4E964340
        public void get_Cache(){} // RVA: 0x7FFD4E96B170
        public void get_BufferedDisplay(){} // RVA: 0x7FFD4E7DC6D0
        public void get_MediaOpened(){} // RVA: 0x7FFD4FBDB170
        public void Awake(){} // RVA: 0x7FFD4FBDB180
        public void Initialise(){} // RVA: 0x7FFD4FBDB220
        public void Start(){} // RVA: 0x7FFD4FBDBC20
        public void OpenMedia(){} // RVA: 0x7FFD4FBDBEE0 | overloaded x4
        public void InternalOpenMedia(){} // RVA: 0x7FFD4FBDBF10
        public void SetLoadOptions(){} // RVA: 0x7FFD4FBDC700
        public void SetPlaybackOptions(){} // RVA: 0x7FFD4FBDC7D0
        public void CloseMedia(){} // RVA: 0x7FFD4FBDC900
        public void RewindPrerollPause(){} // RVA: 0x7FFD4FBDCAA0
        public void Play(){} // RVA: 0x7FFD4FBDCB90
        public void Pause(){} // RVA: 0x7FFD4FBDCC30
        public void Stop(){} // RVA: 0x7FFD4FBDCCB0
        public void Rewind(){} // RVA: 0x7FFD4FBDCD10
        public void SeekToLiveTime(){} // RVA: 0x7FFD4FBDCDA0
        public void Update(){} // RVA: 0x7FFD4FBDCE40
        public void LateUpdate(){} // RVA: 0x7FFD4FBDD070
        public void UpdateResampler(){} // RVA: 0x7FFD4FBDD250
        public void OnEnable(){} // RVA: 0x7FFD4FBDD3E0
        public void OnDisable(){} // RVA: 0x7FFD4FBDD460
        public void OnDestroy(){} // RVA: 0x7FFD4FBDD500
        public void ForceDispose(){} // RVA: 0x7FFD4FBDDB60
        public void AllPlayersDispose(){} // RVA: 0x7FFD4FBDDC10
        public void HandleApplicationQuit(){} // RVA: 0x7FFD4FBDDD50
        public void StartRenderCoroutine(){} // RVA: 0x7FFD4FBDE070
        public void StopRenderCoroutine(){} // RVA: 0x7FFD4FBDE190
        public void FinalRenderCapture(){} // RVA: 0x7FFD4FBDE210
        public void GetPlatform(){} // RVA: 0x7FFD4E919180
        public void GetCurrentPlatformOptions(){} // RVA: 0x7FFD4E78D860
        public void GetPlatformVideoApiString(){} // RVA: 0x7FFD4FBDE2B0
        public void GetPlatformFileOffset(){} // RVA: 0x7FFD4E919180
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x7FFD4FBDE330
        public void GetResolvedFilePath(){} // RVA: 0x7FFD4FBDE3E0
        public void CreateMediaPlayer(){} // RVA: 0x7FFD4FBDE700 | overloaded x2
        public void CreateMediaPlayerNull(){} // RVA: 0x7FFD4FBDE690
        public void UpdateAudioFocus(){} // RVA: 0x7FFD4FBDEAB0
        public void UpdateAudioHeadTransform(){} // RVA: 0x7FFD4FBDED30
        public void UpdateErrors(){} // RVA: 0x7FFD4FBDEF50
        public void IsUsingAndroidOESPath(){} // RVA: 0x7FFD4FBDF200
        public void OnApplicationFocus(){} // RVA: 0x7FFD4E341310
        public void OnApplicationPause(){} // RVA: 0x7FFD4E341310
        public void ResetEvents(){} // RVA: 0x7FFD4FBDF250
        public void UpdateEvents(){} // RVA: 0x7FFD4FBDF280
        public void IsHandleEvent(){} // RVA: 0x7FFD4FBDF760
        public void FireEventIfPossible(){} // RVA: 0x7FFD4FBDF790
        public void CanFireEvent(){} // RVA: 0x7FFD4FBDF820
        public void ForceWaitForNewFrame(){} // RVA: 0x7FFD4FBDFCC0
        public void GetDummyCamera(){} // RVA: 0x7FFD4FBDFEF0
        public void ExtractFrameCoroutine(){} // RVA: 0x7FFD4FBE0360
        public void ExtractFrameAsync(){} // RVA: 0x7FFD4FBE04E0
        public void ExtractFrame(){} // RVA: 0x7FFD4FBE0870 | overloaded x2
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFD4FBE0B10
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x7FFD4FBE0C10
        public void AddChunkToVideoBuffer(){} // RVA: 0x7FFD4FBE0E90
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x7FFD4FBE0FB0
        public void OpenMediaFromBufferInternal(){} // RVA: 0x7FFD4FBE1040
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x7FFD4FBE12A0
        public void AddChunkToBufferInternal(){} // RVA: 0x7FFD4FBE0E90
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x7FFD4FBE0FB0
        public void get_PlatformOptionsWindows(){} // RVA: 0x7FFD4E78D860
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7FFD4E96B1B0
        public void get_PlatformOptionsIOS(){} // RVA: 0x7FFD4E9610C0
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7FFD4E960F60
        public void get_PlatformOptionsAndroid(){} // RVA: 0x7FFD4E961C80
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x7FFD4E96E2E0
        public void get_PlatformOptionsWebGL(){} // RVA: 0x7FFD4E968F80
        public void EnableSubtitles(){} // RVA: 0x7FFD4FBE1480
        public void LoadSubtitlesCoroutine(){} // RVA: 0x7FFD4FBE18D0
        public void DisableSubtitles(){} // RVA: 0x7FFD4FBE1A30
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4FBE1BA0
        public void .ctor(){} // RVA: 0x7FFD4FBE1D20
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FBEE090
    }

    public class MediaReference : ScriptableObject
    {
        public object Alias;
        public object MediaPath;
        public object Hints;

        // ── Methods ──
        public void get_Alias(){} // RVA: 0x7FFD4E3447C0
        public void set_Alias(){} // RVA: 0x7FFD4E3A7E80
        public void get_MediaPath(){} // RVA: 0x7FFD4E36F0C0
        public void set_MediaPath(){} // RVA: 0x7FFD4E36F0D0
        public void get_Hints(){} // RVA: 0x7FFD4E3BC700
        public void set_Hints(){} // RVA: 0x7FFD4E3BC720
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x7FFD4FBD48F0
        public void GetPlatformMediaReference(){} // RVA: 0x7FFD4FBD49C0
        public void .ctor(){} // RVA: 0x7FFD4FBD4A40
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x7FFD4FBF2DD0
        public void GetExpectedVersion(){} // RVA: 0x7FFD4FBF2E10
        public void OpenMedia(){} // RVA: 0x7FFD4FBF2E30
        public void CloseMedia(){} // RVA: 0x7FFD4FBF3170
        public void SetLooping(){} // RVA: 0x7FFD4E3624D0
        public void IsLooping(){} // RVA: 0x7FFD4E3624C0
        public void HasMetaData(){} // RVA: 0x7FFD4E426850
        public void CanPlay(){} // RVA: 0x7FFD4E426850
        public void HasAudio(){} // RVA: 0x7FFD4E341320
        public void HasVideo(){} // RVA: 0x7FFD4E341320
        public void Play(){} // RVA: 0x7FFD4FBF31B0
        public void Pause(){} // RVA: 0x7FFD4FBF31D0
        public void Stop(){} // RVA: 0x7FFD4FBF31E0
        public void IsSeeking(){} // RVA: 0x7FFD4E341320
        public void IsPlaying(){} // RVA: 0x7FFD4E561F10
        public void IsPaused(){} // RVA: 0x7FFD4F10FA00
        public void IsFinished(){} // RVA: 0x7FFD4FBF31F0
        public void IsBuffering(){} // RVA: 0x7FFD4E341320
        public void GetDuration(){} // RVA: 0x7FFD4FBF3240
        public void GetVideoWidth(){} // RVA: 0x7FFD4FBF3250
        public void GetVideoHeight(){} // RVA: 0x7FFD4EA61480
        public void GetVideoDisplayRate(){} // RVA: 0x7FFD4EB630B0
        public void GetTexture(){} // RVA: 0x7FFD4E45E100
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4FBF3260
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFD4E56F980
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4E341320
        public void Seek(){} // RVA: 0x7FFD4FBF3270
        public void SeekFast(){} // RVA: 0x7FFD4FBF3270
        public void GetCurrentTime(){} // RVA: 0x7FFD4FBF3280
        public void SetPlaybackRate(){} // RVA: 0x7FFD4FBF3290
        public void GetPlaybackRate(){} // RVA: 0x7FFD4FBF32A0
        public void MuteAudio(){} // RVA: 0x7FFD4E341310
        public void IsMuted(){} // RVA: 0x7FFD4E426850
        public void SetVolume(){} // RVA: 0x7FFD4FBF32B0
        public void GetVolume(){} // RVA: 0x7FFD4FBF32C0
        public void GetVideoFrameRate(){} // RVA: 0x7FFD4EB632E0
        public void Update(){} // RVA: 0x7FFD4FBF32D0
        public void Render(){} // RVA: 0x7FFD4E341310
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void InternalSetActiveTrack(){} // RVA: 0x7FFD4E341320
        public void InternalIsChangedTracks(){} // RVA: 0x7FFD4E341320
        public void InternalGetTrackCount(){} // RVA: 0x7FFD4E919180
        public void InternalGetTrackInfo(){} // RVA: 0x7FFD4E919180
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFD4E341320
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD4FBF35C0
    }

    public class PlaybackQualityStats : Object
    {
        public object SkippedFrames;
        public object DuplicateFrames;
        public object UnityDroppedFrames;
        public object PerfectFramesT;
        public object VSyncStatus;
        public object PerfectFrames;
        public object TotalFrames;
        public object LogIssues;

        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0x7FFD4E38E5C0
        public void set_SkippedFrames(){} // RVA: 0x7FFD4E3440C0
        public void get_DuplicateFrames(){} // RVA: 0x7FFD4E7F5A20
        public void set_DuplicateFrames(){} // RVA: 0x7FFD4E7F4990
        public void get_UnityDroppedFrames(){} // RVA: 0x7FFD4E577800
        public void set_UnityDroppedFrames(){} // RVA: 0x7FFD4ED4CD10
        public void get_PerfectFramesT(){} // RVA: 0x7FFD4E40E570
        public void set_PerfectFramesT(){} // RVA: 0x7FFD4E40E580
        public void get_VSyncStatus(){} // RVA: 0x7FFD4E36F0C0
        public void set_VSyncStatus(){} // RVA: 0x7FFD4E36F0D0
        public void get_PerfectFrames(){} // RVA: 0x7FFD4E70C4C0
        public void set_PerfectFrames(){} // RVA: 0x7FFD4EABA6E0
        public void get_TotalFrames(){} // RVA: 0x7FFD4F0A91D0
        public void set_TotalFrames(){} // RVA: 0x7FFD4F9D6490
        public void get_LogIssues(){} // RVA: 0x7FFD4E367450
        public void set_LogIssues(){} // RVA: 0x7FFD4E367460
        public void Reset(){} // RVA: 0x7FFD4FBF20E0
        public void Start(){} // RVA: 0x7FFD4FBF2130
        public void Update(){} // RVA: 0x7FFD4FBF2730
        public void IsGameViewVSyncEnabled(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        public object CurrentPlayer;
        public object NextPlayer;
        public object Playlist;
        public object PlaylistIndex;
        public object PlaylistItem;
        public object DefaultTransition;
        public object DefaultTransitionDuration;
        public object DefaultTransitionEasing;
        public object AutoCloseVideo;
        public object LoopMode;
        public object AutoProgress;
        public object Info;
        public object Control;
        public object TextureProducer;
        public object AudioVolume;
        public object AudioMuted;

        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x7FFD4FBE3FE0
        public void get_NextPlayer(){} // RVA: 0x7FFD4E964790
        public void get_Playlist(){} // RVA: 0x7FFD4E818150
        public void get_PlaylistIndex(){} // RVA: 0x7FFD4FBE4130
        public void get_PlaylistItem(){} // RVA: 0x7FFD4FBE4140
        public void get_DefaultTransition(){} // RVA: 0x7FFD4FBE4230
        public void set_DefaultTransition(){} // RVA: 0x7FFD4FBE4240
        public void get_DefaultTransitionDuration(){} // RVA: 0x7FFD4FBE4250
        public void set_DefaultTransitionDuration(){} // RVA: 0x7FFD4FBE4260
        public void get_DefaultTransitionEasing(){} // RVA: 0x7FFD4FBE4270
        public void set_DefaultTransitionEasing(){} // RVA: 0x7FFD4FBE4280
        public void get_AutoCloseVideo(){} // RVA: 0x7FFD4FBE4290
        public void set_AutoCloseVideo(){} // RVA: 0x7FFD4FBE42A0
        public void get_LoopMode(){} // RVA: 0x7FFD4FBE42B0
        public void set_LoopMode(){} // RVA: 0x7FFD4FBE42C0
        public void get_AutoProgress(){} // RVA: 0x7FFD4FBE42D0
        public void set_AutoProgress(){} // RVA: 0x7FFD4FBE42E0
        public void get_Info(){} // RVA: 0x7FFD4FBE42F0
        public void get_Control(){} // RVA: 0x7FFD4FBE4400
        public void get_TextureProducer(){} // RVA: 0x7FFD4FBE4510
        public void get_AudioVolume(){} // RVA: 0x7FFD4FBE4640
        public void set_AudioVolume(){} // RVA: 0x7FFD4FBE4650
        public void get_AudioMuted(){} // RVA: 0x7FFD4FBE47A0
        public void set_AudioMuted(){} // RVA: 0x7FFD4FBE47B0
        public void Play(){} // RVA: 0x7FFD4FBE48E0
        public void Pause(){} // RVA: 0x7FFD4FBE49F0
        public void IsPaused(){} // RVA: 0x7FFD4FBE4AF0
        public void SwapPlayers(){} // RVA: 0x7FFD4FBE4B00
        public void GetCurrentTexture(){} // RVA: 0x7FFD4FBE54F0
        public void GetNextTexture(){} // RVA: 0x7FFD4FBE5650
        public void Awake(){} // RVA: 0x7FFD4FBE57A0
        public void OnDestroy(){} // RVA: 0x7FFD4FBE5B50
        public void Start(){} // RVA: 0x7FFD4FBE5E90
        public void OnVideoEvent(){} // RVA: 0x7FFD4FBE60F0
        public void PrevItem(){} // RVA: 0x7FFD4FBE64B0
        public void NextItem(){} // RVA: 0x7FFD4FBE64C0
        public void CanJumpToItem(){} // RVA: 0x7FFD4FBE6540
        public void JumpToItem(){} // RVA: 0x7FFD4FBE6620
        public void OpenVideoFile(){} // RVA: 0x7FFD4FBE67F0
        public void IsTransitioning(){} // RVA: 0x7FFD4FBE6BA0
        public void SetTransition(){} // RVA: 0x7FFD4FBE6CA0
        public void Update(){} // RVA: 0x7FFD4FBE6E70
        public void GetTexture(){} // RVA: 0x7FFD4E9613D0
        public void GetTextureCount(){} // RVA: 0x7FFD4FBE7510
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4FBE7590
        public void SupportsTextureFrameCount(){} // RVA: 0x7FFD4FBE7610
        public void GetTextureTimeStamp(){} // RVA: 0x7FFD4FBE7690
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFD4FBE7710
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4FBE7790
        public void GetYpCbCrTransform(){} // RVA: 0x7FFD4FBE7810
        public void GetTextureStereoPacking(){} // RVA: 0x7FFD4FBE78C0
        public void GetTextureTransparency(){} // RVA: 0x7FFD4FBE7940
        public void GetTextureAlphaPacking(){} // RVA: 0x7FFD4FBE79C0
        public void GetTransitionName(){} // RVA: 0x7FFD4FBE7A40
        public void .ctor(){} // RVA: 0x7FFD4FBE7D70
        public void .cctor(){} // RVA: 0x7FFD4FBE8010
    }

    public class Resampler : Object
    {
        public object DroppedFrames;
        public object FrameDisplayedTimer;
        public object BaseTimestamp;
        public object ElapsedTimeSinceBase;
        public object LastT;
        public object TextureTimeStamp;
        public object OutputTexture;

        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x7FFD4FBDAB50
        public void get_FrameDisplayedTimer(){} // RVA: 0x7FFD4F9B6EF0
        public void get_BaseTimestamp(){} // RVA: 0x7FFD4E5F0140
        public void set_BaseTimestamp(){} // RVA: 0x7FFD4E9433F0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7FFD4E5080B0
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7FFD4E50FD80
        public void get_LastT(){} // RVA: 0x7FFD4E8525D0
        public void set_LastT(){} // RVA: 0x7FFD4E84DD70
        public void get_TextureTimeStamp(){} // RVA: 0x7FFD4E70F640
        public void set_TextureTimeStamp(){} // RVA: 0x7FFD4EB25AA0
        public void OnVideoEvent(){} // RVA: 0x7FFD4FC03870
        public void .ctor(){} // RVA: 0x7FFD4FC03950
        public void get_OutputTexture(){} // RVA: 0x7FFD4E36F0C0
        public void Reset(){} // RVA: 0x7FFD4FC03E90
        public void Release(){} // RVA: 0x7FFD4FC03EB0
        public void ReleaseRenderTextures(){} // RVA: 0x7FFD4FC04040
        public void ConstructRenderTextures(){} // RVA: 0x7FFD4FC04390
        public void CheckRenderTexturesValid(){} // RVA: 0x7FFD4FC04970
        public void FindBeforeFrameIndex(){} // RVA: 0x7FFD4FC04DE0
        public void FindClosestFrame(){} // RVA: 0x7FFD4FC05020
        public void PointUpdate(){} // RVA: 0x7FFD4FC05200
        public void SampleFrame(){} // RVA: 0x7FFD4FC05530
        public void SampleFrames(){} // RVA: 0x7FFD4FC05700
        public void LinearUpdate(){} // RVA: 0x7FFD4FC05AD0
        public void InvalidateBuffer(){} // RVA: 0x7FFD4FC05CF0
        public void GuessFrameRate(){} // RVA: 0x7FFD4FC05DF0
        public void Update(){} // RVA: 0x7FFD4FC060B0
        public void UpdateTimestamp(){} // RVA: 0x7FFD4FC06DD0
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        public object MediaPlayer;
        public object VideoResolveOptions;
        public object ExternalTexture;
        public object TargetTexture;

        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0x7FFD4E36F0C0
        public void set_MediaPlayer(){} // RVA: 0x7FFD4FBE8A90
        public void get_VideoResolveOptions(){} // RVA: 0x7FFD4FBE8AA0
        public void set_VideoResolveOptions(){} // RVA: 0x7FFD4FBE8AC0
        public void get_ExternalTexture(){} // RVA: 0x7FFD4E3DF370
        public void set_ExternalTexture(){} // RVA: 0x7FFD4E3DF380
        public void get_TargetTexture(){} // RVA: 0x7FFD4FBE8AE0
        public void SetMaterialDirty(){} // RVA: 0x7FFD4E4F1E70
        public void ChangeMediaPlayer(){} // RVA: 0x7FFD4FBE8BC0
        public void Start(){} // RVA: 0x7FFD4FBE8D60
        public void LateUpdate(){} // RVA: 0x7FFD4FBE9050
        public void Resolve(){} // RVA: 0x7FFD4FBE9060
        public void OnDisable(){} // RVA: 0x7FFD4FBE9850
        public void OnDestroy(){} // RVA: 0x7FFD4FBE99C0
        public void .ctor(){} // RVA: 0x7FFD4FBE9B00
    }

    public class Subtitle : Object
    {
        // ── Methods ──
        public void IsBefore(){} // RVA: 0x7FFD4FC06DF0
        public void IsTime(){} // RVA: 0x7FFD4FC06E10
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SubtitlesUGUI : MonoBehaviour
    {
        public object Player;
        public object Text;

        // ── Methods ──
        public void set_Player(){} // RVA: 0x7FFD4FBD3BE0
        public void get_Player(){} // RVA: 0x7FFD4E36F0C0
        public void set_Text(){} // RVA: 0x7FFD4E342E90
        public void get_Text(){} // RVA: 0x7FFD4E36F130
        public void Start(){} // RVA: 0x7FFD4FBD3BF0
        public void OnDestroy(){} // RVA: 0x7FFD4FBD3C00
        public void Update(){} // RVA: 0x7FFD4FBD3C10
        public void ChangeMediaPlayer(){} // RVA: 0x7FFD4FBD3C20
        public void SetText(){} // RVA: 0x7FFD4FBD3F60
        public void PrepareText(){} // RVA: 0x7FFD4FBD3FA0
        public void UpdateBackgroundRect(){} // RVA: 0x7FFD4FBD4110
        public void OnMediaPlayerEvent(){} // RVA: 0x7FFD4FBD43C0
        public void .ctor(){} // RVA: 0x7FFD4FBD4610
    }

    public class TextCue : Object
    {
        public object Text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void get_Text(){} // RVA: 0x7FFD4E35C380
        public void set_Text(){} // RVA: 0x7FFD4E342E30
    }

    public class TrackBase : Object
    {
        public object Uid;
        public object TrackType;
        public object DisplayName;
        public object Name;
        public object Language;
        public object IsDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC027D0 | overloaded x2
        public void get_Uid(){} // RVA: 0x7FFD4E38E5C0
        public void set_Uid(){} // RVA: 0x7FFD4E3440C0
        public void get_TrackType(){} // RVA: 0x7FFD4E7F5A20
        public void set_TrackType(){} // RVA: 0x7FFD4E7F4990
        public void get_DisplayName(){} // RVA: 0x7FFD4E3447C0
        public void set_DisplayName(){} // RVA: 0x7FFD4E3A7E80
        public void get_Name(){} // RVA: 0x7FFD4E36F0C0
        public void set_Name(){} // RVA: 0x7FFD4E36F0D0
        public void get_Language(){} // RVA: 0x7FFD4E36F130
        public void set_Language(){} // RVA: 0x7FFD4E342E90
        public void get_IsDefault(){} // RVA: 0x7FFD4E367450
        public void set_IsDefault(){} // RVA: 0x7FFD4E367460
        public void CreateDisplayName(){} // RVA: 0x7FFD4FC02A50
    }

    public class TrackCollection : Object
    {
        public object TrackType;
        public object Count;

        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7FFD4E38E5C0
        public void set_TrackType(){} // RVA: 0x7FFD4E3440C0
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void HasActiveTrack(){} // RVA: 0x7FFD4E079D00
        public void IsActiveTrack(){} // RVA: 0x7FFD4E079F60
        public void SetActiveTrack(){} // RVA: 0x7FFD4E090A40
        public void SetFirstTrackActive(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TrackCollection`1 : TrackCollection
    {
        public object Item;
        public object ActiveTrack;
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_ActiveTrack(){} // RVA: 0x7FFD4E2ADC40
        public void set_ActiveTrack(){} // RVA: 0x7FFD4E2ADC40
        public void HasActiveTrack(){} // RVA: 0x7FFD4E079D00
        public void IsActiveTrack(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void SetActiveTrack(){} // RVA: 0x7FFD4E090A40
        public void SetFirstTrackActive(){} // RVA: 0x7FFD4E090980
        public void get_Count(){} // RVA: 0x7FFD4E079960
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        public object Camera;

        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7FFD4E36F0C0
        public void set_Camera(){} // RVA: 0x7FFD4E36F0D0
        public void Awake(){} // RVA: 0x7FFD4FBE9BD0
        public void Start(){} // RVA: 0x7FFD4FBE9CE0
        public void LogXRDeviceDetails(){} // RVA: 0x7FFD4FBE9CF0
        public void IsMultiPassVrEnabled(){} // RVA: 0x7FFD4FBEA270
        public void LateUpdate(){} // RVA: 0x7FFD4FBEA310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD4FBEAC40
    }

    public class VideoRender : Object
    {
        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x7FFD4FC075D0
        public void CreateIMGUIMaterial(){} // RVA: 0x7FFD4FC07670
        public void SetupLayoutMaterial(){} // RVA: 0x7FFD4FC076F0
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x7FFD4FC07870
        public void SetupStereoMaterial(){} // RVA: 0x7FFD4FC079C0
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x7FFD4FC07C80
        public void SetupAlphaPackedMaterial(){} // RVA: 0x7FFD4FC07D50
        public void SetupGammaMaterial(){} // RVA: 0x7FFD4FC07EA0
        public void SetupTextureMatrix(){} // RVA: 0x7FFD4E341310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x7FFD4FC07FA0
        public void GetTexture(){} // RVA: 0x7FFD4FC080E0
        public void SetupMaterialForMedia(){} // RVA: 0x7FFD4FC08290
        public void SetupMaterial(){} // RVA: 0x7FFD4FC088E0
        public void SetupResolveMaterial(){} // RVA: 0x7FFD4FC090F0
        public void ResolveVideoToRenderTexture(){} // RVA: 0x7FFD4FC09580
        public void GetResolveTextureSize(){} // RVA: 0x7FFD4FC09EB0
        public void RequiresResolve(){} // RVA: 0x7FFD4FC09F60
        public void DrawTexture(){} // RVA: 0x7FFD4FC0A010
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FC0A7F0
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x7FFD4FBF35F0
        public void DeinitPlatform(){} // RVA: 0x7FFD4FBF3AC0
        public void GetAudioChannelCount(){} // RVA: 0x7FFD4FBF3B70
        public void GetAudioChannelMask(){} // RVA: 0x7FFD4FBF3BF0
        public void .ctor(){} // RVA: 0x7FFD4FBF3EE0 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFD4FBF4140
        public void GetVersion(){} // RVA: 0x7FFD4FBF4480
        public void GetExpectedVersion(){} // RVA: 0x7FFD4FBF44E0
        public void UseNativeMips(){} // RVA: 0x7FFD4FBF4520
        public void OpenMedia(){} // RVA: 0x7FFD4FBF4530
        public void OpenMediaFromBuffer(){} // RVA: 0x7FFD4FBF4D00
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7FFD4FBF51D0
        public void AddChunkToMediaBuffer(){} // RVA: 0x7FFD4FBF52A0
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7FFD4FBF5360
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x7FFD4FBF57B0
        public void CloseMedia(){} // RVA: 0x7FFD4FBF5980
        public void SetLooping(){} // RVA: 0x7FFD4FBF5B20
        public void IsLooping(){} // RVA: 0x7FFD4E46CF80
        public void HasMetaData(){} // RVA: 0x7FFD4FBF5BB0
        public void HasAudio(){} // RVA: 0x7FFD4E3C2AD0
        public void HasVideo(){} // RVA: 0x7FFD4F286790
        public void CanPlay(){} // RVA: 0x7FFD4FBF5BC0
        public void Play(){} // RVA: 0x7FFD4FBF5BD0
        public void Pause(){} // RVA: 0x7FFD4FBF5C60
        public void Stop(){} // RVA: 0x7FFD4FBF5C60
        public void IsSeeking(){} // RVA: 0x7FFD4FBF5C80
        public void IsPlaying(){} // RVA: 0x7FFD4FBF5D10
        public void IsPaused(){} // RVA: 0x7FFD4FBF5D90
        public void IsFinished(){} // RVA: 0x7FFD4FBF5DD0
        public void IsBuffering(){} // RVA: 0x7FFD4FBF5EC0
        public void GetDuration(){} // RVA: 0x7FFD4FBF5F50
        public void GetVideoWidth(){} // RVA: 0x7FFD4FBF5FD0
        public void GetVideoHeight(){} // RVA: 0x7FFD4FBF5FE0
        public void GetVideoFrameRate(){} // RVA: 0x7FFD4FBF5FF0
        public void GetTexture(){} // RVA: 0x7FFD4FBF6000
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4FBF6110
        public void GetTextureTimeStamp(){} // RVA: 0x7FFD4FBF6120
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFD4FBF61A0
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4F2834D0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFD4FBF6250
        public void Seek(){} // RVA: 0x7FFD4FBF62D0
        public void SeekFast(){} // RVA: 0x7FFD4FBF6390
        public void GetCurrentTime(){} // RVA: 0x7FFD4FBF6450
        public void SetPlaybackRate(){} // RVA: 0x7FFD4FBF64D0
        public void GetPlaybackRate(){} // RVA: 0x7FFD4FBF6560
        public void MuteAudio(){} // RVA: 0x7FFD4FBF65E0
        public void IsMuted(){} // RVA: 0x7FFD4FBDB130
        public void SetVolume(){} // RVA: 0x7FFD4FBF6670
        public void GetVolume(){} // RVA: 0x7FFD4FBF6710
        public void SetBalance(){} // RVA: 0x7FFD4FBF6720
        public void GetBalance(){} // RVA: 0x7FFD4E7EE4B0
        public void IsPlaybackStalled(){} // RVA: 0x7FFD4FBF67C0
        public void WaitForNextFrame(){} // RVA: 0x7FFD4FBF6870
        public void SetAudioChannelMode(){} // RVA: 0x7FFD4FBF6A80
        public void SetAudioHeadRotation(){} // RVA: 0x7FFD4FBF6B10
        public void ResetAudioHeadRotation(){} // RVA: 0x7FFD4FBF6B50
        public void SetAudioFocusEnabled(){} // RVA: 0x7FFD4FBF6C70
        public void SetAudioFocusProperties(){} // RVA: 0x7FFD4FBF6C80
        public void SetAudioFocusRotation(){} // RVA: 0x7FFD4FBF6C90
        public void ResetAudioFocus(){} // RVA: 0x7FFD4FBF6CD0
        public void Update(){} // RVA: 0x7FFD4FBF6D40
        public void ReleaseTexture(){} // RVA: 0x7FFD4FBF7580
        public void UpdateTexture(){} // RVA: 0x7FFD4FBF7820
        public void EndUpdate(){} // RVA: 0x7FFD4FBF7FC0
        public void GetLastExtendedErrorCode(){} // RVA: 0x7FFD4FBF8040
        public void OnTextureSizeChanged(){} // RVA: 0x7FFD4E341310
        public void BeginRender(){} // RVA: 0x7FFD4FBF80C0
        public void Render(){} // RVA: 0x7FFD4FBF8110
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void GrabAudio(){} // RVA: 0x7FFD4FBF8170
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFD4FBF8230
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFD4FBF82B0
        public void GetDecoderPerformance(){} // RVA: 0x7FFD4FBF82C0
        public void IssueRenderThreadEvent(){} // RVA: 0x7FFD4FBF8370
        public void GetPluginVersion(){} // RVA: 0x7FFD4FBF8490
        public void InternalSetActiveTrack(){} // RVA: 0x7FFD4FBF8560
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFD4FBF8610
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFD4FBF86A0
        public void InternalIsChangedTracks(){} // RVA: 0x7FFD4FBF8770
        public void InternalGetTrackCount(){} // RVA: 0x7FFD4FBF8810
        public void InternalGetTrackInfo(){} // RVA: 0x7FFD4FBF88B0
        public void UpdateTimeRanges(){} // RVA: 0x7FFD4FBF8D00
        public void UpdateTimeRange(){} // RVA: 0x7FFD4FBF8D70
        public void FlushFrameBuffering(){} // RVA: 0x7FFD4FBF8E80
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7FFD4FBF8FD0
        public void LogBufferState(){} // RVA: 0x7FFD4FBF97C0
        public void SetBufferedDisplayTime(){} // RVA: 0x7FFD4FBF9B90
        public void GetBufferedFramesState(){} // RVA: 0x7FFD4FBF9C50
        public void SetBufferedDisplayMode(){} // RVA: 0x7FFD4FBF9CF0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7FFD4FBF9E10
        public void SetSlaves(){} // RVA: 0x7FFD4FBF9E40
        public void IsPrerollComplete(){} // RVA: 0x7FFD4FBF9FB0
        public void .cctor(){} // RVA: 0x7FFD4FBFA140
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        public object AuthenticationData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FBFD8E0 | overloaded x2
        public void CanPlay(){} // RVA: 0x7FFD4FBFDBC0
        public void Dispose(){} // RVA: 0x7FFD4FBFDBE0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7FFD4E341320
        public void GetCurrentTime(){} // RVA: 0x7FFD4FBFDD60
        public void GetDuration(){} // RVA: 0x7FFD4FBFDDE0
        public void GetPlaybackRate(){} // RVA: 0x7FFD4FBFDDF0
        public void GetTexture(){} // RVA: 0x7FFD4FBFDE70
        public void GetTextureCount(){} // RVA: 0x7FFD4FBFDEC0
        public void GetTextureFrameCount(){} // RVA: 0x7FFD4F73B350
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7FFD4FBFDFD0
        public void GetVersion(){} // RVA: 0x7FFD4FBFE050
        public void GetExpectedVersion(){} // RVA: 0x7FFD4FBFE0B0
        public void GetVideoFrameRate(){} // RVA: 0x7FFD4FBFE0F0
        public void GetVideoWidth(){} // RVA: 0x7FFD4FBFE1A0
        public void GetVideoHeight(){} // RVA: 0x7FFD4FBFE2E0
        public void GetVolume(){} // RVA: 0x7FFD4FBFE420
        public void SetBalance(){} // RVA: 0x7FFD4FBFE4A0
        public void GetBalance(){} // RVA: 0x7FFD4FBFE530
        public void HasAudio(){} // RVA: 0x7FFD4FBFE5B0
        public void HasMetaData(){} // RVA: 0x7FFD4FBFE5F0
        public void HasVideo(){} // RVA: 0x7FFD4FBFE620
        public void IsBuffering(){} // RVA: 0x7FFD4FBFE660
        public void IsFinished(){} // RVA: 0x7FFD4FBFE680
        public void IsLooping(){} // RVA: 0x7FFD4FBFE730
        public void IsMuted(){} // RVA: 0x7FFD4FBFE7C0
        public void IsPaused(){} // RVA: 0x7FFD4FBFE850
        public void IsPlaying(){} // RVA: 0x7FFD4FBFE870
        public void IsSeeking(){} // RVA: 0x7FFD4FBFE890
        public void MuteAudio(){} // RVA: 0x7FFD4FBFE8B0
        public void OpenMedia(){} // RVA: 0x7FFD4FBFE940
        public void CloseMedia(){} // RVA: 0x7FFD4FBFEB50
        public void Pause(){} // RVA: 0x7FFD4FBFEBF0
        public void Play(){} // RVA: 0x7FFD4FBFEC70
        public void Render(){} // RVA: 0x7FFD4FBFECF0
        public void Update_Textures(){} // RVA: 0x7FFD4FBFED70
        public void get_AuthenticationData(){} // RVA: 0x7FFD4E3AC040
        public void set_AuthenticationData(){} // RVA: 0x7FFD4FBFF280
        public void RequiresVerticalFlip(){} // RVA: 0x7FFD4E426850
        public void Seek(){} // RVA: 0x7FFD4FBFF2F0
        public void SeekFast(){} // RVA: 0x7FFD4FBEC700
        public void SetLooping(){} // RVA: 0x7FFD4FBFF380
        public void SetPlaybackRate(){} // RVA: 0x7FFD4FBFF410
        public void SetVolume(){} // RVA: 0x7FFD4FBFF4A0
        public void Stop(){} // RVA: 0x7FFD4FBFF530
        public void UpdateTimeRanges(){} // RVA: 0x7FFD4FBFF550
        public void UpdateTimeRange(){} // RVA: 0x7FFD4FBFF5C0
        public void GetProgramDateTime(){} // RVA: 0x7FFD4FBFF6D0
        public void Update(){} // RVA: 0x7FFD4FBFF8D0
        public void SetKeyServerAuthToken(){} // RVA: 0x7FFD4FBFFDB0
        public void SetOverrideDecryptionKey(){} // RVA: 0x7FFD4FBFFE30
        public void InternalSetActiveTrack(){} // RVA: 0x7FFD4FBFFEB0
        public void InternalIsChangedTracks(){} // RVA: 0x7FFD4FBFFF50
        public void InternalGetTrackCount(){} // RVA: 0x7FFD4FBFFFE0
        public void InternalGetTrackInfo(){} // RVA: 0x7FFD4FC00070
        public void InternalIsChangedTextCue(){} // RVA: 0x7FFD4FC00450
        public void InternalGetCurrentTextCue(){} // RVA: 0x7FFD4FC004E0
        public void InitialisePlatform(){} // RVA: 0x7FFD4FC005B0
        public void DeinitPlatform(){} // RVA: 0x7FFD4FC00930
        public void .cctor(){} // RVA: 0x7FFD4FC00990
    }

}