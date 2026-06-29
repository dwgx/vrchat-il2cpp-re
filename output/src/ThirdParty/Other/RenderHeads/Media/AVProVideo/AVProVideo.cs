// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RenderHeads.Media.AVProVideo
// Classes: 76
// Methods: 1374

namespace ThirdParty.Other.RenderHeads.Media.AVProVideo
{
    public class ApplyToBase : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0xB700F0
        public void set_Player(){} // RVA: 0x254F590
        public void get_AutomaticStereoPacking(){} // RVA: 0xF73960
        public void set_AutomaticStereoPacking(){} // RVA: 0x254F5A0
        public void get_OverrideStereoPacking(){} // RVA: 0x1AE5AC0
        public void set_OverrideStereoPacking(){} // RVA: 0x254F5B0
        public void get_StereoRedGreenTint(){} // RVA: 0xB68DF0
        public void set_StereoRedGreenTint(){} // RVA: 0x254F5C0
        public void Awake(){} // RVA: 0x254F5D0
        public void ChangeMediaPlayer(){} // RVA: 0x254F5E0
        public void OnMediaPlayerEvent(){} // RVA: 0x254F950
        public void ForceUpdate(){} // RVA: 0x254F970
        public void Start(){} // RVA: 0x254FA20
        public void OnEnable(){} // RVA: 0x254FA60
        public void OnDisable(){} // RVA: 0x254FA90
        public void OnDestroy(){} // RVA: 0x254FAB0
        public void SaveProperties(){} // RVA: 0xB43310
        public void RestoreProperties(){} // RVA: 0xB43310
        public void Apply(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB79A60
    }

    public class ApplyToFarPlane : ApplyToBase
    {
        // ── Methods ──
        public void get_MainColor(){} // RVA: 0x2237C00
        public void set_MainColor(){} // RVA: 0x2535D70
        public void get_Texture(){} // RVA: 0xBBF8F0
        public void set_Texture(){} // RVA: 0x2535EA0
        public void get_Chroma(){} // RVA: 0xBE58B0
        public void set_Chroma(){} // RVA: 0x2536020
        public void get_Alpha(){} // RVA: 0xB6B160
        public void set_Alpha(){} // RVA: 0x25361A0
        public void get_Camera(){} // RVA: 0xBE2C60
        public void set_Camera(){} // RVA: 0x25362D0
        public void get_VideoAspectRatio(){} // RVA: 0x2536460
        public void set_VideoAspectRatio(){} // RVA: 0x2536470
        public void get_DrawOffset(){} // RVA: 0xD34770
        public void set_DrawOffset(){} // RVA: 0x25365A0
        public void get_CustomScaling(){} // RVA: 0xD346D0
        public void set_CustomScaling(){} // RVA: 0x2536700
        public void Awake(){} // RVA: 0x2536860
        public void OnDisable(){} // RVA: 0x2536A70
        public void OnDestroy(){} // RVA: 0x2536C30
        public void Update(){} // RVA: 0x2536CC0
        public void CreateQuadMesh(){} // RVA: 0x25370F0
        public void CreateMaterial(){} // RVA: 0x25375C0
        public void get_DefaultTexture(){} // RVA: 0x1069350
        public void set_DefaultTexture(){} // RVA: 0x25377D0
        public void get_TexturePropertyName(){} // RVA: 0x106A050
        public void set_TexturePropertyName(){} // RVA: 0x2537950
        public void get_Offset(){} // RVA: 0x2537BD0
        public void set_Offset(){} // RVA: 0x2537BF0
        public void get_Scale(){} // RVA: 0x2537C50
        public void set_Scale(){} // RVA: 0x2537C70
        public void get_ImageSize(){} // RVA: 0x2537CD0
        public void OnEnable(){} // RVA: 0x2537DB0
        public void LateUpdate(){} // RVA: 0x2538380
        public void UpdateMaterialProperties(){} // RVA: 0x25383A0
        public void Apply(){} // RVA: 0x25386E0
        public void ApplyMapping(){} // RVA: 0x2538EC0
        public void SaveProperties(){} // RVA: 0x2539590
        public void RestoreProperties(){} // RVA: 0x2539A20
        public void .ctor(){} // RVA: 0x2539C80
    }

    public class ApplyToMaterial : ApplyToBase
    {
        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0xD05CA0
        public void set_DefaultTexture(){} // RVA: 0x2539E80
        public void get_Material(){} // RVA: 0xBC1B30
        public void set_Material(){} // RVA: 0x253A000
        public void get_TexturePropertyName(){} // RVA: 0xBBF8F0
        public void set_TexturePropertyName(){} // RVA: 0x253A180
        public void get_Offset(){} // RVA: 0x253A3F0
        public void set_Offset(){} // RVA: 0x253A410
        public void get_Scale(){} // RVA: 0x253A460
        public void set_Scale(){} // RVA: 0x253A480
        public void LateUpdate(){} // RVA: 0x2538380
        public void Apply(){} // RVA: 0x253A4D0
        public void ApplyMapping(){} // RVA: 0x253AC90
        public void SaveProperties(){} // RVA: 0x253B2C0
        public void RestoreProperties(){} // RVA: 0x253B720
        public void .ctor(){} // RVA: 0x253B950
    }

    public class ApplyToMesh : ApplyToBase
    {
        // ── Methods ──
        public void get_DefaultTexture(){} // RVA: 0xD05CA0
        public void set_DefaultTexture(){} // RVA: 0x253BB30
        public void get_MeshRenderer(){} // RVA: 0xBC1B30
        public void set_MeshRenderer(){} // RVA: 0x253BCC0
        public void get_MaterialIndex(){} // RVA: 0xBE5890
        public void set_MaterialIndex(){} // RVA: 0xBE58A0
        public void ChangeDefaultTexture(){} // RVA: 0x253BB30
        public void ChangeRenderer(){} // RVA: 0x253BCD0
        public void get_TexturePropertyName(){} // RVA: 0xBE58B0
        public void set_TexturePropertyName(){} // RVA: 0x253BF60
        public void get_Offset(){} // RVA: 0x253A460
        public void set_Offset(){} // RVA: 0x253A480
        public void get_Scale(){} // RVA: 0x253C1D0
        public void set_Scale(){} // RVA: 0x253C1F0
        public void LateUpdate(){} // RVA: 0x2538380
        public void Apply(){} // RVA: 0x253C240
        public void ApplyMapping(){} // RVA: 0x253CA60
        public void OnEnable(){} // RVA: 0x253D1D0
        public void OnDisable(){} // RVA: 0x253D4D0
        public void SaveProperties(){} // RVA: 0x253D500
        public void .ctor(){} // RVA: 0x253D6E0
    }

    public class AudioChannelMixer : MonoBehaviour
    {
        // ── Methods ──
        public void get_Channel(){} // RVA: 0xB700F0
        public void set_Channel(){} // RVA: 0xB70100
        public void Reset(){} // RVA: 0x253D830
        public void ChangeChannelCount(){} // RVA: 0x253D900
        public void OnAudioFilterRead(){} // RVA: 0x253DA60
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class AudioOutput : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0xB700F0
        public void set_Player(){} // RVA: 0x253DC70
        public void get_OutputMode(){} // RVA: 0x1065D50
        public void set_OutputMode(){} // RVA: 0x13233D0
        public void get_ChannelMask(){} // RVA: 0x1AE5AC0
        public void set_ChannelMask(){} // RVA: 0x23E55F0
        public void get_SupportPositionalAudio(){} // RVA: 0xB68DF0
        public void set_SupportPositionalAudio(){} // RVA: 0xB68E00
        public void Awake(){} // RVA: 0x253DC80
        public void Start(){} // RVA: 0x253DD10
        public void OnAudioConfigurationChanged(){} // RVA: 0x253DDA0
        public void OnDestroy(){} // RVA: 0x253DEF0
        public void Update(){} // RVA: 0x253DF00
        public void GetAudioSource(){} // RVA: 0xD05CA0
        public void SetAudioSource(){} // RVA: 0x253E040
        public void ChangeMediaPlayer(){} // RVA: 0x253E1F0
        public void OnMediaPlayerEvent(){} // RVA: 0x253EB50
        public void ApplyAudioSettings(){} // RVA: 0xB43310
        public void OnAudioFilterRead(){} // RVA: 0x253EBA0
        public void .ctor(){} // RVA: 0x253EC20
    }

