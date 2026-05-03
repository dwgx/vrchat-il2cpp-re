// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components.Video.VRCDepthkit
// Classes: 2
// Methods: 40

namespace VRC.SDK3.Components.Video.VRCDepthkit
{
    public class VRCDepthkitMetadata : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE882247E0
    }

    public class VRCDepthkitVideo : BaseVRCVideoPlayer
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
        public void get_url(){} // RVA: 0x7FFE87CDBFD0
        public void LogInfo(){} // RVA: 0x7FFE88225020
        public void LogError(){} // RVA: 0x7FFE88225090
        public void get_Player(){} // RVA: 0x7FFE88225100
        public void get_IsPlaying(){} // RVA: 0x7FFE882251E0
        public void get_IsReady(){} // RVA: 0x7FFE88225240
        public void get_Loop(){} // RVA: 0x7FFE814645D0
        public void set_Loop(){} // RVA: 0x7FFE814641E0
        public void Start(){} // RVA: 0x7FFE88225280
        public void RefreshDepthkitComponents(){} // RVA: 0x7FFE882253C0
        public void PlayDefaultVideo(){} // RVA: 0x7FFE88225910
        public void SanitizeURL(){} // RVA: 0x7FFE88225A00
        public void get_DebugCategoryName(){} // RVA: 0x7FFE88225B10
        public void InitializeLogging(){} // RVA: 0x7FFE88225B90
        public void ResolveURLs(){} // RVA: 0x7FFE88225C80
        public void DoSetupFromRemoteJson(){} // RVA: 0x7FFE882264B0
        public void SetupVideoPlayer(){} // RVA: 0x7FFE88227290
        public void LoadURL(){} // RVA: 0x7FFE88227620
        public void PlayURL(){} // RVA: 0x7FFE88227710
        public void Pause(){} // RVA: 0x7FFE88227800
        public void Play(){} // RVA: 0x7FFE88227860
        public void PlayDelayCoroutine(){} // RVA: 0x7FFE882279E0
        public void GetDuration(){} // RVA: 0x7FFE88227A80
        public void GetTime(){} // RVA: 0x7FFE88227BF0
        public void SetTime(){} // RVA: 0x7FFE88227C30
        public void get_VideoWidth(){} // RVA: 0x7FFE88227C80
        public void get_VideoHeight(){} // RVA: 0x7FFE88227CC0
        public void Stop(){} // RVA: 0x7FFE88227D00
        public void OnPrepared(){} // RVA: 0x7FFE88227D40
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x7FFE88227F60
        public void OnError(){} // RVA: 0x7FFE88228000
        public void OnStarted(){} // RVA: 0x7FFE88228080
        public void OnLoopPointReached(){} // RVA: 0x7FFE882280E0
        public void .ctor(){} // RVA: 0x7FFE88228130
        public void .cctor(){} // RVA: 0x7FFE88228140
        public void <PlayDefaultVideo>g__PlayVideo|29_0(){} // RVA: 0x7FFE88228730
        public void <LoadURL>g__PlayVideo|44_0(){} // RVA: 0x7FFE882287A0
        public void <PlayURL>g__PlayVideo|45_0(){} // RVA: 0x7FFE88228830
        public void <>n__0(){} // RVA: 0x7FFE882288A0
    }

}