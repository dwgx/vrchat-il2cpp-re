// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Video
// Classes: 2
// Methods: 120

namespace ThirdParty.Unity.UnityEngine.Video
{
    public class VideoClip : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880419B0
        public void get_originalPath(){} // RVA: 0x7FFE88041A00
        public void get_frameRate(){} // RVA: 0x7FFE88041A50
        public void get_length(){} // RVA: 0x7FFE88041AA0
        public void get_width(){} // RVA: 0x7FFE88041AF0
        public void get_height(){} // RVA: 0x7FFE88041B40
    }

    public class VideoPlayer : Behaviour
    {
        public EventHandler prepareCompleted; // 0x18
        public EventHandler loopPointReached; // 0x20
        public EventHandler started; // 0x28
        public EventHandler frameDropped; // 0x30
        public ErrorEventHandler errorReceived; // 0x38
        public EventHandler seekCompleted; // 0x40
        public TimeEventHandler clockResyncOccurred; // 0x48
        public FrameReadyEventHandler frameReady; // 0x50
        public IntPtr .ctor; // 0x1DE0
        public object get_source; // 0xE70
        public object field_10; // 0xFFFF
        public object field_11; // 0xBBB0
        public object field_12; // 0xF38
        public object field_13; // 0x9519
        public object field_14;
        public object field_15; // 0x420
        public object .ctor; // 0xC9A0
        public bool field_17; // 0xEAD0
        public object field_18; // 0x1B58
        public object field_19; // 0x1C08
        public sbyte field_20; // 0x2118
        public sbyte field_21; // 0x22D0
        public sbyte field_22; // 0x2488
        public sbyte field_23; // 0x2640
        public sbyte field_24; // 0x27F8
        public sbyte field_25; // 0x29B0
        public sbyte field_26; // 0x2B68
        public sbyte field_27; // 0x2D20
        public sbyte field_28; // 0x2ED8
        public sbyte field_29; // 0x3090
        public sbyte field_30; // 0x3248
        public sbyte field_31; // 0x3400
        public sbyte field_32; // 0x35B8
        public sbyte field_33; // 0x3770
        public sbyte field_34; // 0x3928
        public sbyte field_35; // 0x3AE0
        public sbyte field_36; // 0x3C98
        public sbyte field_37; // 0x3E50
        public sbyte field_38; // 0x4008
        public sbyte field_39; // 0x41C0
        public sbyte field_40; // 0x4378
        public sbyte field_41; // 0x4530
        public sbyte field_42; // 0x46E8
        public object field_43; // 0xF050
        public object get_source; // 0xE860
        public object field_45; // 0x1BE0

        // ── Methods ──
        public void get_source(){} // RVA: 0x7FFE88041B90
        public void set_source(){} // RVA: 0x7FFE88041BE0
        public void get_timeUpdateMode(){} // RVA: 0x7FFE88041C40
        public void set_timeUpdateMode(){} // RVA: 0x7FFE88041C90
        public void get_url(){} // RVA: 0x7FFE88041CF0
        public void set_url(){} // RVA: 0x7FFE88041D40
        public void get_clip(){} // RVA: 0x7FFE88041DA0
        public void set_clip(){} // RVA: 0x7FFE88041DF0
        public void get_renderMode(){} // RVA: 0x7FFE88041E50
        public void set_renderMode(){} // RVA: 0x7FFE88041EA0
        public void get_canSetTimeUpdateMode(){} // RVA: 0x7FFE88041F00
        public void get_targetCamera(){} // RVA: 0x7FFE88041F50
        public void set_targetCamera(){} // RVA: 0x7FFE88041FA0
        public void get_targetTexture(){} // RVA: 0x7FFE88042000
        public void set_targetTexture(){} // RVA: 0x7FFE88042050
        public void get_targetMaterialRenderer(){} // RVA: 0x7FFE880420B0
        public void set_targetMaterialRenderer(){} // RVA: 0x7FFE88042100
        public void get_targetMaterialProperty(){} // RVA: 0x7FFE88042160
        public void set_targetMaterialProperty(){} // RVA: 0x7FFE880421B0
        public void get_aspectRatio(){} // RVA: 0x7FFE88042210
        public void set_aspectRatio(){} // RVA: 0x7FFE88042260
        public void get_targetCameraAlpha(){} // RVA: 0x7FFE880422C0
        public void set_targetCameraAlpha(){} // RVA: 0x7FFE88042310
        public void get_targetCamera3DLayout(){} // RVA: 0x7FFE88042370
        public void set_targetCamera3DLayout(){} // RVA: 0x7FFE880423C0
        public void get_texture(){} // RVA: 0x7FFE88042420
        public void Prepare(){} // RVA: 0x7FFE88042470
        public void get_isPrepared(){} // RVA: 0x7FFE880424C0
        public void get_waitForFirstFrame(){} // RVA: 0x7FFE88042510
        public void set_waitForFirstFrame(){} // RVA: 0x7FFE88042560
        public void get_playOnAwake(){} // RVA: 0x7FFE880425C0
        public void set_playOnAwake(){} // RVA: 0x7FFE88042610
        public void Play(){} // RVA: 0x7FFE88042670
        public void Pause(){} // RVA: 0x7FFE880426C0
        public void Stop(){} // RVA: 0x7FFE88042710
        public void get_isPlaying(){} // RVA: 0x7FFE88042760
        public void get_isPaused(){} // RVA: 0x7FFE880427B0
        public void get_canSetTime(){} // RVA: 0x7FFE88042800
        public void get_time(){} // RVA: 0x7FFE88042850
        public void set_time(){} // RVA: 0x7FFE880428A0
        public void get_frame(){} // RVA: 0x7FFE88042900
        public void set_frame(){} // RVA: 0x7FFE88042950
        public void get_clockTime(){} // RVA: 0x7FFE880429B0
        public void get_canStep(){} // RVA: 0x7FFE88042A00
        public void StepForward(){} // RVA: 0x7FFE88042A50
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7FFE88042AA0
        public void get_playbackSpeed(){} // RVA: 0x7FFE88042AF0
        public void set_playbackSpeed(){} // RVA: 0x7FFE88042B40
        public void get_isLooping(){} // RVA: 0x7FFE88042BA0
        public void set_isLooping(){} // RVA: 0x7FFE88042BF0
        public void get_canSetTimeSource(){} // RVA: 0x7FFE88042C50
        public void get_timeSource(){} // RVA: 0x7FFE88042CA0
        public void set_timeSource(){} // RVA: 0x7FFE88042CF0
        public void get_timeReference(){} // RVA: 0x7FFE88042D50
        public void set_timeReference(){} // RVA: 0x7FFE88042DA0
        public void get_externalReferenceTime(){} // RVA: 0x7FFE88042E00
        public void set_externalReferenceTime(){} // RVA: 0x7FFE88042E50
        public void get_canSetSkipOnDrop(){} // RVA: 0x7FFE88042EB0
        public void get_skipOnDrop(){} // RVA: 0x7FFE88042F00
        public void set_skipOnDrop(){} // RVA: 0x7FFE88042F50
        public void get_frameCount(){} // RVA: 0x7FFE88042FB0
        public void get_frameRate(){} // RVA: 0x7FFE88043000
        public void get_length(){} // RVA: 0x7FFE88043050
        public void get_width(){} // RVA: 0x7FFE880430A0
        public void get_height(){} // RVA: 0x7FFE880430F0
        public void get_pixelAspectRatioNumerator(){} // RVA: 0x7FFE88043140
        public void get_pixelAspectRatioDenominator(){} // RVA: 0x7FFE88043190
        public void get_audioTrackCount(){} // RVA: 0x7FFE880431E0
        public void GetAudioLanguageCode(){} // RVA: 0x7FFE88043230
        public void GetAudioChannelCount(){} // RVA: 0x7FFE88043290
        public void GetAudioSampleRate(){} // RVA: 0x7FFE880432F0
        public void get_controlledAudioTrackMaxCount(){} // RVA: 0x7FFE88043350
        public void get_controlledAudioTrackCount(){} // RVA: 0x7FFE880433A0
        public void set_controlledAudioTrackCount(){} // RVA: 0x7FFE880433F0
        public void GetControlledAudioTrackCount(){} // RVA: 0x7FFE880433A0
        public void SetControlledAudioTrackCount(){} // RVA: 0x7FFE88043530
        public void EnableAudioTrack(){} // RVA: 0x7FFE88043590
        public void IsAudioTrackEnabled(){} // RVA: 0x7FFE88043600
        public void get_audioOutputMode(){} // RVA: 0x7FFE88043660
        public void set_audioOutputMode(){} // RVA: 0x7FFE880436B0
        public void get_canSetDirectAudioVolume(){} // RVA: 0x7FFE88043710
        public void GetDirectAudioVolume(){} // RVA: 0x7FFE88043760
        public void SetDirectAudioVolume(){} // RVA: 0x7FFE880437C0
        public void GetDirectAudioMute(){} // RVA: 0x7FFE88043830
        public void SetDirectAudioMute(){} // RVA: 0x7FFE88043890
        public void GetTargetAudioSource(){} // RVA: 0x7FFE88043900
        public void SetTargetAudioSource(){} // RVA: 0x7FFE88043960
        public void add_prepareCompleted(){} // RVA: 0x7FFE880439D0
        public void remove_prepareCompleted(){} // RVA: 0x7FFE88043AC0
        public void add_loopPointReached(){} // RVA: 0x7FFE88043BB0
        public void remove_loopPointReached(){} // RVA: 0x7FFE88043CA0
        public void add_started(){} // RVA: 0x7FFE88043D90
        public void remove_started(){} // RVA: 0x7FFE88043E80
        public void add_frameDropped(){} // RVA: 0x7FFE88043F70
        public void remove_frameDropped(){} // RVA: 0x7FFE88044060
        public void add_errorReceived(){} // RVA: 0x7FFE88044150
        public void remove_errorReceived(){} // RVA: 0x7FFE88044240
        public void add_seekCompleted(){} // RVA: 0x7FFE88044330
        public void remove_seekCompleted(){} // RVA: 0x7FFE88044420
        public void add_clockResyncOccurred(){} // RVA: 0x7FFE88044510
        public void remove_clockResyncOccurred(){} // RVA: 0x7FFE88044600
        public void get_sendFrameReadyEvents(){} // RVA: 0x7FFE880446F0
        public void set_sendFrameReadyEvents(){} // RVA: 0x7FFE88044740
        public void add_frameReady(){} // RVA: 0x7FFE880447A0
        public void remove_frameReady(){} // RVA: 0x7FFE88044890
        public void InvokePrepareCompletedCallback_Internal(){} // RVA: 0x7FFE88044980
        public void InvokeFrameReadyCallback_Internal(){} // RVA: 0x7FFE880449C0
        public void InvokeLoopPointReachedCallback_Internal(){} // RVA: 0x7FFE88044A00
        public void InvokeStartedCallback_Internal(){} // RVA: 0x7FFE88044A40
        public void InvokeFrameDroppedCallback_Internal(){} // RVA: 0x7FFE88044A80
        public void InvokeErrorReceivedCallback_Internal(){} // RVA: 0x7FFE88044AC0
        public void InvokeSeekCompletedCallback_Internal(){} // RVA: 0x7FFE88044B00
        public void InvokeClockResyncOccurredCallback_Internal(){} // RVA: 0x7FFE88044B40
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}