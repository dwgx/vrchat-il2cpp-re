// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components
// Classes: 1
// Methods: 33

namespace VRC.SDK3.Video.Components
{
    public class VRCUnityVideoPlayer : BaseVRCVideoPlayer
    {
        public System.Action`5<VRC.SDKBase.VRCUrl,int,UnityEngine.Object,System.Action`1<string>,System.Action`1<0x6665DD84>> _startResolveURLCoroutine;
        public System.Action`2<string,string> OnErrorReceived; // 0x8
        public VRC.SDKBase.VRCUrl videoURL; // 0x38
        public bool autoPlay; // 0x40
        public bool loop; // 0x41
        public 0x6665B0D4 renderMode; // 0x44
        public UnityEngine.RenderTexture targetTexture; // 0x48

        // ── Methods ──
        public void get_StartResolveURLCoroutine(){} // RVA: 0x7FFE8A45A860
        public void set_StartResolveURLCoroutine(){} // RVA: 0x7FFE8A45A8A0
        public void add_OnErrorReceived(){} // RVA: 0x7FFE8A45A940
        public void remove_OnErrorReceived(){} // RVA: 0x7FFE8A45AA80
        public void get_UnityPlayer(){} // RVA: 0x7FFE8A45ABC0
        public void get_IsPlaying(){} // RVA: 0x7FFE8A45ACA0
        public void get_IsReady(){} // RVA: 0x7FFE8A45AD10
        public void get_Loop(){} // RVA: 0x7FFE814645D0
        public void set_Loop(){} // RVA: 0x7FFE814641E0
        public void Start(){} // RVA: 0x7FFE8A45AD80
        public void PlayDefaultVideo(){} // RVA: 0x7FFE8A45ADE0
        public void SetupVideoPlayer(){} // RVA: 0x7FFE8A45AFE0
        public void LoadURL(){} // RVA: 0x7FFE8A45B790
        public void PlayURL(){} // RVA: 0x7FFE8A45B970
        public void Pause(){} // RVA: 0x7FFE8A45BB60
        public void Play(){} // RVA: 0x7FFE8A45BBD0
        public void PlayDelayCoroutine(){} // RVA: 0x7FFE8A45BD50
        public void GetDuration(){} // RVA: 0x7FFE8A45BDF0
        public void GetTime(){} // RVA: 0x7FFE8A45BE60
        public void SetTime(){} // RVA: 0x7FFE8A45BED0
        public void Stop(){} // RVA: 0x7FFE8A45BF60
        public void OnPrepared(){} // RVA: 0x7FFE8A45BFD0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x7FFE8A45C1F0
        public void OnError(){} // RVA: 0x7FFE8A45C290
        public void OnStarted(){} // RVA: 0x7FFE8A45C3B0
        public void OnLoopPointReached(){} // RVA: 0x7FFE8A45C440
        public void get_VideoWidth(){} // RVA: 0x7FFE8A45C4D0
        public void get_VideoHeight(){} // RVA: 0x7FFE8A45C540
        public void .ctor(){} // RVA: 0x7FFE8A45C5B0
        public void <PlayDefaultVideo>g__PlayVideo|32_0(){} // RVA: 0x7FFE8A45C660
        public void <LoadURL>g__PlayVideo|34_0(){} // RVA: 0x7FFE8A45C6D0
        public void <PlayURL>g__PlayVideo|35_0(){} // RVA: 0x7FFE8A45C760
        public void <>n__0(){} // RVA: 0x7FFE882288A0
    }

}