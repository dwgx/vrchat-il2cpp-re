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
        public void .ctor(){} // RVA: 0x7FFD550B9160
        public void get_originalPath(){} // RVA: 0x7FFD550B91B0
        public void get_frameRate(){} // RVA: 0x7FFD550B9200
        public void get_length(){} // RVA: 0x7FFD550B9250
        public void get_width(){} // RVA: 0x7FFD550B92A0
        public void get_height(){} // RVA: 0x7FFD550B92F0
    }

    public class VideoPlayer : Behaviour
    {
        public cjkIndexer source; // 0x18
        public cjkIndexer timeUpdateMode; // 0x20
        public cjkIndexer url; // 0x28
        public cjkIndexer clip; // 0x30
        public t renderMode; // 0x38
        public cjkIndexer canSetTimeUpdateMode; // 0x40
        public er>b__29_4 targetCamera; // 0x48
        public __29_2 targetTexture; // 0x50

        // ── Methods ──
        public void get_source(){} // RVA: 0x7FFD550B9340
        public void set_source(){} // RVA: 0x7FFD550B9390
        public void get_timeUpdateMode(){} // RVA: 0x7FFD550B93F0
        public void set_timeUpdateMode(){} // RVA: 0x7FFD550B9440
        public void get_url(){} // RVA: 0x7FFD550B94A0
        public void set_url(){} // RVA: 0x7FFD550B94F0
        public void get_clip(){} // RVA: 0x7FFD550B9550
        public void set_clip(){} // RVA: 0x7FFD550B95A0
        public void get_renderMode(){} // RVA: 0x7FFD550B9600
        public void set_renderMode(){} // RVA: 0x7FFD550B9650
        public void get_canSetTimeUpdateMode(){} // RVA: 0x7FFD550B96B0
        public void get_targetCamera(){} // RVA: 0x7FFD550B9700
        public void set_targetCamera(){} // RVA: 0x7FFD550B9750
        public void get_targetTexture(){} // RVA: 0x7FFD550B97B0
        public void set_targetTexture(){} // RVA: 0x7FFD550B9800
        public void get_targetMaterialRenderer(){} // RVA: 0x7FFD550B9860
        public void set_targetMaterialRenderer(){} // RVA: 0x7FFD550B98B0
        public void get_targetMaterialProperty(){} // RVA: 0x7FFD550B9910
        public void set_targetMaterialProperty(){} // RVA: 0x7FFD550B9960
        public void get_aspectRatio(){} // RVA: 0x7FFD550B99C0
        public void set_aspectRatio(){} // RVA: 0x7FFD550B9A10
        public void get_targetCameraAlpha(){} // RVA: 0x7FFD550B9A70
        public void set_targetCameraAlpha(){} // RVA: 0x7FFD550B9AC0
        public void get_targetCamera3DLayout(){} // RVA: 0x7FFD550B9B20
        public void set_targetCamera3DLayout(){} // RVA: 0x7FFD550B9B70
        public void get_texture(){} // RVA: 0x7FFD550B9BD0
        public void Prepare(){} // RVA: 0x7FFD550B9C20
        public void get_isPrepared(){} // RVA: 0x7FFD550B9C70
        public void get_waitForFirstFrame(){} // RVA: 0x7FFD550B9CC0
        public void set_waitForFirstFrame(){} // RVA: 0x7FFD550B9D10
        public void get_playOnAwake(){} // RVA: 0x7FFD550B9D70
        public void set_playOnAwake(){} // RVA: 0x7FFD550B9DC0
        public void Play(){} // RVA: 0x7FFD550B9E20
        public void Pause(){} // RVA: 0x7FFD550B9E70
        public void Stop(){} // RVA: 0x7FFD550B9EC0
        public void get_isPlaying(){} // RVA: 0x7FFD550B9F10
        public void get_isPaused(){} // RVA: 0x7FFD550B9F60
        public void get_canSetTime(){} // RVA: 0x7FFD550B9FB0
        public void get_time(){} // RVA: 0x7FFD550BA000
        public void set_time(){} // RVA: 0x7FFD550BA050
        public void get_frame(){} // RVA: 0x7FFD550BA0B0
        public void set_frame(){} // RVA: 0x7FFD550BA100
        public void get_clockTime(){} // RVA: 0x7FFD550BA160
        public void get_canStep(){} // RVA: 0x7FFD550BA1B0
        public void StepForward(){} // RVA: 0x7FFD550BA200
        public void get_canSetPlaybackSpeed(){} // RVA: 0x7FFD550BA250
        public void get_playbackSpeed(){} // RVA: 0x7FFD550BA2A0
        public void set_playbackSpeed(){} // RVA: 0x7FFD550BA2F0
        public void get_isLooping(){} // RVA: 0x7FFD550BA350
        public void set_isLooping(){} // RVA: 0x7FFD550BA3A0
        public void get_canSetTimeSource(){} // RVA: 0x7FFD550BA400
        public void get_timeSource(){} // RVA: 0x7FFD550BA450
        public void set_timeSource(){} // RVA: 0x7FFD550BA4A0
        public void get_timeReference(){} // RVA: 0x7FFD550BA500
        public void set_timeReference(){} // RVA: 0x7FFD550BA550
        public void get_externalReferenceTime(){} // RVA: 0x7FFD550BA5B0
        public void set_externalReferenceTime(){} // RVA: 0x7FFD550BA600
        public void get_canSetSkipOnDrop(){} // RVA: 0x7FFD550BA660
        public void get_skipOnDrop(){} // RVA: 0x7FFD550BA6B0
        public void set_skipOnDrop(){} // RVA: 0x7FFD550BA700
        public void get_frameCount(){} // RVA: 0x7FFD550BA760
        public void get_frameRate(){} // RVA: 0x7FFD550BA7B0
        public void get_length(){} // RVA: 0x7FFD550BA800
        public void get_width(){} // RVA: 0x7FFD550BA850
        public void get_height(){} // RVA: 0x7FFD550BA8A0
        public void get_pixelAspectRatioNumerator(){} // RVA: 0x7FFD550BA8F0
        public void get_pixelAspectRatioDenominator(){} // RVA: 0x7FFD550BA940
        public void get_audioTrackCount(){} // RVA: 0x7FFD550BA990
        public void GetAudioLanguageCode(){} // RVA: 0x7FFD550BA9E0
        public void GetAudioChannelCount(){} // RVA: 0x7FFD550BAA40
        public void GetAudioSampleRate(){} // RVA: 0x7FFD550BAAA0
        public void get_controlledAudioTrackMaxCount(){} // RVA: 0x7FFD550BAB00
        public void get_controlledAudioTrackCount(){} // RVA: 0x7FFD550BAB50
        public void set_controlledAudioTrackCount(){} // RVA: 0x7FFD550BABA0
        public void GetControlledAudioTrackCount(){} // RVA: 0x7FFD550BAB50
        public void SetControlledAudioTrackCount(){} // RVA: 0x7FFD550BACE0
        public void EnableAudioTrack(){} // RVA: 0x7FFD550BAD40
        public void IsAudioTrackEnabled(){} // RVA: 0x7FFD550BADB0
        public void get_audioOutputMode(){} // RVA: 0x7FFD550BAE10
        public void set_audioOutputMode(){} // RVA: 0x7FFD550BAE60
        public void get_canSetDirectAudioVolume(){} // RVA: 0x7FFD550BAEC0
        public void GetDirectAudioVolume(){} // RVA: 0x7FFD550BAF10
        public void SetDirectAudioVolume(){} // RVA: 0x7FFD550BAF70
        public void GetDirectAudioMute(){} // RVA: 0x7FFD550BAFE0
        public void SetDirectAudioMute(){} // RVA: 0x7FFD550BB040
        public void GetTargetAudioSource(){} // RVA: 0x7FFD550BB0B0
        public void SetTargetAudioSource(){} // RVA: 0x7FFD550BB110
        public void add_prepareCompleted(){} // RVA: 0x7FFD550BB180
        public void remove_prepareCompleted(){} // RVA: 0x7FFD550BB270
        public void add_loopPointReached(){} // RVA: 0x7FFD550BB360
        public void remove_loopPointReached(){} // RVA: 0x7FFD550BB450
        public void add_started(){} // RVA: 0x7FFD550BB540
        public void remove_started(){} // RVA: 0x7FFD550BB630
        public void add_frameDropped(){} // RVA: 0x7FFD550BB720
        public void remove_frameDropped(){} // RVA: 0x7FFD550BB810
        public void add_errorReceived(){} // RVA: 0x7FFD550BB900
        public void remove_errorReceived(){} // RVA: 0x7FFD550BB9F0
        public void add_seekCompleted(){} // RVA: 0x7FFD550BBAE0
        public void remove_seekCompleted(){} // RVA: 0x7FFD550BBBD0
        public void add_clockResyncOccurred(){} // RVA: 0x7FFD550BBCC0
        public void remove_clockResyncOccurred(){} // RVA: 0x7FFD550BBDB0
        public void get_sendFrameReadyEvents(){} // RVA: 0x7FFD550BBEA0
        public void set_sendFrameReadyEvents(){} // RVA: 0x7FFD550BBEF0
        public void add_frameReady(){} // RVA: 0x7FFD550BBF50
        public void remove_frameReady(){} // RVA: 0x7FFD550BC040
        public void InvokePrepareCompletedCallback_Internal(){} // RVA: 0x7FFD550BC130
        public void InvokeFrameReadyCallback_Internal(){} // RVA: 0x7FFD550BC170
        public void InvokeLoopPointReachedCallback_Internal(){} // RVA: 0x7FFD550BC1B0
        public void InvokeStartedCallback_Internal(){} // RVA: 0x7FFD550BC1F0
        public void InvokeFrameDroppedCallback_Internal(){} // RVA: 0x7FFD550BC230
        public void InvokeErrorReceivedCallback_Internal(){} // RVA: 0x7FFD550BC270
        public void InvokeSeekCompletedCallback_Internal(){} // RVA: 0x7FFD550BC2B0
        public void InvokeClockResyncOccurredCallback_Internal(){} // RVA: 0x7FFD550BC2F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}