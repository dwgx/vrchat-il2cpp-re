// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Video
// Classes: 2
// Methods: 120

namespace ThirdParty.Unity.UnityEngine.Video
{
    public class VideoClip : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6bb0d0
        public void get_originalPath(){} // RVA: 0x7ffaaf6bb120
        public void get_frameRate(){} // RVA: 0x7ffaaf6bb170
        public void get_length(){} // RVA: 0x7ffaaf6bb1c0
        public void get_width(){} // RVA: 0x7ffaaf6bb210
        public void get_height(){} // RVA: 0x7ffaaf6bb260
    }

    public class VideoPlayer : Behaviour
    {
        public object started; // 0x32D1A5E0
        public object seekCompleted; // 0x32D1A5E0

        // ── Original Methods ──
        public void get_source(){} // RVA: 0x7ffaaf6bb2b0
        public void set_source(){} // RVA: 0x7ffaaf6bb300
        public void get_timeUpdateMode(){} // RVA: 0x7ffaaf6bb360
        public void set_timeUpdateMode(){} // RVA: 0x7ffaaf6bb3b0
        public void get_url(){} // RVA: 0x7ffaaf6bb410
        public void set_url(){} // RVA: 0x7ffaaf6bb460
        public void get_clip(){} // RVA: 0x7ffaaf6bb4c0
        public void set_clip(){} // RVA: 0x7ffaaf6bb510
        public void get_renderMode(){} // RVA: 0x7ffaaf6bb570
        public void set_renderMode(){} // RVA: 0x7ffaaf6bb5c0
        public void get_canSetTimeUpdateMode(){} // RVA: 0x7ffaaf6bb620
        public void get_targetCamera(){} // RVA: 0x7ffaaf6bb670
        public void set_targetCamera(){} // RVA: 0x7ffaaf6bb6c0
        public void get_targetTexture(){} // RVA: 0x7ffaaf6bb720
        public void set_targetTexture(){} // RVA: 0x7ffaaf6bb770
        public void get_targetMaterialRenderer(){} // RVA: 0x7ffaaf6bb7d0
        public void set_targetMaterialRenderer(){} // RVA: 0x7ffaaf6bb820
        public void get_targetMaterialProperty(){} // RVA: 0x7ffaaf6bb880
        public void set_targetMaterialProperty(){} // RVA: 0x7ffaaf6bb8d0
        public void get_aspectRatio(){} // RVA: 0x7ffaaf6bb930
        public void set_aspectRatio(){} // RVA: 0x7ffaaf6bb980
        public void get_targetCameraAlpha(){} // RVA: 0x7ffaaf6bb9e0
        public void set_targetCameraAlpha(){} // RVA: 0x7ffaaf6bba30
        public void get_targetCamera3DLayout(){} // RVA: 0x7ffaaf6bba90
        public void set_targetCamera3DLayout(){} // RVA: 0x7ffaaf6bbae0
        public void get_texture(){} // RVA: 0x7ffaaf6bbb40
        public void Prepare(){} // RVA: 0x7ffaaf6bbb90
        public void get_isPrepared(){} // RVA: 0x7ffaaf6bbbe0
        public void get_waitForFirstFrame(){} // RVA: 0x7ffaaf6bbc30
        public void set_waitForFirstFrame(){} // RVA: 0x7ffaaf6bbc80
        public void get_playOnAwake(){} // RVA: 0x7ffaaf6bbce0
        public void set_playOnAwake(){} // RVA: 0x7ffaaf6bbd30
        public void Play(){} // RVA: 0x7ffaaf6bbd90
        public void Pause(){} // RVA: 0x7ffaaf6bbde0
        public void Stop(){} // RVA: 0x7ffaaf6bbe30
        public void get_isPlaying(){} // RVA: 0x7ffaaf6bbe80
        public void get_isPaused(){} // RVA: 0x7ffaaf6bbed0
        public void get_canSetTime(){} // RVA: 0x7ffaaf6bbf20
        public void get_time(){} // RVA: 0x7ffaaf6bbf70
        public void set_time(){} // RVA: 0x7ffaaf6bbfc0
        public void get_frame(){} // RVA: 0x7ffaaf6bc020
        public void set_frame(){} // RVA: 0x7ffaaf6bc070
        public void get_clockTime(){} // RVA: 0x7ffaaf6bc0d0
        public void get_canStep(){} // RVA: 0x7ffaaf6bc120
        public void StepForward(){} // RVA: 0x7ffaaf6bc170
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7ffaaf6bc1c0
        public void get_playbackSpeed(){} // RVA: 0x7ffaaf6bc210
        public void set_playbackSpeed(){} // RVA: 0x7ffaaf6bc260
        public void get_isLooping(){} // RVA: 0x7ffaaf6bc2c0
        public void set_isLooping(){} // RVA: 0x7ffaaf6bc310
        public void get_canSetTimeSource(){} // RVA: 0x7ffaaf6bc370
        public void get_timeSource(){} // RVA: 0x7ffaaf6bc3c0
        public void set_timeSource(){} // RVA: 0x7ffaaf6bc410
        public void get_timeReference(){} // RVA: 0x7ffaaf6bc470
        public void set_timeReference(){} // RVA: 0x7ffaaf6bc4c0
        public void get_externalReferenceTime(){} // RVA: 0x7ffaaf6bc520
        public void set_externalReferenceTime(){} // RVA: 0x7ffaaf6bc570
        public void get_canSetSkipOnDrop(){} // RVA: 0x7ffaaf6bc5d0
        public void get_skipOnDrop(){} // RVA: 0x7ffaaf6bc620
        public void set_skipOnDrop(){} // RVA: 0x7ffaaf6bc670
        public void get_frameCount(){} // RVA: 0x7ffaaf6bc6d0
        public void get_frameRate(){} // RVA: 0x7ffaaf6bc720
        public void get_length(){} // RVA: 0x7ffaaf6bc770
        public void get_width(){} // RVA: 0x7ffaaf6bc7c0
        public void get_height(){} // RVA: 0x7ffaaf6bc810
        public void get_pixelAspectRatioNumerator(){} // RVA: 0x7ffaaf6bc860
        public void get_pixelAspectRatioDenominator(){} // RVA: 0x7ffaaf6bc8b0
        public void get_audioTrackCount(){} // RVA: 0x7ffaaf6bc900
        public void get_controlledAudioTrackMaxCount(){} // RVA: 0x7ffaaf6bca70
        public void get_controlledAudioTrackCount(){} // RVA: 0x7ffaaf6bcac0
        public void set_controlledAudioTrackCount(){} // RVA: 0x7ffaaf6bcb10
        public void EnableAudioTrack(){} // RVA: 0x7ffaaf6bccb0
        public void IsAudioTrackEnabled(){} // RVA: 0x7ffaaf6bcd20
        public void get_audioOutputMode(){} // RVA: 0x7ffaaf6bcd80
        public void set_audioOutputMode(){} // RVA: 0x7ffaaf6bcdd0
        public void get_canSetDirectAudioVolume(){} // RVA: 0x7ffaaf6bce30
        public void add_prepareCompleted(){} // RVA: 0x7ffaaf6bd0f0
        public void remove_prepareCompleted(){} // RVA: 0x7ffaaf6bd1e0
        public void add_loopPointReached(){} // RVA: 0x7ffaaf6bd2d0
        public void remove_loopPointReached(){} // RVA: 0x7ffaaf6bd3c0
        public void add_started(){} // RVA: 0x7ffaaf6bd4b0
        public void remove_started(){} // RVA: 0x7ffaaf6bd5a0
        public void add_frameDropped(){} // RVA: 0x7ffaaf6bd690
        public void remove_frameDropped(){} // RVA: 0x7ffaaf6bd780
        public void add_errorReceived(){} // RVA: 0x7ffaaf6bd870
        public void remove_errorReceived(){} // RVA: 0x7ffaaf6bd960
        public void add_seekCompleted(){} // RVA: 0x7ffaaf6bda50
        public void remove_seekCompleted(){} // RVA: 0x7ffaaf6bdb40
        public void add_clockResyncOccurred(){} // RVA: 0x7ffaaf6bdc30
        public void remove_clockResyncOccurred(){} // RVA: 0x7ffaaf6bdd20
        public void get_sendFrameReadyEvents(){} // RVA: 0x7ffaaf6bde10
        public void set_sendFrameReadyEvents(){} // RVA: 0x7ffaaf6bde60
        public void add_frameReady(){} // RVA: 0x7ffaaf6bdec0
        public void remove_frameReady(){} // RVA: 0x7ffaaf6bdfb0
        public void InvokePrepareCompletedCallback_Internal(){} // RVA: 0x7ffaaf6be0a0
        public void InvokeFrameReadyCallback_Internal(){} // RVA: 0x7ffaaf6be0e0
        public void InvokeLoopPointReachedCallback_Internal(){} // RVA: 0x7ffaaf6be120
        public void InvokeStartedCallback_Internal(){} // RVA: 0x7ffaaf6be160
        public void InvokeFrameDroppedCallback_Internal(){} // RVA: 0x7ffaaf6be1a0
        public void InvokeErrorReceivedCallback_Internal(){} // RVA: 0x7ffaaf6be1e0
        public void InvokeSeekCompletedCallback_Internal(){} // RVA: 0x7ffaaf6be220
        public void InvokeClockResyncOccurredCallback_Internal(){} // RVA: 0x7ffaaf6be260
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetAudioLanguageCode(){} // RVA: 0x7ffaaf6bc950
        public void GetAudioChannelCount(){} // RVA: 0x7ffaaf6bc9b0
        public void GetAudioSampleRate(){} // RVA: 0x7ffaaf6bca10
        public void GetControlledAudioTrackCount(){} // RVA: 0x7ffaaf6bcac0
        public void SetControlledAudioTrackCount(){} // RVA: 0x7ffaaf6bcc50
        public void GetDirectAudioVolume(){} // RVA: 0x7ffaaf6bce80
        public void SetDirectAudioVolume(){} // RVA: 0x7ffaaf6bcee0
        public void GetDirectAudioMute(){} // RVA: 0x7ffaaf6bcf50
        public void SetDirectAudioMute(){} // RVA: 0x7ffaaf6bcfb0
        public void GetTargetAudioSource(){} // RVA: 0x7ffaaf6bd020
        public void SetTargetAudioSource(){} // RVA: 0x7ffaaf6bd080
    }

}