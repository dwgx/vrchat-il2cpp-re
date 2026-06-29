// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 70
// Methods: 1241

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class ApplyToBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0x7A81052C0
        public void set_Player(){} // RVA: 0x7A9AA3BE0
        public void get_AutomaticStereoPacking(){} // RVA: 0x7A84A5BD0
        public void set_AutomaticStereoPacking(){} // RVA: 0x7A9AA3BF0
        public void get_OverrideStereoPacking(){} // RVA: 0x7A8F9ACE0
        public void set_OverrideStereoPacking(){} // RVA: 0x7A9AA3C00
        public void get_StereoRedGreenTint(){} // RVA: 0x7A80FD690
        public void set_StereoRedGreenTint(){} // RVA: 0x7A9AA3C10
        public void Awake(){} // RVA: 0x7A9AA3C20
        public void ChangeMediaPlayer(){} // RVA: 0x7A9AA3C30
        public void OnMediaPlayerEvent(){} // RVA: 0x7A9AA3FA0
        public void ForceUpdate(){} // RVA: 0x7A9AA3FC0
        public void Start(){} // RVA: 0x7A9AA4040
        public void OnEnable(){} // RVA: 0x7A9AA4080
        public void OnDisable(){} // RVA: 0x7A9AA40B0
        public void OnDestroy(){} // RVA: 0x7A9AA40D0
        public void SaveProperties(){} // RVA: 0x7A80D7310
        public void RestoreProperties(){} // RVA: 0x7A80D7310
        public void Apply(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A810ED60
    }

    public class ApplyToMaterial : ApplyToBase
    {
        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7A8292C30
        public void set_DefaultTexture(){} // RVA: 0x7A9A8D860
        public void get_Material(){} // RVA: 0x7A8154D80
        public void set_Material(){} // RVA: 0x7A9A8D9E0
        public void get_TexturePropertyName(){} // RVA: 0x7A8152D80
        public void set_TexturePropertyName(){} // RVA: 0x7A9A8DB60
        public void get_Offset(){} // RVA: 0x7A9A8DCE0
        public void set_Offset(){} // RVA: 0x7A9A8DD00
        public void get_Scale(){} // RVA: 0x7A9A8DD50
        public void set_Scale(){} // RVA: 0x7A9A8DD70
        public void LateUpdate(){} // RVA: 0x7A874BF50
        public void Apply(){} // RVA: 0x7A9A8DDC0
        public void ApplyMapping(){} // RVA: 0x7A9A8E370
        public void SaveProperties(){} // RVA: 0x7A9A8EA60
        public void RestoreProperties(){} // RVA: 0x7A9A8EDB0
        public void .ctor(){} // RVA: 0x7A9A8EF90
    }

    public class ApplyToMesh : ApplyToBase
    {
        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0x7A8292C30
        public void set_DefaultTexture(){} // RVA: 0x7A9A8F170
        public void get_MeshRenderer(){} // RVA: 0x7A8154D80
        public void set_MeshRenderer(){} // RVA: 0x7A9A8F300
        public void get_MaterialIndex(){} // RVA: 0x7A8178B70
        public void set_MaterialIndex(){} // RVA: 0x7A8178B80
        public void ChangeDefaultTexture(){} // RVA: 0x7A9A8F170
        public void ChangeRenderer(){} // RVA: 0x7A9A8F310
        public void get_TexturePropertyName(){} // RVA: 0x7A8178B90
        public void set_TexturePropertyName(){} // RVA: 0x7A9A8F5A0
        public void get_Offset(){} // RVA: 0x7A9A8DD50
        public void set_Offset(){} // RVA: 0x7A9A8DD70
        public void get_Scale(){} // RVA: 0x7A9A8F720
        public void set_Scale(){} // RVA: 0x7A9A8F740
        public void LateUpdate(){} // RVA: 0x7A874BF50
        public void Apply(){} // RVA: 0x7A9A8F790
        public void ApplyMapping(){} // RVA: 0x7A9A8FD50
        public void OnEnable(){} // RVA: 0x7A9A90490
        public void OnDisable(){} // RVA: 0x7A9A90790
        public void .ctor(){} // RVA: 0x7A9A907C0
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        // ── Methods ──
        public void get_Channel(){} // RVA: 0x7A81052C0
        public void set_Channel(){} // RVA: 0x7A81052D0
        public void Reset(){} // RVA: 0x7A9A90910
        public void ChangeChannelCount(){} // RVA: 0x7A9A909E0
        public void OnAudioFilterRead(){} // RVA: 0x7A9A90B40
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioOutput : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0x7A81052C0
        public void set_Player(){} // RVA: 0x7A9A90D50
        public void get_OutputMode(){} // RVA: 0x7A854FDE0
        public void set_OutputMode(){} // RVA: 0x7A8810F60
        public void get_ChannelMask(){} // RVA: 0x7A8F9ACE0
        public void set_ChannelMask(){} // RVA: 0x7A98B6D80
        public void Awake(){} // RVA: 0x7A9A90D60
        public void Start(){} // RVA: 0x7A9A90DF0
        public void OnAudioConfigurationChanged(){} // RVA: 0x7A9A90E80
        public void OnDestroy(){} // RVA: 0x7A9A90FD0
        public void Update(){} // RVA: 0x7A9A90FE0
        public void GetAudioSource(){} // RVA: 0x7A8292C30
        public void ChangeMediaPlayer(){} // RVA: 0x7A9A91120
        public void OnMediaPlayerEvent(){} // RVA: 0x7A9A91830
        public void ApplyAudioSettings(){} // RVA: 0x7A80D7310
        public void OnAudioFilterRead(){} // RVA: 0x7A9A918F0
        public void .ctor(){} // RVA: 0x7A9A91AD0
    }

    public class AudioOutputManager : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7A9AA40E0
        public void .ctor(){} // RVA: 0x7A9AA4260
        public void RequestAudio(){} // RVA: 0x7A9AA4320
        public void ZeroAudio(){} // RVA: 0x7A9AA4E10
        public void GrabAudio(){} // RVA: 0x7A9AA4E60
        public void _instance(){} // RVA: 0x7B2E3DF00
    }

    public class AudioTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9ABBCD0
        public void get_Bitrate(){} // RVA: 0x7A8D863F0
        public void set_Bitrate(){} // RVA: 0x7A8D870E0
        public void get_ChannelCount(){} // RVA: 0x7A864E8D0
        public void set_ChannelCount(){} // RVA: 0x7A9ABBD00
    }

    public class AudioTrack[] : Array
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

    public class AudioTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7A81CA9D0
        public void .ctor(){} // RVA: 0x7A9ABBC20
    }

    public class AuthData : Object
    {
        // ── Methods ──
        public void get_URL(){} // RVA: 0x7A80F2570
        public void set_URL(){} // RVA: 0x7A80D8E20
        public void get_Token(){} // RVA: 0x7A80DA7B0
        public void set_Token(){} // RVA: 0x7A813E420
        public void get_KeyBytes(){} // RVA: 0x7A81052C0
        public void set_KeyBytes(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A9AB6210
        public void Clear(){} // RVA: 0x7A9AB6210
        public void get_KeyBase64(){} // RVA: 0x7A9AB6360
        public void set_KeyBase64(){} // RVA: 0x7A9AB6460
    }

    public class BaseMediaPlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AA4F80
        public void GetVersion(){} // RVA: 0x7A7E00680
        public void GetExpectedVersion(){} // RVA: 0x7A7E00680
        public void OpenMedia(){} // RVA: 0x7A7E04B50
        public void OpenMediaFromBuffer(){} // RVA: 0x7A80D7320
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7A80D7320
        public void AddChunkToMediaBuffer(){} // RVA: 0x7A80D7320
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7A80D7320
        public void CloseMedia(){} // RVA: 0x7A9AA5510
        public void SetLooping(){} // RVA: 0x7A7E18C30
        public void IsLooping(){} // RVA: 0x7A7E01900
        public void HasMetaData(){} // RVA: 0x7A7E01900
        public void CanPlay(){} // RVA: 0x7A7E01900
        public void Play(){} // RVA: 0x7A7E18770
        public void Pause(){} // RVA: 0x7A7E18770
        public void Stop(){} // RVA: 0x7A7E18770
        public void Rewind(){} // RVA: 0x7A9AA5600
        public void Seek(){} // RVA: 0x7A7E19E10
        public void SeekFast(){} // RVA: 0x7A7E19E10
        public void SeekWithTolerance(){} // RVA: 0x7A9AA5620
        public void GetCurrentTime(){} // RVA: 0x7A7E06760
        public void GetProgramDateTime(){} // RVA: 0x7A9AA5640
        public void GetPlaybackRate(){} // RVA: 0x7A7E155B0
        public void SetPlaybackRate(){} // RVA: 0x7A7E262C0
        public void GetDuration(){} // RVA: 0x7A7E06760
        public void GetVideoWidth(){} // RVA: 0x7A7E00710
        public void GetVideoHeight(){} // RVA: 0x7A7E00710
        public void GetVideoFrameRate(){} // RVA: 0x7A7E155B0
        public void GetVideoDisplayRate(){} // RVA: 0x7A813FA00
        public void HasAudio(){} // RVA: 0x7A7E01900
        public void HasVideo(){} // RVA: 0x7A7E01900
        public void IsVideoStereo(){} // RVA: 0x7A9AA56A0
        public void IsSeeking(){} // RVA: 0x7A7E01900
        public void IsPlaying(){} // RVA: 0x7A7E01900
        public void IsPaused(){} // RVA: 0x7A7E01900
        public void IsFinished(){} // RVA: 0x7A7E01900
        public void IsBuffering(){} // RVA: 0x7A7E01900
        public void WaitForNextFrame(){} // RVA: 0x7A80D7320
        public void GetTextureCount(){} // RVA: 0x7A81CA9D0
        public void GetTexture(){} // RVA: 0x7A7E00740
        public void GetTextureFrameCount(){} // RVA: 0x7A7E00710
        public void SupportsTextureFrameCount(){} // RVA: 0x7A81BD750
        public void GetTextureTimeStamp(){} // RVA: 0x7A9AA56D0
        public void RequiresVerticalFlip(){} // RVA: 0x7A7E01900
        public void GetTextureTransform(){} // RVA: 0x7A9AA56E0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7A92BE0A0
        public void GetYpCbCrTransform(){} // RVA: 0x7A9AA5750
        public void GetTextureStereoPacking(){} // RVA: 0x7A9AA57B0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7A7E00710
        public void GetTextureTransparency(){} // RVA: 0x7A854FDE0
        public void GetTextureAlphaPacking(){} // RVA: 0x7A9AA57E0
        public void MuteAudio(){} // RVA: 0x7A7E18C30
        public void IsMuted(){} // RVA: 0x7A7E01900
        public void SetVolume(){} // RVA: 0x7A7E262C0
        public void SetBalance(){} // RVA: 0x7A80D7310
        public void GetVolume(){} // RVA: 0x7A7E155B0
        public void GetBalance(){} // RVA: 0x7A889BC60
        public void GetAudioChannelCount(){} // RVA: 0x7A85193D0
        public void GetAudioChannelMask(){} // RVA: 0x7A82D1450
        public void GrabAudio(){} // RVA: 0x7A82D1450
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7A82D1450
        public void AudioConfigurationChanged(){} // RVA: 0x7A80D7310
        public void SetAudioHeadRotation(){} // RVA: 0x7A80D7310
        public void ResetAudioHeadRotation(){} // RVA: 0x7A80D7310
        public void SetAudioChannelMode(){} // RVA: 0x7A80D7310
        public void SetAudioFocusEnabled(){} // RVA: 0x7A80D7310
        public void SetAudioFocusProperties(){} // RVA: 0x7A80D7310
        public void SetAudioFocusRotation(){} // RVA: 0x7A80D7310
        public void ResetAudioFocus(){} // RVA: 0x7A80D7310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7A9AA5820
        public void SetPlayWithoutBuffering(){} // RVA: 0x7A80D7310
        public void IsMediaCachingSupported(){} // RVA: 0x7A80D7320
        public void AddMediaToCache(){} // RVA: 0x7A80D7310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7A80D7310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7A80D7310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7A80D7310
        public void RemoveMediaFromCache(){} // RVA: 0x7A80D7310
        public void GetCachedMediaStatus(){} // RVA: 0x7A82D1450
        public void IsExternalPlaybackSupported(){} // RVA: 0x7A80D7320
        public void IsExternalPlaybackActive(){} // RVA: 0x7A80D7320
        public void SetAllowsExternalPlayback(){} // RVA: 0x7A80D7310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7A80D7310
        public void SetKeyServerAuthToken(){} // RVA: 0x7A80D7310
        public void SetOverrideDecryptionKey(){} // RVA: 0x7A80D7310
        public void Update(){} // RVA: 0x7A7E18770
        public void BeginRender(){} // RVA: 0x7A80D7310
        public void Render(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
        public void GetDecoderPerformance(){} // RVA: 0x7A80D7320
        public void EndUpdate(){} // RVA: 0x7A80D7310
        public void GetNativePlayerHandle(){} // RVA: 0x7A82D1450
        public void GetLastError(){} // RVA: 0x7A9AA5830
        public void GetLastExtendedErrorCode(){} // RVA: 0x7A82D1450
        public void GetPlayerDescription(){} // RVA: 0x7A80F2570
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7A81BD750
        public void GetSeekableTimes(){} // RVA: 0x7A8292C30
        public void GetBufferedTimes(){} // RVA: 0x7A8154D80
        public void GetTextureProperties(){} // RVA: 0x7A9AA5840
        public void SetTextureProperties(){} // RVA: 0x7A9AA5860
        public void ApplyTextureProperties(){} // RVA: 0x7A9AA58F0
        public void UpdateDisplayFrameRate(){} // RVA: 0x7A9AA5AA0
        public void IsExpectingNewVideoFrame(){} // RVA: 0x7A9AA5B70
        public void IsPlaybackStalled(){} // RVA: 0x7A9AA5C70
        public void LoadSubtitlesSRT(){} // RVA: 0x7A9AA5EA0
        public void UpdateSubtitles(){} // RVA: 0x7A9AA6060
        public void GetSubtitleIndex(){} // RVA: 0x7A9AA61D0
        public void GetSubtitleText(){} // RVA: 0x7A9AA61F0
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void GetCurrentTimeFrames(){} // RVA: 0x7A9AA6270
        public void GetDurationFrames(){} // RVA: 0x7A9AA6360
        public void GetMaxFrameNumber(){} // RVA: 0x7A9AA6420
        public void SeekToFrameRelative(){} // RVA: 0x7A9AA6440
        public void SeekToFrame(){} // RVA: 0x7A9AA6590
        public void UpdateBufferedDisplay(){} // RVA: 0x7A9AA66A0
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7A82D1450
        public void GetBufferedFramesState(){} // RVA: 0x7A9AA6770
        public void SetSlaves(){} // RVA: 0x7A80D7310
        public void SetBufferedDisplayMode(){} // RVA: 0x7A80D7310
        public void SetBufferedDisplayOptions(){} // RVA: 0x7A80D7310
        public void GetPlaybackQualityStats(){} // RVA: 0x7A82C2060
        public void GetCurrentTextCue(){} // RVA: 0x7A825E100
        public void UpdateTextCue(){} // RVA: 0x7A9AA6790
        public void InternalIsChangedTextCue(){} // RVA: 0x7A7E01900
        public void InternalGetCurrentTextCue(){} // RVA: 0x7A7E00680
        public void GetVideoTracks(){} // RVA: 0x7A81163D0
        public void GetAudioTracks(){} // RVA: 0x7A8555100
        public void GetTextTracks(){} // RVA: 0x7A87D9C10
        public void GetActiveVideoTrack(){} // RVA: 0x7A9AA6950
        public void GetActiveAudioTrack(){} // RVA: 0x7A9AA69A0
        public void GetActiveTextTrack(){} // RVA: 0x7A9AA69F0
        public void SetActiveVideoTrack(){} // RVA: 0x7A9AA6A40
        public void SetActiveAudioTrack(){} // RVA: 0x7A9AA6A60
        public void SetActiveTextTrack(){} // RVA: 0x7A9AA6A80
        public void InternalIsChangedTracks(){} // RVA: 0x7A7E01F00
        public void InternalGetTrackCount(){} // RVA: 0x7A7E062A0
        public void InternalSetActiveTrack(){} // RVA: 0x7A7E01C20
        public void InternalGetTrackInfo(){} // RVA: 0x7A7E10B60
        public void InitTracks(){} // RVA: 0x7A9AA6AA0
        public void UpdateTracks(){} // RVA: 0x7A9AA6C30
        public void PopulateTrackCollection(){} // RVA: 0x7A9AA6CF0
        public void SetActiveTrack(){} // RVA: 0x7A9AA6EE0
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0x7A81052C0
        public void set_Player(){} // RVA: 0x7A9A91B30
        public void get_ScaleMode(){} // RVA: 0x7A854FDE0
        public void set_ScaleMode(){} // RVA: 0x7A8810F60
        public void get_Color(){} // RVA: 0x7A9A91C60
        public void set_Color(){} // RVA: 0x7A9A91C70
        public void get_AllowTransparency(){} // RVA: 0x7A823D790
        public void set_AllowTransparency(){} // RVA: 0x7A823D7A0
        public void get_UseDepth(){} // RVA: 0x7A927DA30
        public void set_UseDepth(){} // RVA: 0x7A9A91C80
        public void get_Depth(){} // RVA: 0x7A8178B30
        public void set_Depth(){} // RVA: 0x7A8178B40
        public void get_IsAreaFullScreen(){} // RVA: 0x7A98B2AB0
        public void set_IsAreaFullScreen(){} // RVA: 0x7A98B2AA0
        public void get_AreaX(){} // RVA: 0x7A8C85980
        public void set_AreaX(){} // RVA: 0x7A8C85840
        public void get_AreaY(){} // RVA: 0x7A8AD0680
        public void set_AreaY(){} // RVA: 0x7A8C85830
        public void get_AreaWidth(){} // RVA: 0x7A813FA00
        public void set_AreaWidth(){} // RVA: 0x7A813FA10
        public void get_AreaHeight(){} // RVA: 0x7A861F990
        public void set_AreaHeight(){} // RVA: 0x7A86200E0
        public void get_ShowAreaInEditor(){} // RVA: 0x7A8359360
        public void set_ShowAreaInEditor(){} // RVA: 0x7A8A21900
        public void Start(){} // RVA: 0x7A9A91C90
        public void Update(){} // RVA: 0x7A9A91F30
        public void OnDestroy(){} // RVA: 0x7A9A92010
        public void GetRequiredShader(){} // RVA: 0x7A9A92150
        public void SetupMaterial(){} // RVA: 0x7A9A92500
        public void OnGUI(){} // RVA: 0x7A9A92950
        public void GetAreaRect(){} // RVA: 0x7A9A93100
        public void .ctor(){} // RVA: 0x7A9A93380
    }

    public class DisplayUGUI : MaskableGraphic
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0x7A8158F50
        public void set_Player(){} // RVA: 0x7A9A889F0
        public void get_DefaultTexture(){} // RVA: 0x7A8158FC0
        public void set_DefaultTexture(){} // RVA: 0x7A9A88A00
        public void get_UVRect(){} // RVA: 0x7A9A88B80
        public void set_UVRect(){} // RVA: 0x7A9A88B90
        public void get_ApplyNativeSize(){} // RVA: 0x7A8F95140
        public void set_ApplyNativeSize(){} // RVA: 0x7A8F94B50
        public void get_ScaleMode(){} // RVA: 0x7A9A88BA0
        public void set_ScaleMode(){} // RVA: 0x7A981FB20
        public void get_NoDefaultDisplay(){} // RVA: 0x7A94BD7C0
        public void set_NoDefaultDisplay(){} // RVA: 0x7A94BD7D0
        public void get_DisplayInEditor(){} // RVA: 0x7A9905F50
        public void set_DisplayInEditor(){} // RVA: 0x7A9906160
        public void Awake(){} // RVA: 0x7A9A88BB0
        public void OnMediaPlayerEvent(){} // RVA: 0x7A9A88D00
        public void ChangeMediaPlayer(){} // RVA: 0x7A9A88E70
        public void EnsureShader(){} // RVA: 0x7A9A89200
        public void EnsureAlphaPackingShader(){} // RVA: 0x7A9A893C0
        public void EnsureStereoPackingShader(){} // RVA: 0x7A9A894B0
        public void EnsureAndroidOESShader(){} // RVA: 0x7A9A895A0
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x7A9A89690
        public void Start(){} // RVA: 0x7A9A89780
        public void OnDestroy(){} // RVA: 0x7A9A89920
        public void GetRequiredShader(){} // RVA: 0x7A9A89C60
        public void get_mainTexture(){} // RVA: 0x7A9A8A260
        public void HasValidTexture(){} // RVA: 0x7A9A8A460
        public void UpdateInternalMaterial(){} // RVA: 0x7A9A8A6D0
        public void LateUpdate(){} // RVA: 0x7A9A8AB60
        public void get_CurrentMediaPlayer(){} // RVA: 0x7A8158F50
        public void set_CurrentMediaPlayer(){} // RVA: 0x7A9A8B200
        public void get_uvRect(){} // RVA: 0x7A9A88B80
        public void set_uvRect(){} // RVA: 0x7A9A8B390
        public void SetNativeSize(){} // RVA: 0x7A9A8B400
        public void OnPopulateMesh(){} // RVA: 0x7A9A8B860
        public void _OnFillVBO(){} // RVA: 0x7A9A8B910
        public void GetDrawingDimensions(){} // RVA: 0x7A9A8BDD0
        public void .ctor(){} // RVA: 0x7A9A8C590
        public void .cctor(){} // RVA: 0x7A9A8C710
    }

    public class Helper : Object
    {
        // ── Methods ──
        public void GetPath(){} // RVA: 0x7A9AA7530
        public void GetFilePath(){} // RVA: 0x7A9AA76B0
        public void GetFriendlyResolutionName(){} // RVA: 0x7A9AA7900
        public void GetErrorMessage(){} // RVA: 0x7A9AA7C90
        public void GetPlatformName(){} // RVA: 0x7A9AA7E20
        public void GetPlatformNames(){} // RVA: 0x7A9AA7ED0
        public void LogInfo(){} // RVA: 0x7A9AA82E0
        public void GetUnityAudioSampleRate(){} // RVA: 0x7A9AA8440
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x7A9AA84F0
        public void GetTimelineRange(){} // RVA: 0x7A9AA85D0
        public void GetTimeString(){} // RVA: 0x7A9AA8630
        public void GetOrientation(){} // RVA: 0x7A9AA8A90
        public void GetMatrixForOrientation(){} // RVA: 0x7A9AA8CA0
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x7A9AA8EC0
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x7A9AA8F60
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x7A9AA8FA0
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x7A9AA90F0
        public void GetShortPathName(){} // RVA: 0x7A9AA9250
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x7A9AA9340
        public void GetReadableTexture(){} // RVA: 0x7A9AA9B30
        public void .cctor(){} // RVA: 0x7A9AA9E50
    }

    public class HttpHeader : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void IsComplete(){} // RVA: 0x7A7670290
        public void ToValidatedString(){} // RVA: 0x7A76702C0
        public void IsValid(){} // RVA: 0x7A76702D0
        public void IsAscii(){} // RVA: 0x7A9ABBF10
    }

    public class HttpHeaderData : Object
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7A9ABBFB0
        public void get_Item(){} // RVA: 0x7A9ABC090
        public void Clear(){} // RVA: 0x7A9ABC120
        public void Add(){} // RVA: 0x7A9ABC190
        public void IsModified(){} // RVA: 0x7A9ABC2C0
        public void ToValidatedString(){} // RVA: 0x7A9ABC310
        public void .ctor(){} // RVA: 0x7A9ABC540
    }

    public class HttpHeader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IAudioTracks
    {
        // ── Methods ──
        public void GetAudioTracks(){} // RVA: 0x7A7E00680
        public void GetActiveAudioTrack(){} // RVA: 0x7A7E00680
        public void SetActiveAudioTrack(){} // RVA: 0x7A7E18800
    }

    public class IBufferedDisplay
    {
        // ── Methods ──
        public void UpdateBufferedDisplay(){} // RVA: 0x7A7E00680
        public void GetBufferedFramesState(){} // RVA: 0x7A7E00490
        public void SetSlaves(){} // RVA: 0x7A7E18800
        public void SetBufferedDisplayMode(){} // RVA: 0x7A7E19BE0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7A7E18C30
    }

    public class IMediaCache
    {
        // ── Methods ──
        public void IsMediaCachingSupported(){} // RVA: 0x7A7E01900
        public void AddMediaToCache(){} // RVA: 0x7A7E1DDC0
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x7A7E18800
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x7A7E18800
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x7A7E18800
        public void RemoveMediaFromCache(){} // RVA: 0x7A7E18800
        public void GetCachedMediaStatus(){} // RVA: 0x7A7E06320
    }

    public class IMediaControl
    {
        // ── Methods ──
        public void OpenMedia(){} // RVA: 0x7A7E04B50
        public void OpenMediaFromBuffer(){} // RVA: 0x7A7E019D0
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7A7E01B10
        public void AddChunkToMediaBuffer(){} // RVA: 0x7A7E05960
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7A7E01900
        public void CloseMedia(){} // RVA: 0x7A7E18770
        public void SetLooping(){} // RVA: 0x7A7E18C30
        public void IsLooping(){} // RVA: 0x7A7E01900
        public void HasMetaData(){} // RVA: 0x7A7E01900
        public void CanPlay(){} // RVA: 0x7A7E01900
        public void IsPlaying(){} // RVA: 0x7A7E01900
        public void IsSeeking(){} // RVA: 0x7A7E01900
        public void IsPaused(){} // RVA: 0x7A7E01900
        public void IsFinished(){} // RVA: 0x7A7E01900
        public void IsBuffering(){} // RVA: 0x7A7E01900
        public void Play(){} // RVA: 0x7A7E18770
        public void Pause(){} // RVA: 0x7A7E18770
        public void Stop(){} // RVA: 0x7A7E18770
        public void Rewind(){} // RVA: 0x7A7E18770
        public void Seek(){} // RVA: 0x7A7E19E10
        public void SeekFast(){} // RVA: 0x7A7E19E10
        public void SeekWithTolerance(){} // RVA: 0x7A8051B10
        public void SeekToFrame(){} // RVA: 0x7A7E1C190
        public void SeekToFrameRelative(){} // RVA: 0x7A7E1C190
        public void GetCurrentTime(){} // RVA: 0x7A7E06760
        public void GetCurrentTimeFrames(){} // RVA: 0x7A7E0D3E0
        public void GetProgramDateTime(){} // RVA: 0x7A7E00680
        public void GetPlaybackRate(){} // RVA: 0x7A7E155B0
        public void SetPlaybackRate(){} // RVA: 0x7A7E262C0
        public void MuteAudio(){} // RVA: 0x7A7E18C30
        public void IsMuted(){} // RVA: 0x7A7E01900
        public void SetVolume(){} // RVA: 0x7A7E262C0
        public void SetBalance(){} // RVA: 0x7A7E262C0
        public void GetVolume(){} // RVA: 0x7A7E155B0
        public void GetBalance(){} // RVA: 0x7A7E155B0
        public void GetSeekableTimes(){} // RVA: 0x7A7E00680
        public void GetBufferedTimes(){} // RVA: 0x7A7E00680
        public void GetLastError(){} // RVA: 0x7A7E00710
        public void GetLastExtendedErrorCode(){} // RVA: 0x7A7E00680
        public void SetTextureProperties(){} // RVA: 0x7A7E1AD90
        public void GetTextureProperties(){} // RVA: 0x7A7E1DDC0
        public void GrabAudio(){} // RVA: 0x7A7E0A0A0
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7A7E00710
        public void GetAudioChannelCount(){} // RVA: 0x7A7E00710
        public void GetAudioChannelMask(){} // RVA: 0x7A7E00710
        public void AudioConfigurationChanged(){} // RVA: 0x7A7E18C30
        public void SetAudioChannelMode(){} // RVA: 0x7A7E189D0
        public void SetAudioHeadRotation(){} // RVA: 0x7A7E18800
        public void ResetAudioHeadRotation(){} // RVA: 0x7A7E18770
        public void SetAudioFocusEnabled(){} // RVA: 0x7A7E18C30
        public void SetAudioFocusProperties(){} // RVA: 0x7A7E26740
        public void SetAudioFocusRotation(){} // RVA: 0x7A7E18800
        public void ResetAudioFocus(){} // RVA: 0x7A7E18770
        public void WaitForNextFrame(){} // RVA: 0x7A7E039E0
        public void SetPlayWithoutBuffering(){} // RVA: 0x7A7E18C30
        public void SetKeyServerAuthToken(){} // RVA: 0x7A7E18800
        public void SetOverrideDecryptionKey(){} // RVA: 0x7A7E18800
        public void IsExternalPlaybackActive(){} // RVA: 0x7A7E01900
        public void SetAllowsExternalPlayback(){} // RVA: 0x7A7E18C30
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x7A7E189D0
    }

    public class IMediaInfo
    {
        // ── Methods ──
        public void GetDuration(){} // RVA: 0x7A7E06760
        public void GetDurationFrames(){} // RVA: 0x7A7E0D3E0
        public void GetMaxFrameNumber(){} // RVA: 0x7A7E0D3E0
        public void GetVideoWidth(){} // RVA: 0x7A7E00710
        public void GetVideoHeight(){} // RVA: 0x7A7E00710
        public void GetVideoFrameRate(){} // RVA: 0x7A7E155B0
        public void GetVideoDisplayRate(){} // RVA: 0x7A7E155B0
        public void HasVideo(){} // RVA: 0x7A7E01900
        public void HasAudio(){} // RVA: 0x7A7E01900
        public void GetPlayerDescription(){} // RVA: 0x7A7E00680
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7A7E01900
        public void IsPlaybackStalled(){} // RVA: 0x7A7E01900
        public void GetTextureTransform(){} // RVA: 0x7A7E00680
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x7A7E00680
        public void IsExternalPlaybackSupported(){} // RVA: 0x7A7E01900
        public void GetDecoderPerformance(){} // RVA: 0x7A7E01D90
        public void GetPlaybackQualityStats(){} // RVA: 0x7A7E00680
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7A7E18770
        public void Update(){} // RVA: 0x7A7E18770
        public void EndUpdate(){} // RVA: 0x7A7E18770
        public void BeginRender(){} // RVA: 0x7A7E18770
        public void Render(){} // RVA: 0x7A7E18770
        public void GetNativePlayerHandle(){} // RVA: 0x7A7E00680
    }

    public class IMediaSubtitles
    {
        // ── Methods ──
        public void LoadSubtitlesSRT(){} // RVA: 0x7A7E019D0
        public void GetSubtitleIndex(){} // RVA: 0x7A7E00710
        public void GetSubtitleText(){} // RVA: 0x7A7E00680
    }

    public class ITextTracks
    {
        // ── Methods ──
        public void GetTextTracks(){} // RVA: 0x7A7E00680
        public void GetActiveTextTrack(){} // RVA: 0x7A7E00680
        public void SetActiveTextTrack(){} // RVA: 0x7A7E18800
        public void GetCurrentTextCue(){} // RVA: 0x7A7E00680
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0x7A7E00710
        public void GetTexture(){} // RVA: 0x7A7E00740
        public void GetTextureFrameCount(){} // RVA: 0x7A7E00710
        public void SupportsTextureFrameCount(){} // RVA: 0x7A7E01900
        public void GetTextureTimeStamp(){} // RVA: 0x7A7E00680
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7A7E155B0
        public void RequiresVerticalFlip(){} // RVA: 0x7A7E01900
        public void GetTextureStereoPacking(){} // RVA: 0x7A7E00710
        public void GetTextureTransparency(){} // RVA: 0x7A7E00710
        public void GetTextureAlphaPacking(){} // RVA: 0x7A7E00710
        public void GetYpCbCrTransform(){} // RVA: 0x7A7E00490
    }

    public class IVideoTracks
    {
        // ── Methods ──
        public void GetVideoTracks(){} // RVA: 0x7A7E00680
        public void GetActiveVideoTrack(){} // RVA: 0x7A7E00680
        public void SetActiveVideoTrack(){} // RVA: 0x7A7E18800
    }

    public class KeyAuthData : Object
    {
        // ── Methods ──
        public void IsModified(){} // RVA: 0x7A9ABC600
        public void OnBeforeSerialize(){} // RVA: 0x7A9ABC630
        public void OnAfterDeserialize(){} // RVA: 0x7A9ABC6A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LazyShaderProperty : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7670310
        public void get_Name(){} // RVA: 0x7A765F710
        public void get_Id(){} // RVA: 0x7A7670320
    }

    public class MediaCachingOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MediaHints : ValueType
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x7A9AAA8A0
        public void .cctor(){} // RVA: 0x7A80D7310
    }

    public class MediaPath : Object
    {
        // ── Methods ──
        public void get_PathType(){} // RVA: 0x7A8124910
        public void set_PathType(){} // RVA: 0x7A80DA0C0
        public void get_Path(){} // RVA: 0x7A80DA7B0
        public void set_Path(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A9AAA4E0
        public void GetResolvedFullPath(){} // RVA: 0x7A9AAA5F0
        public void op_Equality(){} // RVA: 0x7A9AAA6C0
        public void op_Inequality(){} // RVA: 0x7A9AAA6E0
        public void Equals(){} // RVA: 0x7A9AAA720
        public void GetHashCode(){} // RVA: 0x7A9AAA860
    }

    public class MediaPlayer : MonoBehaviour
    {
        // ── Methods ──
        public void get_MediaSource(){} // RVA: 0x7A851DB90
        public void set_MediaSource(){} // RVA: 0x7A8738180
        public void get_MediaReference(){} // RVA: 0x7A8105330
        public void set_MediaReference(){} // RVA: 0x7A80D8E80
        public void get_MediaPath(){} // RVA: 0x7A83F69F0
        public void set_MediaPath(){} // RVA: 0x7A8105A90
        public void get_FallbackMediaHints(){} // RVA: 0x7A813E4E0
        public void set_FallbackMediaHints(){} // RVA: 0x7A813E500
        public void get_AutoOpen(){} // RVA: 0x7A98B2AB0
        public void set_AutoOpen(){} // RVA: 0x7A98B2AA0
        public void get_AutoStart(){} // RVA: 0x7A9A933F0
        public void set_AutoStart(){} // RVA: 0x7A9A93400
        public void get_Loop(){} // RVA: 0x7A9A93410
        public void set_Loop(){} // RVA: 0x7A9A93470
        public void get_AudioVolume(){} // RVA: 0x7A9A934E0
        public void set_AudioVolume(){} // RVA: 0x7A9A93540
        public void get_AudioBalance(){} // RVA: 0x7A9A935D0
        public void set_AudioBalance(){} // RVA: 0x7A9A93630
        public void get_AudioMuted(){} // RVA: 0x7A9A936C0
        public void set_AudioMuted(){} // RVA: 0x7A9A93720
        public void get_AudioSource(){} // RVA: 0x7A81A0050
        public void set_AudioSource(){} // RVA: 0x7A81A0060
        public void get_PlaybackRate(){} // RVA: 0x7A9A93790
        public void set_PlaybackRate(){} // RVA: 0x7A9A937F0
        public void get_UseResampler(){} // RVA: 0x7A9250CD0
        public void set_UseResampler(){} // RVA: 0x7A9A93860
        public void get_ResampleMode(){} // RVA: 0x7A9A93870
        public void set_ResampleMode(){} // RVA: 0x7A9A93880
        public void get_ResampleBufferSize(){} // RVA: 0x7A9A93890
        public void set_ResampleBufferSize(){} // RVA: 0x7A9A938A0
        public void get_FrameResampler(){} // RVA: 0x7A81A00E0
        public void get_VideoLayoutMapping(){} // RVA: 0x7A989D5C0
        public void set_VideoLayoutMapping(){} // RVA: 0x7A98A0B60
        public void get_TextureFilterMode(){} // RVA: 0x7A9A938B0
        public void set_TextureFilterMode(){} // RVA: 0x7A9A939B0
        public void get_TextureWrapMode(){} // RVA: 0x7A9A93A30
        public void set_TextureWrapMode(){} // RVA: 0x7A9A93B30
        public void get_TextureAnisoLevel(){} // RVA: 0x7A9A93BB0
        public void set_TextureAnisoLevel(){} // RVA: 0x7A9A93CB0
        public void get_SideloadSubtitles(){} // RVA: 0x7A90FA160
        public void set_SideloadSubtitles(){} // RVA: 0x7A90F9520
        public void get_SubtitlePath(){} // RVA: 0x7A8555100
        public void set_SubtitlePath(){} // RVA: 0x7A8919DE0
        public void set_AudioHeadTransform(){} // RVA: 0x7A8744720
        public void get_AudioHeadTransform(){} // RVA: 0x7A87D9C10
        public void get_AudioFocusEnabled(){} // RVA: 0x7A9905F60
        public void set_AudioFocusEnabled(){} // RVA: 0x7A8935600
        public void get_AudioFocusTransform(){} // RVA: 0x7A87D9480
        public void set_AudioFocusTransform(){} // RVA: 0x7A8881790
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x7A914A1E0
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x7A9A93D30
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x7A9A93D40
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x7A9A93D50
        public void get_HttpHeaders(){} // RVA: 0x7A8142680
        public void set_HttpHeaders(){} // RVA: 0x7A8142690
        public void get_KeyAuth(){} // RVA: 0x7A81426F0
        public void set_KeyAuth(){} // RVA: 0x7A8142700
        public void get_Events(){} // RVA: 0x7A9A93D60
        public void get_EventMask(){} // RVA: 0x7A880E690
        public void set_EventMask(){} // RVA: 0x7A98A1E20
        public void get_PauseMediaOnAppPause(){} // RVA: 0x7A9A93FF0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x7A9A94000
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0x7A9A94010
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x7A9A94020
        public void get_Persistent(){} // RVA: 0x7A9A94030
        public void set_Persistent(){} // RVA: 0x7A9A94040
        public void get_ForceFileFormat(){} // RVA: 0x7A9A94050
        public void set_ForceFileFormat(){} // RVA: 0x7A9A94060
        public void get_Info(){} // RVA: 0x7A8592710
        public void get_Control(){} // RVA: 0x7A8158FC0
        public void get_Player(){} // RVA: 0x7A8852A30
        public void get_TextureProducer(){} // RVA: 0x7A8142870
        public void get_Subtitles(){} // RVA: 0x7A884DED0
        public void get_VideoTracks(){} // RVA: 0x7A8357A90
        public void get_AudioTracks(){} // RVA: 0x7A884CA70
        public void get_TextTracks(){} // RVA: 0x7A884C460
        public void get_Cache(){} // RVA: 0x7A884F050
        public void get_BufferedDisplay(){} // RVA: 0x7A864CFF0
        public void get_MediaOpened(){} // RVA: 0x7A9A94070
        public void Awake(){} // RVA: 0x7A9A94080
        public void Initialise(){} // RVA: 0x7A9A94120
        public void Start(){} // RVA: 0x7A9A94B20
        public void OpenMedia(){} // RVA: 0x7A9A94DE0
        public void InternalOpenMedia(){} // RVA: 0x7A9A94E10
        public void SetLoadOptions(){} // RVA: 0x7A9A95600
        public void SetPlaybackOptions(){} // RVA: 0x7A9A956D0
        public void CloseMedia(){} // RVA: 0x7A9A95800
        public void RewindPrerollPause(){} // RVA: 0x7A9A959A0
        public void Play(){} // RVA: 0x7A9A95A90
        public void Pause(){} // RVA: 0x7A9A95B30
        public void Stop(){} // RVA: 0x7A9A95BB0
        public void Rewind(){} // RVA: 0x7A9A95C10
        public void SeekToLiveTime(){} // RVA: 0x7A9A95CA0
        public void Update(){} // RVA: 0x7A9A95D40
        public void LateUpdate(){} // RVA: 0x7A9A95F70
        public void UpdateResampler(){} // RVA: 0x7A9A96150
        public void OnEnable(){} // RVA: 0x7A9A962E0
        public void OnDisable(){} // RVA: 0x7A9A96360
        public void OnDestroy(){} // RVA: 0x7A9A96400
        public void ForceDispose(){} // RVA: 0x7A9A96A60
        public void AllPlayersDispose(){} // RVA: 0x7A9A96B10
        public void HandleApplicationQuit(){} // RVA: 0x7A9A96C60
        public void StartRenderCoroutine(){} // RVA: 0x7A9A96F80
        public void StopRenderCoroutine(){} // RVA: 0x7A9A970A0
        public void FinalRenderCapture(){} // RVA: 0x7A9A97120
        public void GetPlatform(){} // RVA: 0x7A82D1450
        public void GetCurrentPlatformOptions(){} // RVA: 0x7A85EBF70
        public void GetPlatformVideoApiString(){} // RVA: 0x7A9A971C0
        public void GetPlatformFileOffset(){} // RVA: 0x7A82D1450
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x7A9A97240
        public void GetResolvedFilePath(){} // RVA: 0x7A9A972F0
        public void CreateMediaPlayer(){} // RVA: 0x7A9A97610
        public void CreateMediaPlayerNull(){} // RVA: 0x7A9A975A0
        public void UpdateAudioFocus(){} // RVA: 0x7A9A979C0
        public void UpdateAudioHeadTransform(){} // RVA: 0x7A9A97C40
        public void UpdateErrors(){} // RVA: 0x7A9A97E60
        public void IsUsingAndroidOESPath(){} // RVA: 0x7A9A98110
        public void OnApplicationFocus(){} // RVA: 0x7A80D7310
        public void OnApplicationPause(){} // RVA: 0x7A80D7310
        public void ResetEvents(){} // RVA: 0x7A9A98160
        public void UpdateEvents(){} // RVA: 0x7A9A98190
        public void IsHandleEvent(){} // RVA: 0x7A9A98670
        public void FireEventIfPossible(){} // RVA: 0x7A9A986A0
        public void CanFireEvent(){} // RVA: 0x7A9A98730
        public void ForceWaitForNewFrame(){} // RVA: 0x7A9A98BD0
        public void GetDummyCamera(){} // RVA: 0x7A9A98E00
        public void ExtractFrameCoroutine(){} // RVA: 0x7A9A99270
        public void ExtractFrameAsync(){} // RVA: 0x7A9A993F0
        public void ExtractFrame(){} // RVA: 0x7A9A99780
        public void OpenMediaFromBuffer(){} // RVA: 0x7A9A99A20
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x7A9A99B20
        public void AddChunkToVideoBuffer(){} // RVA: 0x7A9A99C20
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x7A9A99D40
        public void OpenMediaFromBufferInternal(){} // RVA: 0x7A9A99DD0
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x7A9A9A030
        public void AddChunkToBufferInternal(){} // RVA: 0x7A9A99C20
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x7A9A99D40
        public void get_PlatformOptionsWindows(){} // RVA: 0x7A85EBF70
        public void get_PlatformOptionsMacOSX(){} // RVA: 0x7A8B6A790
        public void get_PlatformOptionsIOS(){} // RVA: 0x7A8B46B20
        public void get_PlatformOptionsTVOS(){} // RVA: 0x7A884DD70
        public void get_PlatformOptionsAndroid(){} // RVA: 0x7A8855020
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x7A8B76160
        public void get_PlatformOptionsWebGL(){} // RVA: 0x7A8852B30
        public void EnableSubtitles(){} // RVA: 0x7A9A9A210
        public void LoadSubtitlesCoroutine(){} // RVA: 0x7A9A9A680
        public void DisableSubtitles(){} // RVA: 0x7A9A9A7E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7A9A9A950
        public void .ctor(){} // RVA: 0x7A9A9AAD0
    }

    public class MediaPlayerEvent : UnityEvent`3
    {
        // ── Methods ──
        public void HasListeners(){} // RVA: 0x7A9AA7010
        public void AddListener(){} // RVA: 0x7A9AA70A0
        public void RemoveListener(){} // RVA: 0x7A9AA7220
        public void RemoveAllListeners(){} // RVA: 0x7A9AA7320
        public void .ctor(){} // RVA: 0x7A9AA7390
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AA6FD0
    }

    public class MediaPlaylist : Object
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A80F2570
        public void HasItemAt(){} // RVA: 0x7A9A9CAA0
        public void .ctor(){} // RVA: 0x7A9A9CB10
    }

    public class MediaReference : ScriptableObject
    {
        // ── Methods ──
        public void get_Alias(){} // RVA: 0x7A80DA7B0
        public void set_Alias(){} // RVA: 0x7A813E420
        public void get_MediaPath(){} // RVA: 0x7A81052C0
        public void set_MediaPath(){} // RVA: 0x7A81052D0
        public void get_Hints(){} // RVA: 0x7A8152D50
        public void set_Hints(){} // RVA: 0x7A8152D70
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x7A9A8D560
        public void GetPlatformMediaReference(){} // RVA: 0x7A9A8D630
        public void .ctor(){} // RVA: 0x7A9A8D6B0
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x7A9AABD20
        public void GetExpectedVersion(){} // RVA: 0x7A9AABD60
        public void OpenMedia(){} // RVA: 0x7A9AABD80
        public void CloseMedia(){} // RVA: 0x7A9AAC0C0
        public void SetLooping(){} // RVA: 0x7A80F86E0
        public void IsLooping(){} // RVA: 0x7A80F86D0
        public void HasMetaData(){} // RVA: 0x7A81BD750
        public void CanPlay(){} // RVA: 0x7A81BD750
        public void HasAudio(){} // RVA: 0x7A80D7320
        public void HasVideo(){} // RVA: 0x7A80D7320
        public void Play(){} // RVA: 0x7A9AAC100
        public void Pause(){} // RVA: 0x7A9AAC120
        public void Stop(){} // RVA: 0x7A9AAC130
        public void IsSeeking(){} // RVA: 0x7A80D7320
        public void IsPlaying(){} // RVA: 0x7A835F4E0
        public void IsPaused(){} // RVA: 0x7A9AAC140
        public void IsFinished(){} // RVA: 0x7A9AAC150
        public void IsBuffering(){} // RVA: 0x7A80D7320
        public void GetDuration(){} // RVA: 0x7A9AAC1A0
        public void GetVideoWidth(){} // RVA: 0x7A9AAC1B0
        public void GetVideoHeight(){} // RVA: 0x7A87BD4F0
        public void GetVideoDisplayRate(){} // RVA: 0x7A889C770
        public void GetTexture(){} // RVA: 0x7A81F50F0
        public void GetTextureFrameCount(){} // RVA: 0x7A9AAC1C0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7A836B0A0
        public void RequiresVerticalFlip(){} // RVA: 0x7A80D7320
        public void Seek(){} // RVA: 0x7A9AAC1D0
        public void SeekFast(){} // RVA: 0x7A9AAC1D0
        public void GetCurrentTime(){} // RVA: 0x7A9AAC1E0
        public void SetPlaybackRate(){} // RVA: 0x7A9AAC1F0
        public void GetPlaybackRate(){} // RVA: 0x7A9AAC200
        public void MuteAudio(){} // RVA: 0x7A80D7310
        public void IsMuted(){} // RVA: 0x7A81BD750
        public void SetVolume(){} // RVA: 0x7A9AAC210
        public void GetVolume(){} // RVA: 0x7A9AAC220
        public void GetVideoFrameRate(){} // RVA: 0x7A889BC60
        public void Update(){} // RVA: 0x7A9AAC230
        public void Render(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
        public void InternalSetActiveTrack(){} // RVA: 0x7A80D7320
        public void InternalIsChangedTracks(){} // RVA: 0x7A80D7320
        public void InternalGetTrackCount(){} // RVA: 0x7A82D1450
        public void InternalGetTrackInfo(){} // RVA: 0x7A82D1450
        public void InternalIsChangedTextCue(){} // RVA: 0x7A80D7320
        public void InternalGetCurrentTextCue(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7A9AAC520
    }

    public class OptionsAppleExtensions : Object
    {
        // ── Methods ──
        public void GenerateMipmaps(){} // RVA: 0x7A9A9C9B0
        public void SetGenerateMipMaps(){} // RVA: 0x7A9A9C9C0
        public void AllowExternalPlayback(){} // RVA: 0x7A9A9C9E0
        public void SetAllowExternalPlayback(){} // RVA: 0x7A9A9C9F0
        public void PlayWithoutBuffering(){} // RVA: 0x7A9A9CA10
        public void SetPlayWithoutBuffering(){} // RVA: 0x7A9A9CA20
        public void UseSinglePlayerItem(){} // RVA: 0x7A9A9CA40
        public void SetUseSinglePlayerItem(){} // RVA: 0x7A9A9CA50
        public void ResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7A9A9CA70
        public void SetResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x7A9A9CA80
    }

    public class PlaybackQualityStats : Object
    {
        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0x7A8124910
        public void set_SkippedFrames(){} // RVA: 0x7A80DA0C0
        public void get_DuplicateFrames(){} // RVA: 0x7A8668BC0
        public void set_DuplicateFrames(){} // RVA: 0x7A8669360
        public void get_UnityDroppedFrames(){} // RVA: 0x7A83782A0
        public void set_UnityDroppedFrames(){} // RVA: 0x7A84385B0
        public void get_PerfectFramesT(){} // RVA: 0x7A81A5180
        public void set_PerfectFramesT(){} // RVA: 0x7A81A5190
        public void get_VSyncStatus(){} // RVA: 0x7A81052C0
        public void set_VSyncStatus(){} // RVA: 0x7A81052D0
        public void get_PerfectFrames(){} // RVA: 0x7A854FDE0
        public void set_PerfectFrames(){} // RVA: 0x7A8810F60
        public void get_TotalFrames(){} // RVA: 0x7A8F9ACE0
        public void set_TotalFrames(){} // RVA: 0x7A98B6D80
        public void get_LogIssues(){} // RVA: 0x7A80FD690
        public void set_LogIssues(){} // RVA: 0x7A80FD6A0
        public void Reset(){} // RVA: 0x7A9AAB030
        public void Start(){} // RVA: 0x7A9AAB080
        public void Update(){} // RVA: 0x7A9AAB680
        public void IsGameViewVSyncEnabled(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
        public void <SkippedFrames>k__BackingField(){} // RVA: 0x7B3FAD508
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x7A9A9CD90
        public void get_NextPlayer(){} // RVA: 0x7A8B62DA0
        public void get_Playlist(){} // RVA: 0x7A8688280
        public void get_PlaylistIndex(){} // RVA: 0x7A9A9CEE0
        public void get_PlaylistItem(){} // RVA: 0x7A9A9CEF0
        public void get_DefaultTransition(){} // RVA: 0x7A9A9CFE0
        public void set_DefaultTransition(){} // RVA: 0x7A9A9CFF0
        public void get_DefaultTransitionDuration(){} // RVA: 0x7A9A9D000
        public void set_DefaultTransitionDuration(){} // RVA: 0x7A9A9D010
        public void get_DefaultTransitionEasing(){} // RVA: 0x7A9A9D020
        public void set_DefaultTransitionEasing(){} // RVA: 0x7A9A9D030
        public void get_AutoCloseVideo(){} // RVA: 0x7A9A9D040
        public void set_AutoCloseVideo(){} // RVA: 0x7A9A9D050
        public void get_LoopMode(){} // RVA: 0x7A9A9D060
        public void set_LoopMode(){} // RVA: 0x7A9A9D070
        public void get_AutoProgress(){} // RVA: 0x7A9A9D080
        public void set_AutoProgress(){} // RVA: 0x7A9A9D090
        public void get_Info(){} // RVA: 0x7A9A9D0A0
        public void get_Control(){} // RVA: 0x7A9A9D1B0
        public void get_TextureProducer(){} // RVA: 0x7A9A9D2C0
        public void get_AudioVolume(){} // RVA: 0x7A9A9D3F0
        public void set_AudioVolume(){} // RVA: 0x7A9A9D400
        public void get_AudioMuted(){} // RVA: 0x7A9A9D550
        public void set_AudioMuted(){} // RVA: 0x7A9A9D560
        public void Play(){} // RVA: 0x7A9A9D690
        public void Pause(){} // RVA: 0x7A9A9D7A0
        public void IsPaused(){} // RVA: 0x7A9A9D8A0
        public void SwapPlayers(){} // RVA: 0x7A9A9D8B0
        public void GetCurrentTexture(){} // RVA: 0x7A9A9E2A0
        public void GetNextTexture(){} // RVA: 0x7A9A9E400
        public void Awake(){} // RVA: 0x7A9A9E550
        public void OnDestroy(){} // RVA: 0x7A9A9E8F0
        public void Start(){} // RVA: 0x7A9A9EC30
        public void OnVideoEvent(){} // RVA: 0x7A9A9EE90
        public void PrevItem(){} // RVA: 0x7A9A9F250
        public void NextItem(){} // RVA: 0x7A9A9F260
        public void CanJumpToItem(){} // RVA: 0x7A9A9F2E0
        public void JumpToItem(){} // RVA: 0x7A9A9F3C0
        public void OpenVideoFile(){} // RVA: 0x7A9A9F590
        public void IsTransitioning(){} // RVA: 0x7A9A9F940
        public void SetTransition(){} // RVA: 0x7A9A9FA40
        public void Update(){} // RVA: 0x7A9A9FC10
        public void GetTexture(){} // RVA: 0x7A8B54430
        public void GetTextureCount(){} // RVA: 0x7A9AA02B0
        public void GetTextureFrameCount(){} // RVA: 0x7A9AA0330
        public void SupportsTextureFrameCount(){} // RVA: 0x7A9AA03B0
        public void GetTextureTimeStamp(){} // RVA: 0x7A9AA0430
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7A9AA04B0
        public void RequiresVerticalFlip(){} // RVA: 0x7A9AA0530
        public void GetYpCbCrTransform(){} // RVA: 0x7A9AA05B0
        public void GetTextureStereoPacking(){} // RVA: 0x7A9AA0660
        public void GetTextureTransparency(){} // RVA: 0x7A9AA06E0
        public void GetTextureAlphaPacking(){} // RVA: 0x7A9AA0760
        public void GetTransitionName(){} // RVA: 0x7A9AA07E0
        public void .ctor(){} // RVA: 0x7A9AA0B10
        public void .cctor(){} // RVA: 0x7A9AA0DB0
    }

    public class Resampler : Object
    {
        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x7A9A93870
        public void get_FrameDisplayedTimer(){} // RVA: 0x7A989D5C0
        public void get_BaseTimestamp(){} // RVA: 0x7A8292C30
        public void set_BaseTimestamp(){} // RVA: 0x7A82C26E0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0x7A85D5650
        public void set_ElapsedTimeSinceBase(){} // RVA: 0x7A85D4FE0
        public void get_LastT(){} // RVA: 0x7A869BBB0
        public void set_LastT(){} // RVA: 0x7A8699E60
        public void get_TextureTimeStamp(){} // RVA: 0x7A8555100
        public void set_TextureTimeStamp(){} // RVA: 0x7A9ABC8A0
        public void OnVideoEvent(){} // RVA: 0x7A9ABC8B0
        public void .ctor(){} // RVA: 0x7A9ABC990
        public void get_OutputTexture(){} // RVA: 0x7A81052C0
        public void Reset(){} // RVA: 0x7A9ABCED0
        public void Release(){} // RVA: 0x7A9ABCEF0
        public void ReleaseRenderTextures(){} // RVA: 0x7A9ABD080
        public void ConstructRenderTextures(){} // RVA: 0x7A9ABD3F0
        public void CheckRenderTexturesValid(){} // RVA: 0x7A9ABD9F0
        public void FindBeforeFrameIndex(){} // RVA: 0x7A9ABDE70
        public void FindClosestFrame(){} // RVA: 0x7A9ABE0D0
        public void PointUpdate(){} // RVA: 0x7A9ABE2D0
        public void SampleFrame(){} // RVA: 0x7A9ABE490
        public void SampleFrames(){} // RVA: 0x7A9ABE660
        public void LinearUpdate(){} // RVA: 0x7A9ABEA30
        public void InvalidateBuffer(){} // RVA: 0x7A9ABEC50
        public void GuessFrameRate(){} // RVA: 0x7A9ABED60
        public void Update(){} // RVA: 0x7A9ABF030
        public void UpdateTimestamp(){} // RVA: 0x7A9ABFD60
        public void _buffer(){} // RVA: 0x7B3FB4328
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0x7A81052C0
        public void set_MediaPlayer(){} // RVA: 0x7A9AA1830
        public void get_VideoResolveOptions(){} // RVA: 0x7A9AA19D0
        public void set_VideoResolveOptions(){} // RVA: 0x7A9AA19F0
        public void get_ExternalTexture(){} // RVA: 0x7A8175DF0
        public void set_ExternalTexture(){} // RVA: 0x7A8175E00
        public void get_TargetTexture(){} // RVA: 0x7A9AA1A10
        public void SetMaterialDirty(){} // RVA: 0x7A8289410
        public void ChangeMediaPlayer(){} // RVA: 0x7A9AA1830
        public void Start(){} // RVA: 0x7A9AA1AF0
        public void LateUpdate(){} // RVA: 0x7A9AA1DE0
        public void Resolve(){} // RVA: 0x7A9AA1DF0
        public void OnDisable(){} // RVA: 0x7A9AA25D0
        public void OnDestroy(){} // RVA: 0x7A9AA2740
        public void .ctor(){} // RVA: 0x7A9AA2880
    }

    public class Subtitle : Object
    {
        // ── Methods ──
        public void IsBefore(){} // RVA: 0x7A9ABFD80
        public void IsTime(){} // RVA: 0x7A9ABFDA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubtitlePlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubtitleUtils : Object
    {
        // ── Methods ──
        public void ParseTimeToSeconds(){} // RVA: 0x7A9ABFDC0
        public void ParseSubtitlesSRT(){} // RVA: 0x7A9ABFF70
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Subtitle[] : Array
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

    public class SubtitlesUGUI : MonoBehaviour
    {
        // ── Methods ──
        public void set_Player(){} // RVA: 0x7A9A8C840
        public void get_Player(){} // RVA: 0x7A81052C0
        public void set_Text(){} // RVA: 0x7A80D8E80
        public void get_Text(){} // RVA: 0x7A8105330
        public void Start(){} // RVA: 0x7A9A8C850
        public void OnDestroy(){} // RVA: 0x7A9A8C860
        public void Update(){} // RVA: 0x7A9A8C870
        public void ChangeMediaPlayer(){} // RVA: 0x7A9A8C880
        public void SetText(){} // RVA: 0x7A9A8CBD0
        public void PrepareText(){} // RVA: 0x7A9A8CC10
        public void UpdateBackgroundRect(){} // RVA: 0x7A9A8CD80
        public void OnMediaPlayerEvent(){} // RVA: 0x7A9A8D030
        public void .ctor(){} // RVA: 0x7A9A8D280
    }

    public class TextCue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Text(){} // RVA: 0x7A80F2570
        public void set_Text(){} // RVA: 0x7A80D8E20
        public void <Text>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class TextTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9ABBD10
    }

    public class TextTrack[] : Array
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

    public class TextTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7A81DDCC0
        public void .ctor(){} // RVA: 0x7A9ABBC60
    }

    public class TimeRange : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A766FF40
        public void get_StartTime(){} // RVA: 0x7A766FF50
        public void get_EndTime(){} // RVA: 0x7A766FF60
        public void get_Duration(){} // RVA: 0x7A766FF70
    }

    public class TimeRange[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA298380
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TimeRanges : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AAADB0
        public void GetEnumerator(){} // RVA: 0x7A9AAAAE0
        public void get_Item(){} // RVA: 0x7A9AAAB00
        public void ToString(){} // RVA: 0x7A9AAAB40
        public void CalculateRange(){} // RVA: 0x7A9AAAEB0
        public void get_Count(){} // RVA: 0x7A8D0A110
        public void get_MinTime(){} // RVA: 0x7A9727910
        public void get_MaxTime(){} // RVA: 0x7A97EDE10
        public void get_Duration(){} // RVA: 0x7A9AAB020
    }

    public class TrackBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9ABB800
        public void get_Uid(){} // RVA: 0x7A8124910
        public void set_Uid(){} // RVA: 0x7A80DA0C0
        public void get_TrackType(){} // RVA: 0x7A8668BC0
        public void set_TrackType(){} // RVA: 0x7A8669360
        public void get_DisplayName(){} // RVA: 0x7A80DA7B0
        public void set_DisplayName(){} // RVA: 0x7A813E420
        public void get_Name(){} // RVA: 0x7A81052C0
        public void set_Name(){} // RVA: 0x7A81052D0
        public void get_Language(){} // RVA: 0x7A8105330
        public void set_Language(){} // RVA: 0x7A80D8E80
        public void get_IsDefault(){} // RVA: 0x7A80FD690
        public void set_IsDefault(){} // RVA: 0x7A80FD6A0
        public void CreateDisplayName(){} // RVA: 0x7A9ABBA80
    }

    public class TrackCollection : Object
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7A8124910
        public void set_TrackType(){} // RVA: 0x7A80DA0C0
        public void get_Count(){} // RVA: 0x7A7E00710
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void Clear(){} // RVA: 0x7A7E18770
        public void Add(){} // RVA: 0x7A7E18800
        public void HasActiveTrack(){} // RVA: 0x7A7E01900
        public void IsActiveTrack(){} // RVA: 0x7A7E019D0
        public void SetActiveTrack(){} // RVA: 0x7A7E18800
        public void SetFirstTrackActive(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TrackCollection[] : Array
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

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_Item(){} // RVA: 0x7A8051B10
        public void get_ActiveTrack(){} // RVA: 0x7A8051B10
        public void set_ActiveTrack(){} // RVA: 0x7A8051B10
        public void HasActiveTrack(){} // RVA: 0x7A7E01900
        public void IsActiveTrack(){} // RVA: 0x7A7E019D0
        public void Clear(){} // RVA: 0x7A7E18770
        public void Add(){} // RVA: 0x7A7E18800
        public void SetActiveTrack(){} // RVA: 0x7A7E18800
        public void SetFirstTrackActive(){} // RVA: 0x7A7E18770
        public void get_Count(){} // RVA: 0x7A7E00710
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC20C920
        public void GetEnumerator(){} // RVA: 0x7AC20CA60
        public void get_Item(){} // RVA: 0x7AC20CB30
        public void get_ActiveTrack(){} // RVA: 0x7A80DA7B0
        public void set_ActiveTrack(){} // RVA: 0x7A813E420
        public void HasActiveTrack(){} // RVA: 0x7A9B3D890
        public void IsActiveTrack(){} // RVA: 0x7AC20CB80
        public void Clear(){} // RVA: 0x7AC20CB90
        public void Add(){} // RVA: 0x7AC20CC20
        public void SetActiveTrack(){} // RVA: 0x7AC20CD30
        public void SetFirstTrackActive(){} // RVA: 0x7AC20CE30
        public void get_Count(){} // RVA: 0x7AC20CEC0
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC20C920
        public void GetEnumerator(){} // RVA: 0x7AC20CA60
        public void get_Item(){} // RVA: 0x7AC20CB30
        public void get_ActiveTrack(){} // RVA: 0x7A80DA7B0
        public void set_ActiveTrack(){} // RVA: 0x7A813E420
        public void HasActiveTrack(){} // RVA: 0x7A9B3D890
        public void IsActiveTrack(){} // RVA: 0x7AC20CB80
        public void Clear(){} // RVA: 0x7AC20CB90
        public void Add(){} // RVA: 0x7AC20CC20
        public void SetActiveTrack(){} // RVA: 0x7AC20CD30
        public void SetFirstTrackActive(){} // RVA: 0x7AC20CE30
        public void get_Count(){} // RVA: 0x7AC20CEC0
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC20C920
        public void GetEnumerator(){} // RVA: 0x7AC20CA60
        public void get_Item(){} // RVA: 0x7AC20CB30
        public void get_ActiveTrack(){} // RVA: 0x7A80DA7B0
        public void set_ActiveTrack(){} // RVA: 0x7A813E420
        public void HasActiveTrack(){} // RVA: 0x7A9B3D890
        public void IsActiveTrack(){} // RVA: 0x7AC20CB80
        public void Clear(){} // RVA: 0x7AC20CB90
        public void Add(){} // RVA: 0x7AC20CC20
        public void SetActiveTrack(){} // RVA: 0x7AC20CD30
        public void SetFirstTrackActive(){} // RVA: 0x7AC20CE30
        public void get_Count(){} // RVA: 0x7AC20CEC0
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        // ── Methods ──
        public void get_Camera(){} // RVA: 0x7A81052C0
        public void set_Camera(){} // RVA: 0x7A81052D0
        public void Awake(){} // RVA: 0x7A9AA2950
        public void Start(){} // RVA: 0x7A9AA2A60
        public void LogXRDeviceDetails(){} // RVA: 0x7A9AA2A70
        public void IsMultiPassVrEnabled(){} // RVA: 0x7A9AA3020
        public void LateUpdate(){} // RVA: 0x7A9AA30C0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void .cctor(){} // RVA: 0x7A9AA39F0
    }

    public class VideoRender : Object
    {
        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x7A9AC0560
        public void CreateIMGUIMaterial(){} // RVA: 0x7A9AC0600
        public void SetupLayoutMaterial(){} // RVA: 0x7A9AC0680
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x7A9AC0800
        public void SetupStereoMaterial(){} // RVA: 0x7A9AC0950
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x7A9AC0C10
        public void SetupAlphaPackedMaterial(){} // RVA: 0x7A9AC0CE0
        public void SetupGammaMaterial(){} // RVA: 0x7A9AC0E30
        public void SetupTextureMatrix(){} // RVA: 0x7A80D7310
        public void SetupVerticalFlipMaterial(){} // RVA: 0x7A9AC0F30
        public void GetTexture(){} // RVA: 0x7A9AC1070
        public void SetupMaterialForMedia(){} // RVA: 0x7A9AC1220
        public void SetupMaterial(){} // RVA: 0x7A9AC1870
        public void SetupResolveMaterial(){} // RVA: 0x7A9AC2080
        public void ResolveVideoToRenderTexture(){} // RVA: 0x7A9AC2510
        public void GetResolveTextureSize(){} // RVA: 0x7A9AC2E40
        public void RequiresResolve(){} // RVA: 0x7A9AC2EF0
        public void DrawTexture(){} // RVA: 0x7A9AC2FA0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9AC3770
        public void Shader_IMGUI(){} // RVA: 0x7B3FAD6B8
    }

    public class VideoResolveOptions : ValueType
    {
        // ── Methods ──
        public void IsColourAdjust(){} // RVA: 0x7A766FEB0
        public void ResetColourAdjust(){} // RVA: 0x7A766FF10
        public void Create(){} // RVA: 0x7A9AAA9A0
    }

    public class VideoTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9ABBCA0
        public void get_Bitrate(){} // RVA: 0x7A8D863F0
        public void set_Bitrate(){} // RVA: 0x7A8D870E0
    }

    public class VideoTrack[] : Array
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

    public class VideoTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7A9ABBBE0
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x7A9AAC550
        public void DeinitPlatform(){} // RVA: 0x7A9AACA20
        public void GetAudioChannelCount(){} // RVA: 0x7A9AACAD0
        public void GetAudioChannelMask(){} // RVA: 0x7A9AACB50
        public void .ctor(){} // RVA: 0x7A9AACE40
        public void SetOptions(){} // RVA: 0x7A9AAD0A0
        public void GetVersion(){} // RVA: 0x7A9AAD3F0
        public void GetExpectedVersion(){} // RVA: 0x7A9AAD450
        public void UseNativeMips(){} // RVA: 0x7A9AAD490
        public void OpenMedia(){} // RVA: 0x7A9AAD4A0
        public void OpenMediaFromBuffer(){} // RVA: 0x7A9AADC80
        public void StartOpenMediaFromBuffer(){} // RVA: 0x7A9AAE150
        public void AddChunkToMediaBuffer(){} // RVA: 0x7A9AAE220
        public void EndOpenMediaFromBuffer(){} // RVA: 0x7A9AAE2E0
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x7A9AAE740
        public void CloseMedia(){} // RVA: 0x7A9AAE910
        public void SetLooping(){} // RVA: 0x7A9AAEAB0
        public void IsLooping(){} // RVA: 0x7A8203E30
        public void HasMetaData(){} // RVA: 0x7A9AAEB40
        public void HasAudio(){} // RVA: 0x7A8159120
        public void HasVideo(){} // RVA: 0x7A9665860
        public void CanPlay(){} // RVA: 0x7A9AAEB50
        public void Play(){} // RVA: 0x7A9AAEB60
        public void Pause(){} // RVA: 0x7A9AAEBF0
        public void Stop(){} // RVA: 0x7A9AAEBF0
        public void IsSeeking(){} // RVA: 0x7A9AAEC10
        public void IsPlaying(){} // RVA: 0x7A9AAECA0
        public void IsPaused(){} // RVA: 0x7A9AAED20
        public void IsFinished(){} // RVA: 0x7A9AAED60
        public void IsBuffering(){} // RVA: 0x7A9AAEE50
        public void GetDuration(){} // RVA: 0x7A9AAEEE0
        public void GetVideoWidth(){} // RVA: 0x7A9AAEF60
        public void GetVideoHeight(){} // RVA: 0x7A9AAEF70
        public void GetVideoFrameRate(){} // RVA: 0x7A9AAEF80
        public void GetTexture(){} // RVA: 0x7A9AAEF90
        public void GetTextureFrameCount(){} // RVA: 0x7A9AAF0A0
        public void GetTextureTimeStamp(){} // RVA: 0x7A9AAF0B0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x7A9AAF130
        public void RequiresVerticalFlip(){} // RVA: 0x7A9AAF1E0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7A9AAF1F0
        public void Seek(){} // RVA: 0x7A9AAF270
        public void SeekFast(){} // RVA: 0x7A9AAF330
        public void GetCurrentTime(){} // RVA: 0x7A9AAF3F0
        public void SetPlaybackRate(){} // RVA: 0x7A9AAF470
        public void GetPlaybackRate(){} // RVA: 0x7A9AAF500
        public void MuteAudio(){} // RVA: 0x7A9AAF580
        public void IsMuted(){} // RVA: 0x7A9A94030
        public void SetVolume(){} // RVA: 0x7A9AAF610
        public void GetVolume(){} // RVA: 0x7A9AAF6B0
        public void SetBalance(){} // RVA: 0x7A9AAF6C0
        public void GetBalance(){} // RVA: 0x7A86650C0
        public void IsPlaybackStalled(){} // RVA: 0x7A9AAF760
        public void WaitForNextFrame(){} // RVA: 0x7A9AAF810
        public void SetAudioChannelMode(){} // RVA: 0x7A9AAFA20
        public void SetAudioHeadRotation(){} // RVA: 0x7A9AAFAB0
        public void ResetAudioHeadRotation(){} // RVA: 0x7A9AAFAF0
        public void SetAudioFocusEnabled(){} // RVA: 0x7A9AAFC10
        public void SetAudioFocusProperties(){} // RVA: 0x7A9AAFC20
        public void SetAudioFocusRotation(){} // RVA: 0x7A9AAFC30
        public void ResetAudioFocus(){} // RVA: 0x7A9AAFC70
        public void Update(){} // RVA: 0x7A9AAFCE0
        public void ReleaseTexture(){} // RVA: 0x7A9AB0520
        public void UpdateTexture(){} // RVA: 0x7A9AB07C0
        public void EndUpdate(){} // RVA: 0x7A9AB0F60
        public void GetLastExtendedErrorCode(){} // RVA: 0x7A9AB0FE0
        public void OnTextureSizeChanged(){} // RVA: 0x7A80D7310
        public void BeginRender(){} // RVA: 0x7A9AB1060
        public void Render(){} // RVA: 0x7A9AB10B0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void GrabAudio(){} // RVA: 0x7A9AB1110
        public void GetAudioBufferedSampleCount(){} // RVA: 0x7A9AB11D0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7A9AB1250
        public void GetDecoderPerformance(){} // RVA: 0x7A9AB1260
        public void IssueRenderThreadEvent(){} // RVA: 0x7A9AB1310
        public void GetPluginVersion(){} // RVA: 0x7A9AB1430
        public void InternalSetActiveTrack(){} // RVA: 0x7A9AB1500
        public void InternalIsChangedTextCue(){} // RVA: 0x7A9AB15B0
        public void InternalGetCurrentTextCue(){} // RVA: 0x7A9AB1640
        public void InternalIsChangedTracks(){} // RVA: 0x7A9AB1710
        public void InternalGetTrackCount(){} // RVA: 0x7A9AB17B0
        public void InternalGetTrackInfo(){} // RVA: 0x7A9AB1850
        public void UpdateTimeRanges(){} // RVA: 0x7A9AB1CC0
        public void UpdateTimeRange(){} // RVA: 0x7A9AB1D30
        public void FlushFrameBuffering(){} // RVA: 0x7A9AB1E40
        public void InternalUpdateBufferedDisplay(){} // RVA: 0x7A9AB1F80
        public void LogBufferState(){} // RVA: 0x7A9AB2790
        public void SetBufferedDisplayTime(){} // RVA: 0x7A9AB2B60
        public void GetBufferedFramesState(){} // RVA: 0x7A9AB2C20
        public void SetBufferedDisplayMode(){} // RVA: 0x7A9AB2CC0
        public void SetBufferedDisplayOptions(){} // RVA: 0x7A9AB2DE0
        public void SetSlaves(){} // RVA: 0x7A9AB2E10
        public void IsPrerollComplete(){} // RVA: 0x7A9AB2F90
        public void .cctor(){} // RVA: 0x7A9AB3110
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AB68B0
        public void CanPlay(){} // RVA: 0x7A9AB6B90
        public void Dispose(){} // RVA: 0x7A9AB6BB0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x7A80D7320
        public void GetCurrentTime(){} // RVA: 0x7A9AB6D30
        public void GetDuration(){} // RVA: 0x7A9AB6DB0
        public void GetPlaybackRate(){} // RVA: 0x7A9AB6DC0
        public void GetTexture(){} // RVA: 0x7A9AB6E40
        public void GetTextureCount(){} // RVA: 0x7A9AB6E90
        public void GetTextureFrameCount(){} // RVA: 0x7A9651770
        public void InternalGetTextureStereoPacking(){} // RVA: 0x7A9AB6FA0
        public void GetVersion(){} // RVA: 0x7A9AB7020
        public void GetExpectedVersion(){} // RVA: 0x7A9AB7080
        public void GetVideoFrameRate(){} // RVA: 0x7A9AB70C0
        public void GetVideoWidth(){} // RVA: 0x7A9AB7170
        public void GetVideoHeight(){} // RVA: 0x7A9AB72B0
        public void GetVolume(){} // RVA: 0x7A9AB73F0
        public void SetBalance(){} // RVA: 0x7A9AB7470
        public void GetBalance(){} // RVA: 0x7A9AB7500
        public void HasAudio(){} // RVA: 0x7A9AB7580
        public void HasMetaData(){} // RVA: 0x7A9AB75C0
        public void HasVideo(){} // RVA: 0x7A9AB75F0
        public void IsBuffering(){} // RVA: 0x7A9AB7630
        public void IsFinished(){} // RVA: 0x7A9AB7650
        public void IsLooping(){} // RVA: 0x7A9AB7700
        public void IsMuted(){} // RVA: 0x7A9AB7790
        public void IsPaused(){} // RVA: 0x7A9AB7820
        public void IsPlaying(){} // RVA: 0x7A9AB7840
        public void IsSeeking(){} // RVA: 0x7A9AB7860
        public void MuteAudio(){} // RVA: 0x7A9AB7880
        public void OpenMedia(){} // RVA: 0x7A9AB7910
        public void CloseMedia(){} // RVA: 0x7A9AB7B20
        public void Pause(){} // RVA: 0x7A9AB7BC0
        public void Play(){} // RVA: 0x7A9AB7C40
        public void Render(){} // RVA: 0x7A9AB7CC0
        public void Update_Textures(){} // RVA: 0x7A9AB7D40
        public void get_AuthenticationData(){} // RVA: 0x7A8142610
        public void set_AuthenticationData(){} // RVA: 0x7A9AB8260
        public void RequiresVerticalFlip(){} // RVA: 0x7A81BD750
        public void Seek(){} // RVA: 0x7A9AB82D0
        public void SeekFast(){} // RVA: 0x7A9AA5620
        public void SetLooping(){} // RVA: 0x7A9AB8360
        public void SetPlaybackRate(){} // RVA: 0x7A9AB83F0
        public void SetVolume(){} // RVA: 0x7A9AB8480
        public void Stop(){} // RVA: 0x7A9AB8510
        public void UpdateTimeRanges(){} // RVA: 0x7A9AB8530
        public void UpdateTimeRange(){} // RVA: 0x7A9AB85A0
        public void GetProgramDateTime(){} // RVA: 0x7A9AB86B0
        public void Update(){} // RVA: 0x7A9AB88B0
        public void SetKeyServerAuthToken(){} // RVA: 0x7A9AB8D90
        public void SetOverrideDecryptionKey(){} // RVA: 0x7A9AB8E10
        public void InternalSetActiveTrack(){} // RVA: 0x7A9AB8E90
        public void InternalIsChangedTracks(){} // RVA: 0x7A9AB8F30
        public void InternalGetTrackCount(){} // RVA: 0x7A9AB8FC0
        public void InternalGetTrackInfo(){} // RVA: 0x7A9AB9050
        public void InternalIsChangedTextCue(){} // RVA: 0x7A9AB9450
        public void InternalGetCurrentTextCue(){} // RVA: 0x7A9AB94E0
        public void InitialisePlatform(){} // RVA: 0x7A9AB95B0
        public void DeinitPlatform(){} // RVA: 0x7A9AB9930
        public void .cctor(){} // RVA: 0x7A9AB9990
    }

}