    public class AudioOutputManager : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x254FAC0
        public void .ctor(){} // RVA: 0x254FC40
        public void AddPlayerInstance(){} // RVA: 0x254FD00
        public void RemovePlayerInstance(){} // RVA: 0x254FEA0
        public void RequestAudio(){} // RVA: 0x254FF40
        public void ZeroAudio(){} // RVA: 0x2550A40
        public void GrabAudio(){} // RVA: 0x2550A90
    }

    public class AudioTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2567190
        public void get_Bitrate(){} // RVA: 0x18A0130
        public void set_Bitrate(){} // RVA: 0x189D3F0
        public void get_ChannelCount(){} // RVA: 0x114DAD0
        public void set_ChannelCount(){} // RVA: 0x25671C0
    }

    public class AudioTrack[] : Array
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

    public class AudioTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0xC3CCE0
        public void .ctor(){} // RVA: 0x25670E0
    }

    public class AuthData : Object
    {
        // ── Methods ──
        public void get_URL(){} // RVA: 0xB5DBF0
        public void set_URL(){} // RVA: 0xB44D60
        public void get_Token(){} // RVA: 0xB465B0
        public void set_Token(){} // RVA: 0xBA9BA0
        public void get_KeyBytes(){} // RVA: 0xB700F0
        public void set_KeyBytes(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x2558910
        public void Clear(){} // RVA: 0x2558910
        public void get_KeyBase64(){} // RVA: 0x2558A30
        public void set_KeyBase64(){} // RVA: 0x2558B10
    }

    public class BaseMediaPlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2550BB0
        public void GetVersion(){} // RVA: 0x87C0A0
        public void GetExpectedVersion(){} // RVA: 0x87C0A0
        public void OpenMedia(){} // RVA: 0x8804D0
        public void OpenMediaFromBuffer(){} // RVA: 0xB43320
        public void StartOpenMediaFromBuffer(){} // RVA: 0xB43320
        public void AddChunkToMediaBuffer(){} // RVA: 0xB43320
        public void EndOpenMediaFromBuffer(){} // RVA: 0xB43320
        public void CloseMedia(){} // RVA: 0x25511B0
        public void SetLooping(){} // RVA: 0x894750
        public void IsLooping(){} // RVA: 0x87D280
        public void HasMetaData(){} // RVA: 0x87D280
        public void CanPlay(){} // RVA: 0x87D280
        public void Play(){} // RVA: 0x894290
        public void Pause(){} // RVA: 0x894290
        public void Stop(){} // RVA: 0x894290
        public void Rewind(){} // RVA: 0x25512A0
        public void Seek(){} // RVA: 0x895980
        public void SeekFast(){} // RVA: 0x895980
        public void SeekWithTolerance(){} // RVA: 0x25512C0
        public void GetCurrentTime(){} // RVA: 0x8820E0
        public void GetProgramDateTime(){} // RVA: 0x25512E0
        public void GetPlaybackRate(){} // RVA: 0x890F90
        public void SetPlaybackRate(){} // RVA: 0x8A23A0
        public void GetDuration(){} // RVA: 0x8820E0
        public void GetVideoWidth(){} // RVA: 0x87C130
        public void GetVideoHeight(){} // RVA: 0x87C130
        public void GetVideoFrameRate(){} // RVA: 0x890F90
        public void GetVideoDisplayRate(){} // RVA: 0xBAB430
        public void HasAudio(){} // RVA: 0x87D280
        public void HasVideo(){} // RVA: 0x87D280
        public void IsVideoStereo(){} // RVA: 0x2551340
        public void IsSeeking(){} // RVA: 0x87D280
        public void IsPlaying(){} // RVA: 0x87D280
        public void IsPaused(){} // RVA: 0x87D280
        public void IsFinished(){} // RVA: 0x87D280
        public void IsBuffering(){} // RVA: 0x87D280
        public void WaitForNextFrame(){} // RVA: 0xB43320
        public void GetTextureCount(){} // RVA: 0xC3CCE0
        public void GetTexture(){} // RVA: 0x87C160
        public void GetTextureFrameCount(){} // RVA: 0x87C130
        public void SupportsTextureFrameCount(){} // RVA: 0xC2E4C0
        public void GetTextureTimeStamp(){} // RVA: 0x2551370
        public void RequiresVerticalFlip(){} // RVA: 0x87D280
        public void GetTexturePixelAspectRatio(){} // RVA: 0x1DF51C0
        public void GetYpCbCrTransform(){} // RVA: 0x2551380
        public void GetAffineTransform(){} // RVA: 0x25513E0
        public void GetTextureTransform(){} // RVA: 0x2551450
        public void GetTextureMatrix(){} // RVA: 0x2551470
        public void GetCompatibleRenderTextureFormat(){} // RVA: 0x132D270
        public void GetTextureStereoPacking(){} // RVA: 0x25515A0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x87C130
        public void GetTextureTransparency(){} // RVA: 0x1065D50
        public void GetTextureAlphaPacking(){} // RVA: 0x25515D0
        public void MuteAudio(){} // RVA: 0x894750
        public void IsMuted(){} // RVA: 0x87D280
        public void SetVolume(){} // RVA: 0x8A23A0
        public void SetBalance(){} // RVA: 0xB43310
        public void GetVolume(){} // RVA: 0x890F90
        public void GetBalance(){} // RVA: 0x13CD2E0
        public void GetAudioChannelCount(){} // RVA: 0xFE6B70
        public void GetAudioChannelMask(){} // RVA: 0xDAC980
        public void GrabAudio(){} // RVA: 0xDAC980
        public void GetAudioBufferedSampleCount(){} // RVA: 0xDAC980
        public void AudioConfigurationChanged(){} // RVA: 0xB43310
        public void SetAudioHeadRotation(){} // RVA: 0xB43310
        public void ResetAudioHeadRotation(){} // RVA: 0xB43310
        public void SetAudioChannelMode(){} // RVA: 0xB43310
        public void SetAudioFocusEnabled(){} // RVA: 0xB43310
        public void SetAudioFocusProperties(){} // RVA: 0xB43310
        public void SetAudioFocusRotation(){} // RVA: 0xB43310
        public void ResetAudioFocus(){} // RVA: 0xB43310
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x2551610
        public void SetPlayWithoutBuffering(){} // RVA: 0xB43310
        public void IsMediaCachingSupported(){} // RVA: 0xB43320
        public void AddMediaToCache(){} // RVA: 0xB43310
        public void CancelDownloadOfMediaToCache(){} // RVA: 0xB43310
        public void PauseDownloadOfMediaToCache(){} // RVA: 0xB43310
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0xB43310
        public void RemoveMediaFromCache(){} // RVA: 0xB43310
        public void GetCachedMediaStatus(){} // RVA: 0xDAC980
        public void IsExternalPlaybackSupported(){} // RVA: 0xB43320
        public void IsExternalPlaybackActive(){} // RVA: 0xB43320
        public void SetAllowsExternalPlayback(){} // RVA: 0xB43310
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0xB43310
        public void SetKeyServerAuthToken(){} // RVA: 0xB43310
        public void SetOverrideDecryptionKey(){} // RVA: 0xB43310
        public void Update(){} // RVA: 0x894290
        public void BeginRender(){} // RVA: 0xB43310
        public void Render(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894290
        public void GetDecoderPerformance(){} // RVA: 0xB43320
        public void EndUpdate(){} // RVA: 0xB43310
        public void GetNativePlayerHandle(){} // RVA: 0xDAC980
        public void GetLastError(){} // RVA: 0x2551620
        public void GetLastExtendedErrorCode(){} // RVA: 0xDAC980
        public void GetPlayerDescription(){} // RVA: 0xB5DBF0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0xC2E4C0
        public void GetSeekableTimes(){} // RVA: 0xD05CA0
        public void GetBufferedTimes(){} // RVA: 0xBC1B30
        public void GetTextureProperties(){} // RVA: 0x2551630
        public void SetTextureProperties(){} // RVA: 0x2551650
        public void ApplyTextureProperties(){} // RVA: 0x25516E0
        public void UpdateDisplayFrameRate(){} // RVA: 0x25517E0
        public void IsExpectingNewVideoFrame(){} // RVA: 0x25518B0
        public void IsPlaybackStalled(){} // RVA: 0x25519B0
        public void LoadSubtitlesSRT(){} // RVA: 0x2551BE0
        public void UpdateSubtitles(){} // RVA: 0x2551DA0
        public void GetSubtitleIndex(){} // RVA: 0x2551F10
        public void GetSubtitleText(){} // RVA: 0x2551F30
        public void OnEnable(){} // RVA: 0xB43310
        public void GetCurrentTimeFrames(){} // RVA: 0x2551F70
        public void GetDurationFrames(){} // RVA: 0x2552060
        public void GetMaxFrameNumber(){} // RVA: 0x2552120
        public void SeekToFrameRelative(){} // RVA: 0x2552140
        public void SeekToFrame(){} // RVA: 0x2552290
        public void GetPlaybackQualityStats(){} // RVA: 0xC10050
        public void GetCurrentTextCue(){} // RVA: 0xCD3320
        public void UpdateTextCue(){} // RVA: 0x25523A0
        public void InternalIsChangedTextCue(){} // RVA: 0x87D280
        public void InternalGetCurrentTextCue(){} // RVA: 0x87C0A0
        public void HasNewTimedMetadataItem(){} // RVA: 0x1C556E0
        public void GetTimedMetadataItem(){} // RVA: 0x2552550
        public void UpdateTimedMetadata(){} // RVA: 0x2552560
        public void InternalHasUpdatedTimedMetadata(){} // RVA: 0xB43320
        public void InternalGetTimedMetadataItem(){} // RVA: 0xDAC980
        public void GetVideoTracks(){} // RVA: 0x1069350
        public void GetAudioTracks(){} // RVA: 0x106A7D0
        public void GetTextTracks(){} // RVA: 0x106A050
        public void GetActiveVideoTrack(){} // RVA: 0x25525F0
        public void GetActiveAudioTrack(){} // RVA: 0x2552640
        public void GetActiveTextTrack(){} // RVA: 0x2552690
        public void SetActiveVideoTrack(){} // RVA: 0x25526E0
        public void SetActiveAudioTrack(){} // RVA: 0x2552700
        public void SetActiveTextTrack(){} // RVA: 0x2552720
        public void GetTextTrackArrayIndexFromUid(){} // RVA: 0x2552740
        public void InternalIsChangedTracks(){} // RVA: 0x87DD20
        public void InternalGetTrackCount(){} // RVA: 0x881C20
        public void InternalSetActiveTrack(){} // RVA: 0x87D5A0
        public void InternalGetTrackInfo(){} // RVA: 0x88C580
        public void InitTracks(){} // RVA: 0x2552790
        public void UpdateTracks(){} // RVA: 0x2552920
        public void PopulateTrackCollection(){} // RVA: 0x25529E0
        public void SetActiveTrack(){} // RVA: 0x2552BC0
        public void get_Count(){} // RVA: 0x2552CB0
        public void get_Current(){} // RVA: 0x2552D00
        public void get_Item(){} // RVA: 0x2552D20
        public void GetEnumerator(){} // RVA: 0x2552DA0
        public void GetSelectedVariant(){} // RVA: 0x2552E90
        public void SelectVariant(){} // RVA: 0xB43310
        public void UpdateVariants(){} // RVA: 0x2552F30
        public void InternalGetVariantCount(){} // RVA: 0xDAC980
        public void InternalGetVariantAtIndex(){} // RVA: 0xDAC980
    }

    public class DisplayIMGUI : MonoBehaviour
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0xB700F0
        public void set_Player(){} // RVA: 0x253EC80
        public void get_ScaleMode(){} // RVA: 0x1065D50
        public void set_ScaleMode(){} // RVA: 0x13233D0
        public void get_Color(){} // RVA: 0x253EDB0
        public void set_Color(){} // RVA: 0x253EDC0
        public void get_AllowTransparency(){} // RVA: 0xCB23E0
        public void set_AllowTransparency(){} // RVA: 0xCB23F0
        public void get_UseDepth(){} // RVA: 0x1D901B0
        public void set_UseDepth(){} // RVA: 0x253EDD0
        public void get_Depth(){} // RVA: 0xBE5850
        public void set_Depth(){} // RVA: 0xBE5860
        public void get_IsAreaFullScreen(){} // RVA: 0x23E22A0
        public void set_IsAreaFullScreen(){} // RVA: 0x23E2270
        public void get_AreaX(){} // RVA: 0x1767220
        public void set_AreaX(){} // RVA: 0x1767230
        public void get_AreaY(){} // RVA: 0x15CB5C0
        public void set_AreaY(){} // RVA: 0x17672E0
        public void get_AreaWidth(){} // RVA: 0xBAB430
        public void set_AreaWidth(){} // RVA: 0xBAB440
        public void get_AreaHeight(){} // RVA: 0x1122A70
        public void set_AreaHeight(){} // RVA: 0x11256E0
        public void get_ShowAreaInEditor(){} // RVA: 0xE3F480
        public void set_ShowAreaInEditor(){} // RVA: 0x1546550
        public void Start(){} // RVA: 0x253EDE0
        public void Update(){} // RVA: 0x253F0C0
        public void OnDestroy(){} // RVA: 0x253F1A0
        public void GetRequiredShader(){} // RVA: 0x253F320
        public void SetupMaterial(){} // RVA: 0x253F360
        public void OnGUI(){} // RVA: 0x253F7D0
        public void GetAreaRect(){} // RVA: 0x253FF80
        public void .ctor(){} // RVA: 0x2540200
    }

    public class DisplayUGUI : MaskableGraphic
    {
        // ── Methods ──
        public void get_Player(){} // RVA: 0xBC5B30
        public void set_Player(){} // RVA: 0x2531060
        public void get_DefaultTexture(){} // RVA: 0xBC5BA0
        public void set_DefaultTexture(){} // RVA: 0x2531070
        public void get_UVRect(){} // RVA: 0x25311F0
        public void set_UVRect(){} // RVA: 0x2531200
        public void get_ApplyNativeSize(){} // RVA: 0x2443BA0
        public void set_ApplyNativeSize(){} // RVA: 0x2443BB0
        public void get_ScaleMode(){} // RVA: 0x2531210
        public void set_ScaleMode(){} // RVA: 0x232C690
        public void get_NoDefaultDisplay(){} // RVA: 0x1FDB9C0
        public void set_NoDefaultDisplay(){} // RVA: 0x1FDB9D0
        public void get_DisplayInEditor(){} // RVA: 0x2443DE0
        public void set_DisplayInEditor(){} // RVA: 0x2444100
        public void get_DrawingDimensions(){} // RVA: 0x2531220
        public void Awake(){} // RVA: 0x2531230
        public void OnMediaPlayerEvent(){} // RVA: 0x2531380
        public void ChangeMediaPlayer(){} // RVA: 0x25314F0
        public void EnsureShader(){} // RVA: 0x2531880
        public void EnsureAlphaPackingShader(){} // RVA: 0x2531A40
        public void EnsureStereoPackingShader(){} // RVA: 0x2531B30
        public void EnsureAndroidOESShader(){} // RVA: 0x2531C20
        public void EnsureAndroidOESAlphaPackingShader(){} // RVA: 0x2531D10
        public void Start(){} // RVA: 0x2531E00
        public void OnDestroy(){} // RVA: 0x2531FA0
        public void GetRequiredShader(){} // RVA: 0x2532160
        public void get_mainTexture(){} // RVA: 0x2532750
        public void HasValidTexture(){} // RVA: 0x2532910
        public void UpdateInternalMaterial(){} // RVA: 0x2532B90
        public void LateUpdate(){} // RVA: 0x2532FE0
        public void get_CurrentMediaPlayer(){} // RVA: 0xBC5B30
        public void set_CurrentMediaPlayer(){} // RVA: 0x2533680
        public void get_uvRect(){} // RVA: 0x25311F0
        public void set_uvRect(){} // RVA: 0x2533810
        public void SetNativeSize(){} // RVA: 0x2533880
        public void OnPopulateMesh(){} // RVA: 0x2533C50
        public void _OnFillVBO(){} // RVA: 0x2533D00
        public void GetDrawingDimensions(){} // RVA: 0x25341D0
        public void .ctor(){} // RVA: 0x2534990
        public void .cctor(){} // RVA: 0x2534B50
    }

    public class Easing : Object
    {
        // ── Methods ──
        public void GetFunction(){} // RVA: 0x2567200
        public void PowerEaseIn(){} // RVA: 0x2567700
        public void PowerEaseOut(){} // RVA: 0x2567710
        public void PowerEaseInOut(){} // RVA: 0x2567750
        public void Step(){} // RVA: 0x25677D0
        public void Linear(){} // RVA: 0xB43310
        public void InQuad(){} // RVA: 0x25677F0
        public void OutQuad(){} // RVA: 0x2567800
        public void InOutQuad(){} // RVA: 0x2567840
        public void InCubic(){} // RVA: 0x2567850
        public void OutCubic(){} // RVA: 0x2567860
        public void InOutCubic(){} // RVA: 0x25678A0
        public void InQuart(){} // RVA: 0x25678B0
        public void OutQuart(){} // RVA: 0x25678C0
        public void InOutQuart(){} // RVA: 0x2567900
        public void InQuint(){} // RVA: 0x2567910
        public void OutQuint(){} // RVA: 0x2567920
        public void InOutQuint(){} // RVA: 0x2567960
        public void InExpo(){} // RVA: 0x2567970
        public void OutExpo(){} // RVA: 0x25679B0
        public void InOutExpo(){} // RVA: 0x2567A00
    }

    public class Helper : Object
    {
        // ── Methods ──
        public void GetPath(){} // RVA: 0x2553830
        public void GetFilePath(){} // RVA: 0x25539A0
        public void GetFriendlyResolutionName(){} // RVA: 0x2553BD0
        public void GetErrorMessage(){} // RVA: 0x2553F60
        public void GetPlatformName(){} // RVA: 0x25540A0
        public void GetPlatformNames(){} // RVA: 0x2554130
        public void LogInfo(){} // RVA: 0x25545D0
        public void GetUnityAudioSampleRate(){} // RVA: 0x2554730
        public void GetUnityAudioSpeakerCount(){} // RVA: 0x25547E0
        public void GetTimelineRange(){} // RVA: 0x25548C0
        public void GetTimeString(){} // RVA: 0x2554920
        public void GetOrientation(){} // RVA: 0x2554D70
        public void GetMatrixForOrientation(){} // RVA: 0x2554F80
        public void Matrix4x4FromAffineTransform(){} // RVA: 0x25551A0
        public void ConvertTimeSecondsToFrame(){} // RVA: 0x2555250
        public void ConvertFrameToTimeSeconds(){} // RVA: 0x25552F0
        public void FindNextKeyFrameTimeSeconds(){} // RVA: 0x2555330
        public void ConvertSecondsSince1970ToDateTime(){} // RVA: 0x2555480
        public void GetShortPathName(){} // RVA: 0x25555E0
        public void ConvertLongPathToShortDOS83Path(){} // RVA: 0x25556D0
        public void GetReadableTexture(){} // RVA: 0x2555F80
        public void .cctor(){} // RVA: 0x25562E0
    }

    public class HttpHeader : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void IsComplete(){} // RVA: 0x85330
        public void ToValidatedString(){} // RVA: 0x85360
        public void IsValid(){} // RVA: 0x85370
        public void IsAscii(){} // RVA: 0x2567C60
    }

    public class HttpHeaderData : Object
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x2567D00
        public void get_Item(){} // RVA: 0x2567DE0
        public void Clear(){} // RVA: 0x2567E70
        public void Add(){} // RVA: 0x2567EE0
        public void IsModified(){} // RVA: 0x2568010
        public void ToValidatedString(){} // RVA: 0x2568060
        public void .ctor(){} // RVA: 0x2568280
    }

    public class HttpHeader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IAudioTracks
    {
        // ── Methods ──
        public void GetAudioTracks(){} // RVA: 0x87C0A0
        public void GetActiveAudioTrack(){} // RVA: 0x87C0A0
        public void SetActiveAudioTrack(){} // RVA: 0x894320
    }

    public class IMediaCache
    {
        // ── Methods ──
        public void IsMediaCachingSupported(){} // RVA: 0x87D280
        public void AddMediaToCache(){} // RVA: 0x8954D0
        public void CancelDownloadOfMediaToCache(){} // RVA: 0x894320
        public void PauseDownloadOfMediaToCache(){} // RVA: 0x894320
        public void ResumeDownloadOfMediaToCache(){} // RVA: 0x894320
        public void RemoveMediaFromCache(){} // RVA: 0x894320
        public void GetCachedMediaStatus(){} // RVA: 0x881CA0
    }

    public class IMediaControl
    {
        // ── Methods ──
        public void OpenMedia(){} // RVA: 0x8804D0
        public void OpenMediaFromBuffer(){} // RVA: 0x87D350
        public void StartOpenMediaFromBuffer(){} // RVA: 0x87D490
        public void AddChunkToMediaBuffer(){} // RVA: 0x8812E0
        public void EndOpenMediaFromBuffer(){} // RVA: 0x87D280
        public void CloseMedia(){} // RVA: 0x894290
        public void SetLooping(){} // RVA: 0x894750
        public void IsLooping(){} // RVA: 0x87D280
        public void HasMetaData(){} // RVA: 0x87D280
        public void CanPlay(){} // RVA: 0x87D280
        public void IsPlaying(){} // RVA: 0x87D280
        public void IsSeeking(){} // RVA: 0x87D280
        public void IsPaused(){} // RVA: 0x87D280
        public void IsFinished(){} // RVA: 0x87D280
        public void IsBuffering(){} // RVA: 0x87D280
        public void Play(){} // RVA: 0x894290
        public void Pause(){} // RVA: 0x894290
        public void Stop(){} // RVA: 0x894290
        public void Rewind(){} // RVA: 0x894290
        public void Seek(){} // RVA: 0x895980
        public void SeekFast(){} // RVA: 0x895980
        public void SeekWithTolerance(){} // RVA: 0xA94080
        public void SeekToFrame(){} // RVA: 0x897DD0
        public void SeekToFrameRelative(){} // RVA: 0x897DD0
        public void GetCurrentTime(){} // RVA: 0x8820E0
        public void GetCurrentTimeFrames(){} // RVA: 0x888E40
        public void GetProgramDateTime(){} // RVA: 0x87C0A0
        public void GetPlaybackRate(){} // RVA: 0x890F90
        public void SetPlaybackRate(){} // RVA: 0x8A23A0
        public void MuteAudio(){} // RVA: 0x894750
        public void IsMuted(){} // RVA: 0x87D280
        public void SetVolume(){} // RVA: 0x8A23A0
        public void SetBalance(){} // RVA: 0x8A23A0
        public void GetVolume(){} // RVA: 0x890F90
        public void GetBalance(){} // RVA: 0x890F90
        public void GetSeekableTimes(){} // RVA: 0x87C0A0
        public void GetBufferedTimes(){} // RVA: 0x87C0A0
        public void GetLastError(){} // RVA: 0x87C130
        public void GetLastExtendedErrorCode(){} // RVA: 0x87C0A0
        public void SetTextureProperties(){} // RVA: 0x896900
        public void GetTextureProperties(){} // RVA: 0x8954D0
        public void GrabAudio(){} // RVA: 0x885A60
        public void GetAudioBufferedSampleCount(){} // RVA: 0x87C130
        public void GetAudioChannelCount(){} // RVA: 0x87C130
        public void GetAudioChannelMask(){} // RVA: 0x87C130
        public void AudioConfigurationChanged(){} // RVA: 0x894750
        public void SetAudioChannelMode(){} // RVA: 0x8944F0
        public void SetAudioHeadRotation(){} // RVA: 0x894320
        public void ResetAudioHeadRotation(){} // RVA: 0x894290
        public void SetAudioFocusEnabled(){} // RVA: 0x894750
        public void SetAudioFocusProperties(){} // RVA: 0x8A2920
        public void SetAudioFocusRotation(){} // RVA: 0x894320
        public void ResetAudioFocus(){} // RVA: 0x894290
        public void WaitForNextFrame(){} // RVA: 0x87FE70
        public void SetPlayWithoutBuffering(){} // RVA: 0x894750
        public void SetKeyServerAuthToken(){} // RVA: 0x894320
        public void SetOverrideDecryptionKey(){} // RVA: 0x894320
        public void IsExternalPlaybackActive(){} // RVA: 0x87D280
        public void SetAllowsExternalPlayback(){} // RVA: 0x894750
        public void SetExternalPlaybackVideoGravity(){} // RVA: 0x8944F0
    }

    public class IMediaInfo
    {
        // ── Methods ──
        public void GetDuration(){} // RVA: 0x8820E0
        public void GetDurationFrames(){} // RVA: 0x888E40
        public void GetMaxFrameNumber(){} // RVA: 0x888E40
        public void GetVideoWidth(){} // RVA: 0x87C130
        public void GetVideoHeight(){} // RVA: 0x87C130
        public void GetVideoFrameRate(){} // RVA: 0x890F90
        public void GetVideoDisplayRate(){} // RVA: 0x890F90
        public void HasVideo(){} // RVA: 0x87D280
        public void HasAudio(){} // RVA: 0x87D280
        public void GetPlayerDescription(){} // RVA: 0x87C0A0
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x87D280
        public void IsPlaybackStalled(){} // RVA: 0x87D280
        public void GetTextureTransform(){} // RVA: 0x87C0A0
        public void GetEstimatedTotalBandwidthUsed(){} // RVA: 0x87C0A0
        public void IsExternalPlaybackSupported(){} // RVA: 0x87D280
        public void GetDecoderPerformance(){} // RVA: 0x87D710
        public void GetPlaybackQualityStats(){} // RVA: 0x87C0A0
    }

    public class IMediaPlayer
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x894290
        public void Update(){} // RVA: 0x894290
        public void EndUpdate(){} // RVA: 0x894290
        public void BeginRender(){} // RVA: 0x894290
        public void Render(){} // RVA: 0x894290
        public void GetNativePlayerHandle(){} // RVA: 0x87C0A0
    }

    public class IMediaSubtitles
    {
        // ── Methods ──
        public void LoadSubtitlesSRT(){} // RVA: 0x87D350
        public void GetSubtitleIndex(){} // RVA: 0x87C130
        public void GetSubtitleText(){} // RVA: 0x87C0A0
    }

    public class ITextTracks
    {
        // ── Methods ──
        public void GetTextTracks(){} // RVA: 0x87C0A0
        public void GetActiveTextTrack(){} // RVA: 0x87C0A0
        public void SetActiveTextTrack(){} // RVA: 0x894320
        public void GetCurrentTextCue(){} // RVA: 0x87C0A0
        public void GetTextTrackArrayIndexFromUid(){} // RVA: 0x881C20
    }

    public class ITextureProducer
    {
        // ── Methods ──
        public void GetTextureCount(){} // RVA: 0x87C130
        public void GetTexture(){} // RVA: 0x87C160
        public void GetTextureFrameCount(){} // RVA: 0x87C130
        public void SupportsTextureFrameCount(){} // RVA: 0x87D280
        public void GetTextureTimeStamp(){} // RVA: 0x87C0A0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x890F90
        public void RequiresVerticalFlip(){} // RVA: 0x87D280
        public void GetTextureStereoPacking(){} // RVA: 0x87C130
        public void GetTextureTransparency(){} // RVA: 0x87C130
        public void GetTextureAlphaPacking(){} // RVA: 0x87C130
        public void GetYpCbCrTransform(){} // RVA: 0x87BEB0
        public void GetAffineTransform(){} // RVA: 0x87C0A0
        public void GetTextureMatrix(){} // RVA: 0x87BEB0
        public void GetCompatibleRenderTextureFormat(){} // RVA: 0x8830B0
    }

    public class ITimedMetadata
    {
        // ── Methods ──
        public void HasNewTimedMetadataItem(){} // RVA: 0x87D280
        public void GetTimedMetadataItem(){} // RVA: 0x87C0A0
    }

    public class IVariants
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x87C130
        public void get_Current(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0x87C160
        public void GetSelectedVariant(){} // RVA: 0x87C0A0
        public void SelectVariant(){} // RVA: 0x894320
    }

    public class IVideoTracks
    {
        // ── Methods ──
        public void GetVideoTracks(){} // RVA: 0x87C0A0
        public void GetActiveVideoTrack(){} // RVA: 0x87C0A0
        public void SetActiveVideoTrack(){} // RVA: 0x894320
    }

    public class KeyAuthData : Object
    {
        // ── Methods ──
        public void IsModified(){} // RVA: 0x2568340
        public void get_overrideDecryptionKey(){} // RVA: 0xB700F0
        public void set_overrideDecryptionKey(){} // RVA: 0x2568370
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void OnAfterDeserialize(){} // RVA: 0x25685D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LazyShaderProperty : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x853B0
        public void get_Name(){} // RVA: 0x77900
        public void get_Id(){} // RVA: 0x853C0
    }

    public class MediaCachingOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MediaHints : ValueType
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x2556CE0
        public void .cctor(){} // RVA: 0xB43310
    }

    public class MediaPath : Object
    {
        // ── Methods ──
        public void get_PathType(){} // RVA: 0xB8F8F0
        public void set_PathType(){} // RVA: 0xB460A0
        public void get_Path(){} // RVA: 0xB465B0
        public void set_Path(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x2556920
        public void GetResolvedFullPath(){} // RVA: 0x25569F0
        public void op_Implicit(){} // RVA: 0x2556AC0
        public void op_Equality(){} // RVA: 0x2556B20
        public void op_Inequality(){} // RVA: 0x2556B40
        public void Equals(){} // RVA: 0x2556B80
        public void GetHashCode(){} // RVA: 0x2556CA0
    }

    public class MediaPlayer : MonoBehaviour
    {
        // ── Methods ──
        public void get_MediaSource(){} // RVA: 0xFEAE90
        public void set_MediaSource(){} // RVA: 0x1269760
        public void SetMediaSource(){} // RVA: 0x1269760
        public void get_MediaReference(){} // RVA: 0xB70160
        public void set_MediaReference(){} // RVA: 0xB44DC0
        public void SetMediaReference(){} // RVA: 0xB44DC0
        public void get_MediaPath(){} // RVA: 0xD33E60
        public void set_MediaPath(){} // RVA: 0xB708C0
        public void SetMediaPath(){} // RVA: 0xB708C0
        public void get_FallbackMediaHints(){} // RVA: 0xBA9C60
        public void set_FallbackMediaHints(){} // RVA: 0xBA9C80
        public void get_AutoOpen(){} // RVA: 0x23E22A0
        public void set_AutoOpen(){} // RVA: 0x23E2270
        public void get_AutoStart(){} // RVA: 0x2540270
        public void set_AutoStart(){} // RVA: 0x2540280
        public void get_Loop(){} // RVA: 0x2540290
        public void set_Loop(){} // RVA: 0x25402F0
        public void get_AudioVolume(){} // RVA: 0x2540360
        public void set_AudioVolume(){} // RVA: 0x25403C0
        public void get_AudioBalance(){} // RVA: 0x2540450
        public void set_AudioBalance(){} // RVA: 0x25404B0
        public void get_AudioMuted(){} // RVA: 0x2540540
        public void set_AudioMuted(){} // RVA: 0x25405A0
        public void get_AudioSource(){} // RVA: 0xC0FFC0
        public void set_AudioSource(){} // RVA: 0xC0FFD0
        public void SetAudioSource(){} // RVA: 0xC0FFD0
        public void get_PlaybackRate(){} // RVA: 0x2540610
        public void set_PlaybackRate(){} // RVA: 0x2540670
        public void get_UseResampler(){} // RVA: 0x1D450E0
        public void set_UseResampler(){} // RVA: 0x1D43780
        public void get_ResampleMode(){} // RVA: 0x2536460
        public void set_ResampleMode(){} // RVA: 0x25406E0
        public void get_ResampleBufferSize(){} // RVA: 0x25406F0
        public void set_ResampleBufferSize(){} // RVA: 0x2540700
        public void get_FrameResampler(){} // RVA: 0xC10050
        public void get_VideoLayoutMapping(){} // RVA: 0x23ADD10
        public void set_VideoLayoutMapping(){} // RVA: 0x23B2A80
        public void get_TextureFilterMode(){} // RVA: 0x2540710
        public void set_TextureFilterMode(){} // RVA: 0x2540810
        public void get_TextureWrapMode(){} // RVA: 0x2540890
        public void set_TextureWrapMode(){} // RVA: 0x2540990
        public void get_TextureAnisoLevel(){} // RVA: 0x2540A10
        public void set_TextureAnisoLevel(){} // RVA: 0x2540B10
        public void get_SideloadSubtitles(){} // RVA: 0x1C556E0
        public void set_SideloadSubtitles(){} // RVA: 0x19CAF90
        public void get_SubtitlePath(){} // RVA: 0x1069350
        public void set_SubtitlePath(){} // RVA: 0xD5CC10
        public void set_AudioHeadTransform(){} // RVA: 0xD5CC70
        public void get_AudioHeadTransform(){} // RVA: 0x106A7D0
        public void get_AudioFocusEnabled(){} // RVA: 0x2443C20
        public void set_AudioFocusEnabled(){} // RVA: 0x143D170
        public void get_AudioFocusTransform(){} // RVA: 0x12EB090
        public void set_AudioFocusTransform(){} // RVA: 0x13B1040
        public void get_AudioFocusWidthDegrees(){} // RVA: 0x1BFC910
        public void set_AudioFocusWidthDegrees(){} // RVA: 0x2540B90
        public void get_AudioFocusOffLevelDB(){} // RVA: 0x2540BA0
        public void set_AudioFocusOffLevelDB(){} // RVA: 0x2540BB0
        public void get_HttpHeaders(){} // RVA: 0xBAE3B0
        public void set_HttpHeaders(){} // RVA: 0xBAE3C0
        public void get_KeyAuth(){} // RVA: 0xBAE420
        public void set_KeyAuth(){} // RVA: 0xBAE430
        public void get_Events(){} // RVA: 0x2540BC0
        public void get_EventMask(){} // RVA: 0x131DCD0
        public void set_EventMask(){} // RVA: 0x23B1640
        public void get_PauseMediaOnAppPause(){} // RVA: 0xD95EC0
        public void set_PauseMediaOnAppPause(){} // RVA: 0x2540E50
        public void get_PlayMediaOnAppUnpause(){} // RVA: 0xD98E60
        public void set_PlayMediaOnAppUnpause(){} // RVA: 0x2540E60
        public void get_Persistent(){} // RVA: 0x2540E70
        public void set_Persistent(){} // RVA: 0x2540E80
        public void get_ForceFileFormat(){} // RVA: 0x2540E90
        public void set_ForceFileFormat(){} // RVA: 0x2540EA0
        public void get_Info(){} // RVA: 0x135A7B0
        public void get_Control(){} // RVA: 0xBC5BA0
        public void get_Player(){} // RVA: 0x10B4170
        public void get_TextureProducer(){} // RVA: 0xBAE5A0
        public void get_Subtitles(){} // RVA: 0x10B9D50
        public void get_VideoTracks(){} // RVA: 0xDA0520
        public void get_AudioTracks(){} // RVA: 0x114AC20
        public void get_TextTracks(){} // RVA: 0xE3C930
        public void get_TimedMetadata(){} // RVA: 0x135EDB0
        public void get_Variants(){} // RVA: 0x135A170
        public void get_Cache(){} // RVA: 0xD9E3D0
        public void get_MediaOpened(){} // RVA: 0x2540EB0
        public void Awake(){} // RVA: 0xB43310
        public void Initialise(){} // RVA: 0x2540EC0
        public void Start(){} // RVA: 0x2541890
        public void OpenMedia(){} // RVA: 0x2541B30
        public void InternalOpenMedia(){} // RVA: 0x2541B60
        public void SetLoadOptions(){} // RVA: 0x25425F0
        public void SetPlaybackOptions(){} // RVA: 0x2542900
        public void CloseMedia(){} // RVA: 0x2542A30
        public void Play(){} // RVA: 0x2542BC0
        public void Pause(){} // RVA: 0x2542C60
        public void Stop(){} // RVA: 0x2542CE0
        public void Rewind(){} // RVA: 0x2542D40
        public void SeekToLiveTime(){} // RVA: 0x2542DD0
        public void Update(){} // RVA: 0x2542E70
        public void LateUpdate(){} // RVA: 0x25431F0
        public void UpdateResampler(){} // RVA: 0x2543390
        public void OnEnable(){} // RVA: 0x25434F0
        public void OnDisable(){} // RVA: 0x2543570
        public void OnDestroy(){} // RVA: 0x2543670
        public void ForceDispose(){} // RVA: 0x2543B60
        public void AllPlayersDispose(){} // RVA: 0x2543BA0
        public void OnApplicationQuit(){} // RVA: 0x2543C70
        public void StartRenderCoroutine(){} // RVA: 0x2543F10
        public void StopRenderCoroutine(){} // RVA: 0x25440E0
        public void FinalRenderCapture(){} // RVA: 0x2544160
        public void GetPlatform(){} // RVA: 0xDAC980
        public void GetCurrentPlatformOptions(){} // RVA: 0x165EBC0
        public void GetPlatformVideoApiString(){} // RVA: 0x2544200
        public void GetPlatformFileOffset(){} // RVA: 0xDAC980
        public void GetPlatformHttpHeadersAsString(){} // RVA: 0x2544270
        public void GetResolvedFilePath(){} // RVA: 0x2544320
        public void CreateMediaPlayer(){} // RVA: 0x2544580
        public void CreateMediaPlayerNull(){} // RVA: 0x2544510
        public void UpdateAudioFocus(){} // RVA: 0x25449E0
        public void UpdateAudioHeadTransform(){} // RVA: 0x2544CA0
        public void UpdateErrors(){} // RVA: 0x2544F00
        public void IsUsingAndroidOESPath(){} // RVA: 0xB43320
        public void IsUsingYCbCr(){} // RVA: 0xB43320
        public void OnApplicationFocus(){} // RVA: 0xB43310
        public void OnApplicationPause(){} // RVA: 0xB43310
        public void ResetEvents(){} // RVA: 0x2545160
        public void CheckAndClearStartedAndFinishedEvents(){} // RVA: 0x2545190
        public void HandleOneShotEvents(){} // RVA: 0x2545260
        public void HandleRecurringEvents(){} // RVA: 0x25452F0
        public void UpdateEvents(){} // RVA: 0x2545550
        public void IsHandleEvent(){} // RVA: 0x25456E0
        public void FireEventIfPossible(){} // RVA: 0x2545710
        public void CanFireEvent(){} // RVA: 0x25457A0
        public void ForceWaitForNewFrame(){} // RVA: 0x2545D60
        public void ExtractFrame(){} // RVA: 0x2546190
        public void OpenMediaFromBuffer(){} // RVA: 0x2546430
        public void StartOpenChunkedMediaFromBuffer(){} // RVA: 0x2546530
        public void AddChunkToVideoBuffer(){} // RVA: 0x2546630
        public void EndOpenChunkedVideoFromBuffer(){} // RVA: 0x2546750
        public void OpenMediaFromBufferInternal(){} // RVA: 0x25467E0
        public void StartOpenMediaFromBufferInternal(){} // RVA: 0x2546A40
        public void AddChunkToBufferInternal(){} // RVA: 0x2546630
        public void EndOpenMediaFromBufferInternal(){} // RVA: 0x2546750
        public void get_PlatformOptionsWindows(){} // RVA: 0x165EBC0
        public void get_PlatformOptions_macOS(){} // RVA: 0x1667D40
        public void get_PlatformOptions_iOS(){} // RVA: 0x13659D0
        public void get_PlatformOptions_tvOS(){} // RVA: 0x135C160
        public void get_PlatformOptions_visionOS(){} // RVA: 0x1664460
        public void get_PlatformOptionsAndroid(){} // RVA: 0x135A180
        public void get_PlatformOptionsOpenHarmony(){} // RVA: 0x165E8F0
        public void get_PlatformOptionsWindowsUWP(){} // RVA: 0x1659CB0
        public void get_PlatformOptionsWebGL(){} // RVA: 0x1344890
        public void EnableSubtitles(){} // RVA: 0xB43320
        public void DisableSubtitles(){} // RVA: 0x2546C20
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x2546D80
        public void .ctor(){} // RVA: 0x2546F00
    }

    public class MediaPlayerEvent : UnityEvent`3
    {
        // ── Methods ──
        public void HasListeners(){} // RVA: 0x2553310
        public void AddListener(){} // RVA: 0x25533A0
        public void RemoveListener(){} // RVA: 0x2553520
        public void RemoveAllListeners(){} // RVA: 0x2553620
        public void .ctor(){} // RVA: 0x2553690
    }

    public class MediaPlayerLoadEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x25532D0
    }

    public class MediaPlaylist : Object
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0xB5DBF0
        public void HasItemAt(){} // RVA: 0x2548760
        public void .ctor(){} // RVA: 0x25487D0
    }

    public class MediaReference : ScriptableObject
    {
        // ── Methods ──
        public void get_Alias(){} // RVA: 0xB465B0
        public void set_Alias(){} // RVA: 0xBA9BA0
        public void get_MediaPath(){} // RVA: 0xB700F0
        public void set_MediaPath(){} // RVA: 0xB70100
        public void get_Hints(){} // RVA: 0xBBF8C0
        public void set_Hints(){} // RVA: 0xBBF8E0
        public void GetCurrentPlatformMediaReference(){} // RVA: 0x2535A70
        public void GetPlatformMediaReference(){} // RVA: 0x2535B40
        public void .ctor(){} // RVA: 0x2535BD0
    }

    public class NullMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x2558120
        public void GetExpectedVersion(){} // RVA: 0x2558160
        public void OpenMedia(){} // RVA: 0x2558180
        public void CloseMedia(){} // RVA: 0x25584C0
        public void SetLooping(){} // RVA: 0x1A6FC50
        public void IsLooping(){} // RVA: 0x1A6FCB0
        public void HasMetaData(){} // RVA: 0xC2E4C0
        public void CanPlay(){} // RVA: 0xC2E4C0
        public void HasAudio(){} // RVA: 0xB43320
        public void HasVideo(){} // RVA: 0xB43320
        public void Play(){} // RVA: 0x2558500
        public void Pause(){} // RVA: 0x2558520
        public void Stop(){} // RVA: 0x2558530
        public void IsSeeking(){} // RVA: 0xB43320
        public void IsPlaying(){} // RVA: 0x20119F0
        public void IsPaused(){} // RVA: 0x2558540
        public void IsFinished(){} // RVA: 0x2558550
        public void IsBuffering(){} // RVA: 0xB43320
        public void GetDuration(){} // RVA: 0x25585A0
        public void GetVideoWidth(){} // RVA: 0x25585B0
        public void GetVideoHeight(){} // RVA: 0x2540E90
        public void GetVideoDisplayRate(){} // RVA: 0x13CD2F0
        public void GetTexture(){} // RVA: 0xBC5B30
        public void GetTextureFrameCount(){} // RVA: 0x25585C0
        public void InternalGetTextureStereoPacking(){} // RVA: 0xFE6B70
        public void RequiresVerticalFlip(){} // RVA: 0xB43320
        public void Seek(){} // RVA: 0x25585D0
        public void SeekFast(){} // RVA: 0x25585D0
        public void GetCurrentTime(){} // RVA: 0x25585E0
        public void SetPlaybackRate(){} // RVA: 0xB63BB0
        public void GetPlaybackRate(){} // RVA: 0xB63BA0
        public void MuteAudio(){} // RVA: 0xB43310
        public void IsMuted(){} // RVA: 0xC2E4C0
        public void SetVolume(){} // RVA: 0xB63B90
        public void GetVolume(){} // RVA: 0xB63B80
        public void GetVideoFrameRate(){} // RVA: 0x13CD2E0
        public void Update(){} // RVA: 0x25585F0
        public void Render(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void InternalSetActiveTrack(){} // RVA: 0xB43320
        public void InternalIsChangedTracks(){} // RVA: 0xB43320
        public void InternalGetTrackCount(){} // RVA: 0xDAC980
        public void InternalGetTrackInfo(){} // RVA: 0xDAC980
        public void InternalIsChangedTextCue(){} // RVA: 0xB43320
        public void InternalGetCurrentTextCue(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x25588E0
    }

    public class OptionsAppleExtensions : Object
    {
        // ── Methods ──
        public void GenerateMipmaps(){} // RVA: 0x2548670
        public void SetGenerateMipMaps(){} // RVA: 0x2548680
        public void AllowExternalPlayback(){} // RVA: 0x25486A0
        public void SetAllowExternalPlayback(){} // RVA: 0x25486B0
        public void PlayWithoutBuffering(){} // RVA: 0x25486D0
        public void SetPlayWithoutBuffering(){} // RVA: 0x25486E0
        public void UseSinglePlayerItem(){} // RVA: 0x2548700
        public void SetUseSinglePlayerItem(){} // RVA: 0x2548710
        public void ResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x2548730
        public void SetResumePlaybackAfterAudioSessionRouteChange(){} // RVA: 0x2548740
    }

    public class PlaybackQualityStats : Object
    {
        // ── Methods ──
        public void get_SkippedFrames(){} // RVA: 0xB8F8F0
        public void set_SkippedFrames(){} // RVA: 0xB460A0
        public void get_DuplicateFrames(){} // RVA: 0x116A650
        public void set_DuplicateFrames(){} // RVA: 0x116BB10
        public void get_UnityDroppedFrames(){} // RVA: 0xE62D00
        public void set_UnityDroppedFrames(){} // RVA: 0x1033F40
        public void get_PerfectFramesT(){} // RVA: 0xC152D0
        public void set_PerfectFramesT(){} // RVA: 0xC152E0
        public void get_VSyncStatus(){} // RVA: 0xB700F0
        public void set_VSyncStatus(){} // RVA: 0xB70100
        public void get_PerfectFrames(){} // RVA: 0x1065D50
        public void set_PerfectFrames(){} // RVA: 0x13233D0
        public void get_TotalFrames(){} // RVA: 0x1AE5AC0
        public void set_TotalFrames(){} // RVA: 0x23E55F0
        public void get_LogIssues(){} // RVA: 0xB68DF0
        public void set_LogIssues(){} // RVA: 0xB68E00
        public void Reset(){} // RVA: 0x2557440
        public void Start(){} // RVA: 0x2557490
        public void Update(){} // RVA: 0x2557A80
        public void IsGameViewVSyncEnabled(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PlaylistMediaPlayer : MediaPlayer
    {
        // ── Methods ──
        public void get_CurrentPlayer(){} // RVA: 0x2548A40
        public void get_NextPlayer(){} // RVA: 0x1667A40
        public void get_Playlist(){} // RVA: 0x136ECA0
        public void get_PlaylistIndex(){} // RVA: 0x2548B90
        public void get_PlaylistItem(){} // RVA: 0x2548BA0
        public void get_DefaultTransition(){} // RVA: 0x2548C90
        public void set_DefaultTransition(){} // RVA: 0x2548CA0
        public void get_DefaultTransitionDuration(){} // RVA: 0x2548CB0
        public void set_DefaultTransitionDuration(){} // RVA: 0x2548CC0
        public void get_DefaultTransitionEasing(){} // RVA: 0x2548CD0
        public void set_DefaultTransitionEasing(){} // RVA: 0x2548CE0
        public void get_AutoCloseVideo(){} // RVA: 0x1B900A0
        public void set_AutoCloseVideo(){} // RVA: 0x2548CF0
        public void get_LoopMode(){} // RVA: 0x2548D00
        public void set_LoopMode(){} // RVA: 0x2548D10
        public void get_AutoProgress(){} // RVA: 0x2548D20
        public void set_AutoProgress(){} // RVA: 0x2548D30
        public void get_Info(){} // RVA: 0x2548D40
        public void get_Control(){} // RVA: 0x2548E50
        public void get_TextureProducer(){} // RVA: 0x2303260
        public void get_AudioVolume(){} // RVA: 0x2548F60
        public void set_AudioVolume(){} // RVA: 0x2548F70
        public void get_AudioMuted(){} // RVA: 0x25490D0
        public void set_AudioMuted(){} // RVA: 0x25490E0
        public void Play(){} // RVA: 0x2549220
        public void Pause(){} // RVA: 0x2549340
        public void Stop(){} // RVA: 0x2549450
        public void IsPaused(){} // RVA: 0x2549560
        public void SwapPlayers(){} // RVA: 0x2549570
        public void GetCurrentPlayerTexture(){} // RVA: 0x2549610
        public void GetNextTexture(){} // RVA: 0x2549790
        public void Awake(){} // RVA: 0x25498F0
        public void OnDestroy(){} // RVA: 0x2549C90
        public void Start(){} // RVA: 0x254A080
        public void OnMediaPlayerEvent(){} // RVA: 0x254A2E0
        public void PrevItem(){} // RVA: 0x254A6B0
        public void NextItem(){} // RVA: 0x254A6C0
        public void CanJumpToItem(){} // RVA: 0x254A740
        public void JumpToItem(){} // RVA: 0x254A820
        public void OpenVideoFile(){} // RVA: 0x254A9F0
        public void IsTransitioning(){} // RVA: 0x254ADB0
        public void SetTransition(){} // RVA: 0x254ADD0
        public void Update(){} // RVA: 0x254AF50
        public void GetTexture(){} // RVA: 0x254B5D0
        public void GetTextureCount(){} // RVA: 0x254B6C0
        public void GetTextureFrameCount(){} // RVA: 0x254B770
        public void SupportsTextureFrameCount(){} // RVA: 0x254B820
        public void GetTextureTimeStamp(){} // RVA: 0x254B8D0
        public void GetTexturePixelAspectRatio(){} // RVA: 0x254B980
        public void RequiresVerticalFlip(){} // RVA: 0x254BA30
        public void GetYpCbCrTransform(){} // RVA: 0x254BAE0
        public void GetTextureStereoPacking(){} // RVA: 0x254BC20
        public void GetTextureTransparency(){} // RVA: 0x254BCD0
        public void GetTextureAlphaPacking(){} // RVA: 0x254BD80
        public void GetAffineTransform(){} // RVA: 0x254BE30
        public void GetTextureMatrix(){} // RVA: 0x254BF20
        public void GetCompatibleRenderTextureFormat(){} // RVA: 0x254C060
        public void GetTransitionName(){} // RVA: 0x254C140
        public void .ctor(){} // RVA: 0x254C460
        public void .cctor(){} // RVA: 0x254C760
    }

    public class Resampler : Object
    {
        // ── Methods ──
        public void get_DroppedFrames(){} // RVA: 0x2536460
        public void get_FrameDisplayedTimer(){} // RVA: 0x23ADD10
        public void get_BaseTimestamp(){} // RVA: 0xD05CA0
        public void set_BaseTimestamp(){} // RVA: 0xE9F6B0
        public void get_ElapsedTimeSinceBase(){} // RVA: 0xD344A0
        public void set_ElapsedTimeSinceBase(){} // RVA: 0xD34230
        public void get_LastT(){} // RVA: 0x119AE70
        public void set_LastT(){} // RVA: 0x119D240
        public void get_TextureTimeStamp(){} // RVA: 0x1069350
        public void set_TextureTimeStamp(){} // RVA: 0x25687F0
        public void OnVideoEvent(){} // RVA: 0x2568800
        public void .ctor(){} // RVA: 0x25688E0
        public void get_OutputTexture(){} // RVA: 0xB700F0
        public void Reset(){} // RVA: 0x2568DA0
        public void Release(){} // RVA: 0x2568DC0
        public void ReleaseRenderTextures(){} // RVA: 0x2568FC0
        public void ConstructRenderTextures(){} // RVA: 0x2569330
        public void CheckRenderTexturesValid(){} // RVA: 0x2569900
        public void FindBeforeFrameIndex(){} // RVA: 0x2569D80
        public void FindClosestFrame(){} // RVA: 0x2569FE0
        public void PointUpdate(){} // RVA: 0x256A1E0
        public void SampleFrame(){} // RVA: 0x256A3A0
        public void SampleFrames(){} // RVA: 0x256A530
        public void LinearUpdate(){} // RVA: 0x256A830
        public void InvalidateBuffer(){} // RVA: 0x256AA50
        public void GuessFrameRate(){} // RVA: 0x256AB60
        public void Update(){} // RVA: 0x256AE30
        public void UpdateTimestamp(){} // RVA: 0x256BAE0
    }

    public class ResolveToRenderTexture : MonoBehaviour
    {
        // ── Methods ──
        public void get_MediaPlayer(){} // RVA: 0xB700F0
        public void set_MediaPlayer(){} // RVA: 0x254D440
        public void get_VideoResolveOptions(){} // RVA: 0x254D5E0
        public void set_VideoResolveOptions(){} // RVA: 0x254D600
        public void get_ExternalTexture(){} // RVA: 0xBE2C60
        public void set_ExternalTexture(){} // RVA: 0xBE2C70
        public void get_TargetTexture(){} // RVA: 0x254D620
        public void SetMaterialDirty(){} // RVA: 0xCFCE00
        public void ChangeMediaPlayer(){} // RVA: 0x254D440
        public void Start(){} // RVA: 0x254D700
        public void LateUpdate(){} // RVA: 0x254D980
        public void Resolve(){} // RVA: 0x254D990
        public void OnDisable(){} // RVA: 0x254E150
        public void OnDestroy(){} // RVA: 0x254E300
        public void .ctor(){} // RVA: 0x254E480
    }

    public class Subtitle : Object
    {
        // ── Methods ──
        public void IsBefore(){} // RVA: 0x256BB00
        public void IsTime(){} // RVA: 0x256BB20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubtitlePlayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubtitleUtils : Object
    {
        // ── Methods ──
        public void ParseTimeToSeconds(){} // RVA: 0x256BB40
        public void ParseSubtitlesSRT(){} // RVA: 0x256BCF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Subtitle[] : Array
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

    public class SubtitlesUGUI : MonoBehaviour
    {
        // ── Methods ──
        public void set_Player(){} // RVA: 0x2534C80
        public void get_Player(){} // RVA: 0xB700F0
        public void set_Text(){} // RVA: 0xB44DC0
        public void get_Text(){} // RVA: 0xB70160
        public void Start(){} // RVA: 0x2534C90
        public void OnDestroy(){} // RVA: 0x2534CA0
        public void Update(){} // RVA: 0x2534CB0
        public void ChangeMediaPlayer(){} // RVA: 0x2534CC0
        public void SetText(){} // RVA: 0x2535000
        public void PrepareText(){} // RVA: 0x2535040
        public void UpdateBackgroundRect(){} // RVA: 0x2535190
        public void OnMediaPlayerEvent(){} // RVA: 0x2535440
        public void .ctor(){} // RVA: 0x2535660
    }

    public class TextCue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Text(){} // RVA: 0xB5DBF0
        public void set_Text(){} // RVA: 0xB44D60
    }

    public class TextTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x25671D0
    }

    public class TextTrack[] : Array
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

    public class TextTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0xC50A80
        public void .ctor(){} // RVA: 0x2567120
    }

    public class TimeRange : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84FE0
        public void get_StartTime(){} // RVA: 0x84FF0
        public void get_EndTime(){} // RVA: 0x85000
        public void get_Duration(){} // RVA: 0x85010
    }

    public class TimeRange[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E74810
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TimeRanges : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x25571C0
        public void GetEnumerator(){} // RVA: 0x2556F20
        public void get_Item(){} // RVA: 0x2556F40
        public void ToString(){} // RVA: 0x2556F80
        public void CalculateRange(){} // RVA: 0x25572C0
        public void get_Count(){} // RVA: 0x17F0080
        public void get_MinTime(){} // RVA: 0x22344D0
        public void get_MaxTime(){} // RVA: 0x22F9F60
        public void get_Duration(){} // RVA: 0x2557430
    }

    public class TimedMetadataItem : Object
    {
        // ── Methods ──
        public void get_PresentationTime(){} // RVA: 0x2566C50
        public void get_Text(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TrackBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2566CC0
        public void get_Uid(){} // RVA: 0xB8F8F0
        public void set_Uid(){} // RVA: 0xB460A0
        public void get_TrackType(){} // RVA: 0x116A650
        public void set_TrackType(){} // RVA: 0x116BB10
        public void get_DisplayName(){} // RVA: 0xB465B0
        public void set_DisplayName(){} // RVA: 0xBA9BA0
        public void get_Name(){} // RVA: 0xB700F0
        public void set_Name(){} // RVA: 0xB70100
        public void get_Language(){} // RVA: 0xB70160
        public void set_Language(){} // RVA: 0xB44DC0
        public void get_IsDefault(){} // RVA: 0xB68DF0
        public void set_IsDefault(){} // RVA: 0xB68E00
        public void CreateDisplayName(){} // RVA: 0x2566F40
    }

    public class TrackCollection : Object
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0xB8F8F0
        public void set_TrackType(){} // RVA: 0xB460A0
        public void get_Count(){} // RVA: 0x87C130
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void GetTrackArrayIndexFromUid(){} // RVA: 0x881C20
        public void Clear(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x894320
        public void HasActiveTrack(){} // RVA: 0x87D280
        public void IsActiveTrack(){} // RVA: 0x87D350
        public void SetActiveTrack(){} // RVA: 0x894320
        public void SetFirstTrackActive(){} // RVA: 0x894290
        public void GetActiveTrackIndex(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TrackCollection[] : Array
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

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA94080
        public void get_ActiveTrack(){} // RVA: 0xA94080
        public void set_ActiveTrack(){} // RVA: 0xA94080
        public void HasActiveTrack(){} // RVA: 0x87D280
        public void IsActiveTrack(){} // RVA: 0x87D350
        public void GetTrackArrayIndexFromUid(){} // RVA: 0x881C20
        public void Clear(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x894320
        public void SetActiveTrack(){} // RVA: 0x894320
        public void SetFirstTrackActive(){} // RVA: 0x894290
        public void GetActiveTrackIndex(){} // RVA: 0x87C130
        public void get_Count(){} // RVA: 0x87C130
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F20260
        public void GetEnumerator(){} // RVA: 0x4F203A0
        public void get_Item(){} // RVA: 0x4F20470
        public void get_ActiveTrack(){} // RVA: 0xB465B0
        public void set_ActiveTrack(){} // RVA: 0xBA9BA0
        public void HasActiveTrack(){} // RVA: 0x25E9250
        public void IsActiveTrack(){} // RVA: 0x4F204C0
        public void GetTrackArrayIndexFromUid(){} // RVA: 0x4F204D0
        public void Clear(){} // RVA: 0x4F20620
        public void Add(){} // RVA: 0x4F206B0
        public void SetActiveTrack(){} // RVA: 0x4F20770
        public void SetFirstTrackActive(){} // RVA: 0x4F20800
        public void GetActiveTrackIndex(){} // RVA: 0x4F20890
        public void get_Count(){} // RVA: 0x4F208B0
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F20260
        public void GetEnumerator(){} // RVA: 0x4F203A0
        public void get_Item(){} // RVA: 0x4F20470
        public void get_ActiveTrack(){} // RVA: 0xB465B0
        public void set_ActiveTrack(){} // RVA: 0xBA9BA0
        public void HasActiveTrack(){} // RVA: 0x25E9250
        public void IsActiveTrack(){} // RVA: 0x4F204C0
        public void GetTrackArrayIndexFromUid(){} // RVA: 0x4F204D0
        public void Clear(){} // RVA: 0x4F20620
        public void Add(){} // RVA: 0x4F206B0
        public void SetActiveTrack(){} // RVA: 0x4F20770
        public void SetFirstTrackActive(){} // RVA: 0x4F20800
        public void GetActiveTrackIndex(){} // RVA: 0x4F20890
        public void get_Count(){} // RVA: 0x4F208B0
    }

    public class TrackCollection`1 : TrackCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F20260
        public void GetEnumerator(){} // RVA: 0x4F203A0
        public void get_Item(){} // RVA: 0x4F20470
        public void get_ActiveTrack(){} // RVA: 0xB465B0
        public void set_ActiveTrack(){} // RVA: 0xBA9BA0
        public void HasActiveTrack(){} // RVA: 0x25E9250
        public void IsActiveTrack(){} // RVA: 0x4F204C0
        public void GetTrackArrayIndexFromUid(){} // RVA: 0x4F204D0
        public void Clear(){} // RVA: 0x4F20620
        public void Add(){} // RVA: 0x4F206B0
        public void SetActiveTrack(){} // RVA: 0x4F20770
        public void SetFirstTrackActive(){} // RVA: 0x4F20800
        public void GetActiveTrackIndex(){} // RVA: 0x4F20890
        public void get_Count(){} // RVA: 0x4F208B0
    }

    public class UpdateMultiPassStereo : MonoBehaviour
    {
        // ── Methods ──
        public void get_Camera(){} // RVA: 0xB700F0
        public void set_Camera(){} // RVA: 0xB70100
        public void Awake(){} // RVA: 0x254E550
        public void Start(){} // RVA: 0x254E660
        public void LogXRDeviceDetails(){} // RVA: 0x254E670
        public void IsMultiPassVrEnabled(){} // RVA: 0x254EAF0
        public void LateUpdate(){} // RVA: 0x254EB90
        public void .ctor(){} // RVA: 0xB43D60
        public void .cctor(){} // RVA: 0x254F3A0
    }

    public class Variant : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2570340
        public void get_Id(){} // RVA: 0xB8F8F0
        public void get_Width(){} // RVA: 0x116A650
        public void get_Height(){} // RVA: 0xE62D00
        public void get_PeakDataRate(){} // RVA: 0x2244FB0
        public void get_AverageDataRate(){} // RVA: 0xFEAE90
        public void get_FrameRate(){} // RVA: 0xC27360
        public void get_VideoRange(){} // RVA: 0x1AE5AC0
        public void get_VideoCodecType(){} // RVA: 0x15AF000
        public void get_IsUnsupported(){} // RVA: 0x2570390
        public void get_VideoCodecName(){} // RVA: 0x25703A0
        public void get_AudioCodecType(){} // RVA: 0xB9E080
        public void get_AudioCodecName(){} // RVA: 0x25704A0
        public void get_Auto(){} // RVA: 0x25705A0
        public void .cctor(){} // RVA: 0x2570600
    }

    public class Variant[] : Array
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

    public class VideoRender : Object
    {
        // ── Methods ──
        public void CreateResolveMaterial(){} // RVA: 0x256C2A0
        public void CreateIMGUIMaterial(){} // RVA: 0x256C340
        public void SetupLayoutMaterial(){} // RVA: 0x256C3C0
        public void SetupStereoEyeModeMaterial(){} // RVA: 0x256C470
        public void SetupStereoMaterial(){} // RVA: 0x256C5C0
        public void SetupGlobalDebugStereoTinting(){} // RVA: 0x256C890
        public void SetupAlphaPackedMaterial(){} // RVA: 0x256C8E0
        public void SetupGammaMaterial(){} // RVA: 0x256CA30
        public void SetupTextureMatrix(){} // RVA: 0x256CE00
        public void SetupVerticalFlipMaterial(){} // RVA: 0x256CF60
        public void GetTexture(){} // RVA: 0x256D010
        public void SetupMaterialForMedia(){} // RVA: 0x256D1D0
        public void SetupMaterial(){} // RVA: 0x256D8C0
        public void SetupResolveMaterial(){} // RVA: 0x256DEA0
        public void ResolveVideoToRenderTexture(){} // RVA: 0x256E190
        public void GetResolveTextureSize(){} // RVA: 0x256EAF0
        public void RequiresResolve(){} // RVA: 0x256ECA0
        public void DrawTexture(){} // RVA: 0x256ED50
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x256F4C0
    }

    public class VideoResolveOptions : ValueType
    {
        // ── Methods ──
        public void IsColourAdjust(){} // RVA: 0x84F50
        public void ResetColourAdjust(){} // RVA: 0x84FB0
        public void Create(){} // RVA: 0x2556DE0
    }

    public class VideoTrack : TrackBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2567160
        public void get_Bitrate(){} // RVA: 0x18A0130
        public void set_Bitrate(){} // RVA: 0x189D3F0
    }

    public class VideoTrack[] : Array
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

    public class VideoTracks : TrackCollection`1
    {
        // ── Methods ──
        public void get_TrackType(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x25670A0
    }

    public class WindowsMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void InitialisePlatform(){} // RVA: 0x2558C80
        public void DeinitPlatform(){} // RVA: 0x2559150
        public void GetAudioChannelCount(){} // RVA: 0x2559200
        public void GetAudioChannelMask(){} // RVA: 0x2559280
        public void .ctor(){} // RVA: 0x2559540
        public void SetOptions(){} // RVA: 0x25598E0
        public void GetVersion(){} // RVA: 0x2559C20
        public void GetExpectedVersion(){} // RVA: 0x2559C80
        public void UseNativeMips(){} // RVA: 0x2559CC0
        public void OpenMedia(){} // RVA: 0x2559CD0
        public void OpenMediaFromBuffer(){} // RVA: 0x255A700
        public void StartOpenMediaFromBuffer(){} // RVA: 0x255AC10
        public void AddChunkToMediaBuffer(){} // RVA: 0x255ACE0
        public void EndOpenMediaFromBuffer(){} // RVA: 0x255ADA0
        public void DisplayLoadFailureSuggestion(){} // RVA: 0x255B220
        public void CloseMedia(){} // RVA: 0x255B370
        public void SetLooping(){} // RVA: 0x255B500
        public void IsLooping(){} // RVA: 0x255B520
        public void HasMetaData(){} // RVA: 0x1DFD090
        public void HasAudio(){} // RVA: 0x1FDB9C0
        public void HasVideo(){} // RVA: 0x2443DE0
        public void CanPlay(){} // RVA: 0x255B530
        public void Play(){} // RVA: 0x255B540
        public void Pause(){} // RVA: 0x255B5D0
        public void Stop(){} // RVA: 0x255B660
        public void IsSeeking(){} // RVA: 0x255B680
        public void IsPlaying(){} // RVA: 0x255B710
        public void IsPaused(){} // RVA: 0x255B720
        public void IsFinished(){} // RVA: 0x255B760
        public void IsBuffering(){} // RVA: 0x255B810
        public void GetDuration(){} // RVA: 0x255B8A0
        public void GetVideoWidth(){} // RVA: 0x255B920
        public void GetVideoHeight(){} // RVA: 0x255B930
        public void GetVideoFrameRate(){} // RVA: 0x255B940
        public void GetTexture(){} // RVA: 0x255B950
        public void GetTextureFrameCount(){} // RVA: 0x255BA60
        public void GetTextureTimeStamp(){} // RVA: 0x255BA70
        public void GetTexturePixelAspectRatio(){} // RVA: 0x255BAF0
        public void RequiresVerticalFlip(){} // RVA: 0x2444110
        public void InternalGetTextureStereoPacking(){} // RVA: 0x255BBA0
        public void Seek(){} // RVA: 0x255BC70
        public void SeekFast(){} // RVA: 0x255BC90
        public void GetCurrentTime(){} // RVA: 0x255BCB0
        public void SetPlaybackRate(){} // RVA: 0x255BD30
        public void GetPlaybackRate(){} // RVA: 0x255BD50
        public void MuteAudio(){} // RVA: 0x255BD60
        public void IsMuted(){} // RVA: 0x255BDF0
        public void SetVolume(){} // RVA: 0x255BE00
        public void GetVolume(){} // RVA: 0x255BE20
        public void SetBalance(){} // RVA: 0x255BE30
        public void GetBalance(){} // RVA: 0x255BED0
        public void IsPlaybackStalled(){} // RVA: 0x255BEE0
        public void WaitForNextFrame(){} // RVA: 0x255BF90
        public void SetAudioChannelMode(){} // RVA: 0x255C1E0
        public void SetAudioHeadRotation(){} // RVA: 0x255C270
        public void ResetAudioHeadRotation(){} // RVA: 0x255C2B0
        public void SetAudioFocusEnabled(){} // RVA: 0x255C3D0
        public void SetAudioFocusProperties(){} // RVA: 0x255C3E0
        public void SetAudioFocusRotation(){} // RVA: 0x255C3F0
        public void ResetAudioFocus(){} // RVA: 0x255C430
        public void Update(){} // RVA: 0x255C4A0
        public void ReleaseTexture(){} // RVA: 0x255CCD0
        public void UpdateTexture(){} // RVA: 0x255CFD0
        public void EndUpdate(){} // RVA: 0x255D7C0
        public void GetLastExtendedErrorCode(){} // RVA: 0x255D840
        public void OnTextureSizeChanged(){} // RVA: 0xB43310
        public void BeginRender(){} // RVA: 0x255D8C0
        public void Render(){} // RVA: 0x255D910
        public void Dispose(){} // RVA: 0xB43310
        public void GrabAudio(){} // RVA: 0x255D970
        public void GetAudioBufferedSampleCount(){} // RVA: 0x255DA30
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0x255DAB0
        public void GetDecoderPerformance(){} // RVA: 0x255DAC0
        public void IssueRenderThreadEvent(){} // RVA: 0x255DB70
        public void GetPluginVersion(){} // RVA: 0x255DC90
        public void InternalSetActiveTrack(){} // RVA: 0x255DD60
        public void InternalIsChangedTextCue(){} // RVA: 0x255DE10
        public void InternalGetCurrentTextCue(){} // RVA: 0x255DEA0
        public void InternalIsChangedTracks(){} // RVA: 0x255DF70
        public void InternalGetTrackCount(){} // RVA: 0x255E010
        public void InternalGetTrackInfo(){} // RVA: 0x255E0B0
        public void get_AuthenticationData(){} // RVA: 0xBAE8F0
        public void set_AuthenticationData(){} // RVA: 0x255E520
        public void SetKeyServerAuthToken(){} // RVA: 0x255E590
        public void SetOverrideDecryptionKey(){} // RVA: 0x255E610
        public void UpdateTimeRanges(){} // RVA: 0x255E690
        public void UpdateTimeRange(){} // RVA: 0x255E700
        public void .cctor(){} // RVA: 0x255E810
    }

    public class WindowsRtMediaPlayer : BaseMediaPlayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2561DC0
        public void SetOptions(){} // RVA: 0x25620C0
        public void CanPlay(){} // RVA: 0x25620F0
        public void Dispose(){} // RVA: 0x2562110
        public void PlayerSupportsLinearColorSpace(){} // RVA: 0xB43320
        public void GetCurrentTime(){} // RVA: 0x2562290
        public void GetDuration(){} // RVA: 0x2562310
        public void GetPlaybackRate(){} // RVA: 0x2562320
        public void GetTexture(){} // RVA: 0x25623A0
        public void GetTextureCount(){} // RVA: 0x25623F0
        public void GetTextureFrameCount(){} // RVA: 0x131DCD0
        public void InternalGetTextureStereoPacking(){} // RVA: 0x2562500
        public void GetVersion(){} // RVA: 0x25625D0
        public void GetExpectedVersion(){} // RVA: 0x2562630
        public void GetVideoFrameRate(){} // RVA: 0x2562670
        public void GetVideoWidth(){} // RVA: 0x2562720
        public void GetVideoHeight(){} // RVA: 0x2562860
        public void GetVolume(){} // RVA: 0x25629A0
        public void SetBalance(){} // RVA: 0x25629B0
        public void GetBalance(){} // RVA: 0x2562A40
        public void HasAudio(){} // RVA: 0x2562AC0
        public void HasMetaData(){} // RVA: 0x2562B00
        public void HasVideo(){} // RVA: 0x2562B30
        public void IsBuffering(){} // RVA: 0x2562B70
        public void IsFinished(){} // RVA: 0x2562B90
        public void IsLooping(){} // RVA: 0x2558540
        public void IsMuted(){} // RVA: 0x2562C40
        public void IsPaused(){} // RVA: 0x2562CD0
        public void IsPlaying(){} // RVA: 0x2562CF0
        public void IsSeeking(){} // RVA: 0x2562D10
        public void MuteAudio(){} // RVA: 0x2562D30
        public void OpenMedia(){} // RVA: 0x2562DC0
        public void CloseMedia(){} // RVA: 0x2562FF0
        public void Pause(){} // RVA: 0x25630A0
        public void Play(){} // RVA: 0x2563120
        public void Render(){} // RVA: 0x25631A0
        public void Update_Textures(){} // RVA: 0x2563220
        public void get_AuthenticationData(){} // RVA: 0xCA4D80
        public void set_AuthenticationData(){} // RVA: 0x2563740
        public void RequiresVerticalFlip(){} // RVA: 0xC2E4C0
        public void Seek(){} // RVA: 0x25637B0
        public void SeekFast(){} // RVA: 0x25512C0
        public void SetLooping(){} // RVA: 0x2563840
        public void SetPlaybackRate(){} // RVA: 0x2563860
        public void SetVolume(){} // RVA: 0x25638F0
        public void Stop(){} // RVA: 0x255B660
        public void UpdateTimeRanges(){} // RVA: 0x2563910
        public void UpdateTimeRange(){} // RVA: 0x2563980
        public void GetProgramDateTime(){} // RVA: 0x2563A90
        public void Update(){} // RVA: 0x2563C90
        public void SetKeyServerAuthToken(){} // RVA: 0x2564170
        public void SetOverrideDecryptionKey(){} // RVA: 0x25641F0
        public void InternalSetActiveTrack(){} // RVA: 0x2564270
        public void InternalIsChangedTracks(){} // RVA: 0x2564310
        public void InternalGetTrackCount(){} // RVA: 0x25643A0
        public void InternalGetTrackInfo(){} // RVA: 0x2564430
        public void InternalIsChangedTextCue(){} // RVA: 0x2564830
        public void InternalGetCurrentTextCue(){} // RVA: 0x25648C0
        public void InitialisePlatform(){} // RVA: 0x2564990
        public void DeinitPlatform(){} // RVA: 0x2564D10
        public void .cctor(){} // RVA: 0x2564D70
    }

}