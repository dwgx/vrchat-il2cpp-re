// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Video
// Classes: 2
// Methods: 120

namespace ThirdParty.Unity.UnityEngine.Video
{
    public class VideoClip : Object
    {
        public object originalPath;
        public object frameRate;
        public object length;
        public object width;
        public object height;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C99160
        public void get_originalPath(){} // RVA: 0x7FFAC9C991B0
        public void get_frameRate(){} // RVA: 0x7FFAC9C99200
        public void get_length(){} // RVA: 0x7FFAC9C99250
        public void get_width(){} // RVA: 0x7FFAC9C992A0
        public void get_height(){} // RVA: 0x7FFAC9C992F0
    }

    public class VideoPlayer : Behaviour
    {
        public EventHandler source; // 0x18
        public EventHandler timeUpdateMode; // 0x20
        public EventHandler url; // 0x28
        public EventHandler clip; // 0x30
        public ErrorEventHandler renderMode; // 0x38
        public EventHandler canSetTimeUpdateMode; // 0x40
        public TimeEventHandler targetCamera; // 0x48
        public FrameReadyEventHandler targetTexture; // 0x50

        // ── Methods ──
        public void get_source(){} // RVA: 0x7FFAC9C99340
        public void set_source(){} // RVA: 0x7FFAC9C99390
        public void get_timeUpdateMode(){} // RVA: 0x7FFAC9C993F0
        public void set_timeUpdateMode(){} // RVA: 0x7FFAC9C99440
        public void get_url(){} // RVA: 0x7FFAC9C994A0
        public void set_url(){} // RVA: 0x7FFAC9C994F0
        public void get_clip(){} // RVA: 0x7FFAC9C99550
        public void set_clip(){} // RVA: 0x7FFAC9C995A0
        public void get_renderMode(){} // RVA: 0x7FFAC9C99600
        public void set_renderMode(){} // RVA: 0x7FFAC9C99650
        public void get_canSetTimeUpdateMode(){} // RVA: 0x7FFAC9C996B0
        public void get_targetCamera(){} // RVA: 0x7FFAC9C99700
        public void set_targetCamera(){} // RVA: 0x7FFAC9C99750
        public void get_targetTexture(){} // RVA: 0x7FFAC9C997B0
        public void set_targetTexture(){} // RVA: 0x7FFAC9C99800
        public void get_targetMaterialRenderer(){} // RVA: 0x7FFAC9C99860
        public void set_targetMaterialRenderer(){} // RVA: 0x7FFAC9C998B0
        public void get_targetMaterialProperty(){} // RVA: 0x7FFAC9C99910
        public void set_targetMaterialProperty(){} // RVA: 0x7FFAC9C99960
        public void get_aspectRatio(){} // RVA: 0x7FFAC9C999C0
        public void set_aspectRatio(){} // RVA: 0x7FFAC9C99A10
        public void get_targetCameraAlpha(){} // RVA: 0x7FFAC9C99A70
        public void set_targetCameraAlpha(){} // RVA: 0x7FFAC9C99AC0
        public void get_targetCamera3DLayout(){} // RVA: 0x7FFAC9C99B20
        public void set_targetCamera3DLayout(){} // RVA: 0x7FFAC9C99B70
        public void get_texture(){} // RVA: 0x7FFAC9C99BD0
        public void Prepare(){} // RVA: 0x7FFAC9C99C20
        public void get_isPrepared(){} // RVA: 0x7FFAC9C99C70
        public void get_waitForFirstFrame(){} // RVA: 0x7FFAC9C99CC0
        public void set_waitForFirstFrame(){} // RVA: 0x7FFAC9C99D10
        public void get_playOnAwake(){} // RVA: 0x7FFAC9C99D70
        public void set_playOnAwake(){} // RVA: 0x7FFAC9C99DC0
        public void Play(){} // RVA: 0x7FFAC9C99E20
        public void Pause(){} // RVA: 0x7FFAC9C99E70
        public void Stop(){} // RVA: 0x7FFAC9C99EC0
        public void get_isPlaying(){} // RVA: 0x7FFAC9C99F10
        public void get_isPaused(){} // RVA: 0x7FFAC9C99F60
        public void get_canSetTime(){} // RVA: 0x7FFAC9C99FB0
        public void get_time(){} // RVA: 0x7FFAC9C9A000
        public void set_time(){} // RVA: 0x7FFAC9C9A050
        public void get_frame(){} // RVA: 0x7FFAC9C9A0B0
        public void set_frame(){} // RVA: 0x7FFAC9C9A100
        public void get_clockTime(){} // RVA: 0x7FFAC9C9A160
        public void get_canStep(){} // RVA: 0x7FFAC9C9A1B0
        public void StepForward(){} // RVA: 0x7FFAC9C9A200
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7FFAC9C9A250
        public void get_playbackSpeed(){} // RVA: 0x7FFAC9C9A2A0
        public void set_playbackSpeed(){} // RVA: 0x7FFAC9C9A2F0
        public void get_isLooping(){} // RVA: 0x7FFAC9C9A350
        public void set_isLooping(){} // RVA: 0x7FFAC9C9A3A0
        public void get_canSetTimeSource(){} // RVA: 0x7FFAC9C9A400
        public void get_timeSource(){} // RVA: 0x7FFAC9C9A450
        public void set_timeSource(){} // RVA: 0x7FFAC9C9A4A0
        public void get_timeReference(){} // RVA: 0x7FFAC9C9A500
        public void set_timeReference(){} // RVA: 0x7FFAC9C9A550
        public void get_externalReferenceTime(){} // RVA: 0x7FFAC9C9A5B0
        public void set_externalReferenceTime(){} // RVA: 0x7FFAC9C9A600
        public void get_canSetSkipOnDrop(){} // RVA: 0x7FFAC9C9A660
        public void get_skipOnDrop(){} // RVA: 0x7FFAC9C9A6B0
        public void set_skipOnDrop(){} // RVA: 0x7FFAC9C9A700
        public void get_frameCount(){} // RVA: 0x7FFAC9C9A760
        public void get_frameRate(){} // RVA: 0x7FFAC9C9A7B0
        public void get_length(){} // RVA: 0x7FFAC9C9A800
        public void get_width(){} // RVA: 0x7FFAC9C9A850
        public void get_height(){} // RVA: 0x7FFAC9C9A8A0
        public void get_pixelAspectRatioNumerator(){} // RVA: 0x7FFAC9C9A8F0
        public void get_pixelAspectRatioDenominator(){} // RVA: 0x7FFAC9C9A940
        public void get_audioTrackCount(){} // RVA: 0x7FFAC9C9A990
        public void GetAudioLanguageCode(){} // RVA: 0x7FFAC9C9A9E0
        public void GetAudioChannelCount(){} // RVA: 0x7FFAC9C9AA40
        public void GetAudioSampleRate(){} // RVA: 0x7FFAC9C9AAA0
        public void get_controlledAudioTrackMaxCount(){} // RVA: 0x7FFAC9C9AB00
        public void get_controlledAudioTrackCount(){} // RVA: 0x7FFAC9C9AB50
        public void set_controlledAudioTrackCount(){} // RVA: 0x7FFAC9C9ABA0
        public void GetControlledAudioTrackCount(){} // RVA: 0x7FFAC9C9AB50
        public void SetControlledAudioTrackCount(){} // RVA: 0x7FFAC9C9ACE0
        public void EnableAudioTrack(){} // RVA: 0x7FFAC9C9AD40
        public void IsAudioTrackEnabled(){} // RVA: 0x7FFAC9C9ADB0
        public void get_audioOutputMode(){} // RVA: 0x7FFAC9C9AE10
        public void set_audioOutputMode(){} // RVA: 0x7FFAC9C9AE60
        public void get_canSetDirectAudioVolume(){} // RVA: 0x7FFAC9C9AEC0
        public void GetDirectAudioVolume(){} // RVA: 0x7FFAC9C9AF10
        public void SetDirectAudioVolume(){} // RVA: 0x7FFAC9C9AF70
        public void GetDirectAudioMute(){} // RVA: 0x7FFAC9C9AFE0
        public void SetDirectAudioMute(){} // RVA: 0x7FFAC9C9B040
        public void GetTargetAudioSource(){} // RVA: 0x7FFAC9C9B0B0
        public void SetTargetAudioSource(){} // RVA: 0x7FFAC9C9B110
        public void add_prepareCompleted(){} // RVA: 0x7FFAC9C9B180
        public void remove_prepareCompleted(){} // RVA: 0x7FFAC9C9B270
        public void add_loopPointReached(){} // RVA: 0x7FFAC9C9B360
        public void remove_loopPointReached(){} // RVA: 0x7FFAC9C9B450
        public void add_started(){} // RVA: 0x7FFAC9C9B540
        public void remove_started(){} // RVA: 0x7FFAC9C9B630
        public void add_frameDropped(){} // RVA: 0x7FFAC9C9B720
        public void remove_frameDropped(){} // RVA: 0x7FFAC9C9B810
        public void add_errorReceived(){} // RVA: 0x7FFAC9C9B900
        public void remove_errorReceived(){} // RVA: 0x7FFAC9C9B9F0
        public void add_seekCompleted(){} // RVA: 0x7FFAC9C9BAE0
        public void remove_seekCompleted(){} // RVA: 0x7FFAC9C9BBD0
        public void add_clockResyncOccurred(){} // RVA: 0x7FFAC9C9BCC0
        public void remove_clockResyncOccurred(){} // RVA: 0x7FFAC9C9BDB0
        public void get_sendFrameReadyEvents(){} // RVA: 0x7FFAC9C9BEA0
        public void set_sendFrameReadyEvents(){} // RVA: 0x7FFAC9C9BEF0
        public void add_frameReady(){} // RVA: 0x7FFAC9C9BF50
        public void remove_frameReady(){} // RVA: 0x7FFAC9C9C040
        public void InvokePrepareCompletedCallback_Internal(){} // RVA: 0x7FFAC9C9C130
        public void InvokeFrameReadyCallback_Internal(){} // RVA: 0x7FFAC9C9C170
        public void InvokeLoopPointReachedCallback_Internal(){} // RVA: 0x7FFAC9C9C1B0
        public void InvokeStartedCallback_Internal(){} // RVA: 0x7FFAC9C9C1F0
        public void InvokeFrameDroppedCallback_Internal(){} // RVA: 0x7FFAC9C9C230
        public void InvokeErrorReceivedCallback_Internal(){} // RVA: 0x7FFAC9C9C270
        public void InvokeSeekCompletedCallback_Internal(){} // RVA: 0x7FFAC9C9C2B0
        public void InvokeClockResyncOccurredCallback_Internal(){} // RVA: 0x7FFAC9C9C2F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}