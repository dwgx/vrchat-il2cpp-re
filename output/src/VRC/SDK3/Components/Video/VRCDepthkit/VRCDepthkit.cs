// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components.Video.VRCDepthkit
// Classes: 2
// Methods: 40

namespace VRC.SDK3.Components.Video.VRCDepthkit
{
    public class VRCDepthkitMetadata
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x76E76C0
    }

    public class VRCDepthkitVideo
    {
        public VRC.SDKBase.VRCUrl videoURL; // 0x38
        public bool autoPlay; // 0x40
        public bool loop; // 0x41
        public Depthkit.StudioLook studioLook; // 0x48
        public Depthkit.StudioLiteLook studioLiteLook; // 0x50
        public Depthkit.StudioMeshSource studioMeshSource; // 0x58
        public Depthkit.StudioLiteMeshSource studioLiteMeshSource; // 0x60
        public Depthkit.Clip depthkitClip; // 0x68

        // ── Methods ──
        public void get_url(){} // RVA: 0x719BE30
        public void LogInfo(){} // RVA: 0x76E7F00
        public void LogError(){} // RVA: 0x76E7F70
        public void get_Player(){} // RVA: 0x76E7FE0
        public void get_IsPlaying(){} // RVA: 0x76E80C0
        public void get_IsReady(){} // RVA: 0x76E8120
        public void get_Loop(){} // RVA: 0x65EEC0
        public void set_Loop(){} // RVA: 0x65EEB0
        public void Start(){} // RVA: 0x76E8160
        public void RefreshDepthkitComponents(){} // RVA: 0x76E82A0
        public void PlayDefaultVideo(){} // RVA: 0x76E87F0
        public void SanitizeURL(){} // RVA: 0x76E88E0
        public void get_DebugCategoryName(){} // RVA: 0x76E89F0
        public void InitializeLogging(){} // RVA: 0x76E8A70
        public void ResolveURLs(){} // RVA: 0x76E8B60
        public void DoSetupFromRemoteJson(){} // RVA: 0x76E9390
        public void SetupVideoPlayer(){} // RVA: 0x76EA170
        public void LoadURL(){} // RVA: 0x76EA500
        public void PlayURL(){} // RVA: 0x76EA5F0
        public void Pause(){} // RVA: 0x76EA6E0
        public void Play(){} // RVA: 0x76EA740
        public void PlayDelayCoroutine(){} // RVA: 0x76EA8C0
        public void GetDuration(){} // RVA: 0x76EA960
        public void GetTime(){} // RVA: 0x76EAAD0
        public void SetTime(){} // RVA: 0x76EAB10
        public void get_VideoWidth(){} // RVA: 0x76EAB60
        public void get_VideoHeight(){} // RVA: 0x76EABA0
        public void Stop(){} // RVA: 0x76EABE0
        public void OnPrepared(){} // RVA: 0x76EAC20
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x76EAE40
        public void OnError(){} // RVA: 0x76EAEE0
        public void OnStarted(){} // RVA: 0x76EAF60
        public void OnLoopPointReached(){} // RVA: 0x76EAFC0
        public void .ctor(){} // RVA: 0x76EB010
        public void .cctor(){} // RVA: 0x76EB020
        public void <PlayDefaultVideo>g__PlayVideo|29_0(){} // RVA: 0x76EB610
        public void <LoadURL>g__PlayVideo|44_0(){} // RVA: 0x76EB680
        public void <PlayURL>g__PlayVideo|45_0(){} // RVA: 0x76EB710
        public void <>n__0(){} // RVA: 0x76EB780
    }

}