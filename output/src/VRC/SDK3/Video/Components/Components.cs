// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components
// Classes: 1
// Methods: 33

namespace VRC.SDK3.Video.Components
{
    public class VRCUnityVideoPlayer
    {
        public System.Action`5<VRC.SDKBase.VRCUrl,int,UnityEngine.Object,System.Action`1<string>,System.Action`1<0x6597F8B8>> <StartResolveURLCoroutine>k__BackingField;
        public System.Action`2<string,string> OnErrorReceived; // 0x8
        public VRC.SDKBase.VRCUrl videoURL; // 0x38
        public bool autoPlay; // 0x40
        public bool loop; // 0x41
        public 0x6597BFA8 renderMode; // 0x44
        public UnityEngine.RenderTexture targetTexture; // 0x48

        // ── Methods ──
        public void get_StartResolveURLCoroutine(){} // RVA: 0x99FEE30
        public void set_StartResolveURLCoroutine(){} // RVA: 0x99FEE70
        public void add_OnErrorReceived(){} // RVA: 0x99FEF10
        public void remove_OnErrorReceived(){} // RVA: 0x99FF050
        public void get_UnityPlayer(){} // RVA: 0x99FF190
        public void get_IsPlaying(){} // RVA: 0x99FF270
        public void get_IsReady(){} // RVA: 0x99FF2E0
        public void get_Loop(){} // RVA: 0x65EEC0
        public void set_Loop(){} // RVA: 0x65EEB0
        public void Start(){} // RVA: 0x99FF350
        public void PlayDefaultVideo(){} // RVA: 0x99FF3B0
        public void SetupVideoPlayer(){} // RVA: 0x99FF5B0
        public void LoadURL(){} // RVA: 0x99FFD60
        public void PlayURL(){} // RVA: 0x99FFF40
        public void Pause(){} // RVA: 0x9A00130
        public void Play(){} // RVA: 0x9A001A0
        public void PlayDelayCoroutine(){} // RVA: 0x9A00320
        public void GetDuration(){} // RVA: 0x9A003C0
        public void GetTime(){} // RVA: 0x9A00430
        public void SetTime(){} // RVA: 0x9A004A0
        public void Stop(){} // RVA: 0x9A00530
        public void OnPrepared(){} // RVA: 0x9A005A0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x9A007C0
        public void OnError(){} // RVA: 0x9A00860
        public void OnStarted(){} // RVA: 0x9A00980
        public void OnLoopPointReached(){} // RVA: 0x9A00A10
        public void get_VideoWidth(){} // RVA: 0x9A00AA0
        public void get_VideoHeight(){} // RVA: 0x9A00B10
        public void .ctor(){} // RVA: 0x9A00B80
        public void <PlayDefaultVideo>g__PlayVideo|32_0(){} // RVA: 0x9A00C30
        public void <LoadURL>g__PlayVideo|34_0(){} // RVA: 0x9A00CA0
        public void <PlayURL>g__PlayVideo|35_0(){} // RVA: 0x9A00D30
        public void <>n__0(){} // RVA: 0x76EB780
    }

}