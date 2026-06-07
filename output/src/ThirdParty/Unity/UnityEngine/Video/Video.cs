// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Video
// Classes: 2
// Methods: 120

namespace ThirdParty.Unity.UnityEngine.Video
{
    public class VideoClip
    {
        public object source;
        public object timeUpdateMode;
        public object url;
        public object clip;
        public object renderMode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75017E0
        public void get_originalPath(){} // RVA: 0x7501830
        public void get_frameRate(){} // RVA: 0x7501880
        public void get_length(){} // RVA: 0x75018D0
        public void get_width(){} // RVA: 0x7501920
        public void get_height(){} // RVA: 0x7501970
    }

    public class VideoPlayer
    {
        // ── Methods ──
        public void get_source(){} // RVA: 0x75019C0
        public void set_source(){} // RVA: 0x7501A10
        public void get_timeUpdateMode(){} // RVA: 0x7501A70
        public void set_timeUpdateMode(){} // RVA: 0x7501AC0
        public void get_url(){} // RVA: 0x7501B20
        public void set_url(){} // RVA: 0x7501B70
        public void get_clip(){} // RVA: 0x7501BD0
        public void set_clip(){} // RVA: 0x7501C20
        public void get_renderMode(){} // RVA: 0x7501C80
        public void set_renderMode(){} // RVA: 0x7501CD0
        public void get_canSetTimeUpdateMode(){} // RVA: 0x7501D30
        public void get_targetCamera(){} // RVA: 0x7501D80
        public void set_targetCamera(){} // RVA: 0x7501DD0
        public void get_targetTexture(){} // RVA: 0x7501E30
        public void set_targetTexture(){} // RVA: 0x7501E80
        public void get_targetMaterialRenderer(){} // RVA: 0x7501EE0
        public void set_targetMaterialRenderer(){} // RVA: 0x7501F30
        public void get_targetMaterialProperty(){} // RVA: 0x7501F90
        public void set_targetMaterialProperty(){} // RVA: 0x7501FE0
        public void get_aspectRatio(){} // RVA: 0x7502040
        public void set_aspectRatio(){} // RVA: 0x7502090
        public void get_targetCameraAlpha(){} // RVA: 0x75020F0
        public void set_targetCameraAlpha(){} // RVA: 0x7502140
        public void get_targetCamera3DLayout(){} // RVA: 0x75021A0
        public void set_targetCamera3DLayout(){} // RVA: 0x75021F0
        public void get_texture(){} // RVA: 0x7502250
        public void Prepare(){} // RVA: 0x75022A0
        public void get_isPrepared(){} // RVA: 0x75022F0
        public void get_waitForFirstFrame(){} // RVA: 0x7502340
        public void set_waitForFirstFrame(){} // RVA: 0x7502390
        public void get_playOnAwake(){} // RVA: 0x75023F0
        public void set_playOnAwake(){} // RVA: 0x7502440
        public void Play(){} // RVA: 0x75024A0
        public void Pause(){} // RVA: 0x75024F0
        public void Stop(){} // RVA: 0x7502540
        public void get_isPlaying(){} // RVA: 0x7502590
        public void get_isPaused(){} // RVA: 0x75025E0
        public void get_canSetTime(){} // RVA: 0x7502630
        public void get_time(){} // RVA: 0x7502680
        public void set_time(){} // RVA: 0x75026D0
        public void get_frame(){} // RVA: 0x7502730
        public void set_frame(){} // RVA: 0x7502780
        public void get_clockTime(){} // RVA: 0x75027E0
        public void get_canStep(){} // RVA: 0x7502830
        public void StepForward(){} // RVA: 0x7502880
        public void get_canSetPlaybackSpeed(){} // RVA: 0x75028D0
        public void get_playbackSpeed(){} // RVA: 0x7502920
        public void set_playbackSpeed(){} // RVA: 0x7502970
        public void get_isLooping(){} // RVA: 0x75029D0
        public void set_isLooping(){} // RVA: 0x7502A20
        public void get_canSetTimeSource(){} // RVA: 0x7502A80
        public void get_timeSource(){} // RVA: 0x7502AD0
        public void set_timeSource(){} // RVA: 0x7502B20
        public void get_timeReference(){} // RVA: 0x7502B80
        public void set_timeReference(){} // RVA: 0x7502BD0
        public void get_externalReferenceTime(){} // RVA: 0x7502C30
        public void set_externalReferenceTime(){} // RVA: 0x7502C80
        public void get_canSetSkipOnDrop(){} // RVA: 0x7502CE0
        public void get_skipOnDrop(){} // RVA: 0x7502D30
        public void set_skipOnDrop(){} // RVA: 0x7502D80
        public void get_frameCount(){} // RVA: 0x7502DE0
        public void get_frameRate(){} // RVA: 0x7502E30
        public void get_length(){} // RVA: 0x7502E80
        public void get_width(){} // RVA: 0x7502ED0
        public void get_height(){} // RVA: 0x7502F20
        public void get_pixelAspectRatioNumerator(){} // RVA: 0x7502F70
        public void get_pixelAspectRatioDenominator(){} // RVA: 0x7502FC0
        public void get_audioTrackCount(){} // RVA: 0x7503010
        public void GetAudioLanguageCode(){} // RVA: 0x7503060
        public void GetAudioChannelCount(){} // RVA: 0x75030C0
        public void GetAudioSampleRate(){} // RVA: 0x7503120
        public void get_controlledAudioTrackMaxCount(){} // RVA: 0x7503180
        public void get_controlledAudioTrackCount(){} // RVA: 0x75031D0
        public void set_controlledAudioTrackCount(){} // RVA: 0x7503220
        public void GetControlledAudioTrackCount(){} // RVA: 0x75031D0
        public void SetControlledAudioTrackCount(){} // RVA: 0x7503360
        public void EnableAudioTrack(){} // RVA: 0x75033C0
        public void IsAudioTrackEnabled(){} // RVA: 0x7503430
        public void get_audioOutputMode(){} // RVA: 0x7503490
        public void set_audioOutputMode(){} // RVA: 0x75034E0
        public void get_canSetDirectAudioVolume(){} // RVA: 0x7503540
        public void GetDirectAudioVolume(){} // RVA: 0x7503590
        public void SetDirectAudioVolume(){} // RVA: 0x75035F0
        public void GetDirectAudioMute(){} // RVA: 0x7503660
        public void SetDirectAudioMute(){} // RVA: 0x75036C0
        public void GetTargetAudioSource(){} // RVA: 0x7503730
        public void SetTargetAudioSource(){} // RVA: 0x7503790
        public void add_prepareCompleted(){} // RVA: 0x7503800
        public void remove_prepareCompleted(){} // RVA: 0x75038F0
        public void add_loopPointReached(){} // RVA: 0x75039E0
        public void remove_loopPointReached(){} // RVA: 0x7503AD0
        public void add_started(){} // RVA: 0x7503BC0
        public void remove_started(){} // RVA: 0x7503CB0
        public void add_frameDropped(){} // RVA: 0x7503DA0
        public void remove_frameDropped(){} // RVA: 0x7503E90
        public void add_errorReceived(){} // RVA: 0x7503F80
        public void remove_errorReceived(){} // RVA: 0x7504070
        public void add_seekCompleted(){} // RVA: 0x7504160
        public void remove_seekCompleted(){} // RVA: 0x7504250
        public void add_clockResyncOccurred(){} // RVA: 0x7504340
        public void remove_clockResyncOccurred(){} // RVA: 0x7504430
        public void get_sendFrameReadyEvents(){} // RVA: 0x7504520
        public void set_sendFrameReadyEvents(){} // RVA: 0x7504570
        public void add_frameReady(){} // RVA: 0x75045D0
        public void remove_frameReady(){} // RVA: 0x75046C0
        public void InvokePrepareCompletedCallback_Internal(){} // RVA: 0x75047B0
        public void InvokeFrameReadyCallback_Internal(){} // RVA: 0x75047F0
        public void InvokeLoopPointReachedCallback_Internal(){} // RVA: 0x7504830
        public void InvokeStartedCallback_Internal(){} // RVA: 0x7504870
        public void InvokeFrameDroppedCallback_Internal(){} // RVA: 0x75048B0
        public void InvokeErrorReceivedCallback_Internal(){} // RVA: 0x75048F0
        public void InvokeSeekCompletedCallback_Internal(){} // RVA: 0x7504930
        public void InvokeClockResyncOccurredCallback_Internal(){} // RVA: 0x7504970
        public void .ctor(){} // RVA: 0x2DDD50
    }

}