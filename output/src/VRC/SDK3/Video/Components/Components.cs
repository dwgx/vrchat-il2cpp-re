// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components
// Classes: 1
// Methods: 33

namespace VRC.SDK3.Video.Components
{
    public class VRCUnityVideoPlayer : BaseVRCVideoPlayer
    {
        public System.Action`5<VRC.SDKBase.VRCUrl,int,UnityEngine.Object,System.Action`1<string>,System.Action`1<0x6B2641A8>> StartResolveURLCoroutine;
        public System.Action`2<string,string> UnityPlayer; // 0x8
        public VRC.SDKBase.VRCUrl IsPlaying; // 0x38
        public bool IsReady; // 0x40
        public bool Loop; // 0x41
        public 0x6B2615A8 VideoWidth; // 0x44
        public UnityEngine.RenderTexture VideoHeight; // 0x48
        public UnityEngine.Renderer targetMaterialRenderer; // 0x50
        public string targetMaterialProperty; // 0x58
        public 0x6B2D7588 aspectRatio; // 0x60
        public UnityEngine.AudioSource[] targetAudioSources; // 0x68
        public int maximumResolution; // 0x70
        public UnityEngine.Video.VideoPlayer _unityPlayer; // 0x78
        public bool _pauseOnStart; // 0x80
        public UnityEngine.Coroutine _playDelayedCoroutine; // 0x88
        public UnityEngine.Coroutine _onVideoReadyDelayedCoroutine; // 0x90

        // ── Methods ──
        public void get_StartResolveURLCoroutine(){} // RVA: 0x7FFACBFF5060
        public void set_StartResolveURLCoroutine(){} // RVA: 0x7FFACBFF50A0
        public void add_OnErrorReceived(){} // RVA: 0x7FFACBFF5140
        public void remove_OnErrorReceived(){} // RVA: 0x7FFACBFF5280
        public void get_UnityPlayer(){} // RVA: 0x7FFACBFF53C0
        public void get_IsPlaying(){} // RVA: 0x7FFACBFF54A0
        public void get_IsReady(){} // RVA: 0x7FFACBFF5510
        public void get_Loop(){} // RVA: 0x7FFAC31D8A60
        public void set_Loop(){} // RVA: 0x7FFAC31D8A10
        public void Start(){} // RVA: 0x7FFACBFF5580
        public void PlayDefaultVideo(){} // RVA: 0x7FFACBFF55E0
        public void SetupVideoPlayer(){} // RVA: 0x7FFACBFF57E0
        public void LoadURL(){} // RVA: 0x7FFACBFF5F90
        public void PlayURL(){} // RVA: 0x7FFACBFF6170
        public void Pause(){} // RVA: 0x7FFACBFF6360
        public void Play(){} // RVA: 0x7FFACBFF63D0
        public void PlayDelayCoroutine(){} // RVA: 0x7FFACBFF6550
        public void GetDuration(){} // RVA: 0x7FFACBFF65F0
        public void GetTime(){} // RVA: 0x7FFACBFF6660
        public void SetTime(){} // RVA: 0x7FFACBFF66D0
        public void Stop(){} // RVA: 0x7FFACBFF6760
        public void OnPrepared(){} // RVA: 0x7FFACBFF67D0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x7FFACBFF69F0
        public void OnError(){} // RVA: 0x7FFACBFF6A90
        public void OnStarted(){} // RVA: 0x7FFACBFF6BB0
        public void OnLoopPointReached(){} // RVA: 0x7FFACBFF6C40
        public void get_VideoWidth(){} // RVA: 0x7FFACBFF6CD0
        public void get_VideoHeight(){} // RVA: 0x7FFACBFF6D40
        public void .ctor(){} // RVA: 0x7FFACBFF6DB0
        public void <PlayDefaultVideo>g__PlayVideo|32_0(){} // RVA: 0x7FFACBFF6E60
        public void <LoadURL>g__PlayVideo|34_0(){} // RVA: 0x7FFACBFF6ED0
        public void <PlayURL>g__PlayVideo|35_0(){} // RVA: 0x7FFACBFF6F60
        public void <>n__0(){} // RVA: 0x7FFAC9E75F30
    }

}