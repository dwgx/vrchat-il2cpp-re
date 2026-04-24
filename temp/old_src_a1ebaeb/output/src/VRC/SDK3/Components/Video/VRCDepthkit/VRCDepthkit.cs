// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components.Video.VRCDepthkit
// Classes: 2
// Methods: 40

namespace VRC.SDK3.Components.Video.VRCDepthkit
{
    public class VRCDepthkitMetadata : Object
    {
        public object studioLiteMeshData; // 0x33C7DC40
        public object clipMetadataString; // 0x33C7DC40
        public object `00; // 0x854A2420
        public object `00; // 0x854A5B90

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf894890
    }

    public class VRCDepthkitVideo : BaseVRCVideoPlayer
    {
        public object loop; // 0x3390F340
        public object studioMeshSource; // 0x3390F340
        public object LOG_CATEGORY; // 0x3390F340
        public object _pauseOnStart; // 0x3390F340
        public object _allowedSchemes; // 0x3390F340
        public object _schemesToHandleDirectly; // 0x3390F340
        public object _httpClient; // 0x3390F340
        public object url; // 0x17000001
        public object Player; // 0x17000002
        public object IsPlaying; // 0x17000003
        public object IsReady; // 0x17000004
        public object Loop; // 0x17000005
        public object DebugCategoryName; // 0x17000006
        public object VideoWidth; // 0x17000007

        // ── Original Methods ──
        public void get_url(){} // RVA: 0x7ffaaf355690
        public void LogInfo(){} // RVA: 0x7ffaaf8950d0
        public void LogError(){} // RVA: 0x7ffaaf895140
        public void get_Player(){} // RVA: 0x7ffaaf8951b0
        public void get_IsPlaying(){} // RVA: 0x7ffaaf895290
        public void get_IsReady(){} // RVA: 0x7ffaaf8952f0
        public void get_Loop(){} // RVA: 0x7ffaa8bfb9f0
        public void set_Loop(){} // RVA: 0x7ffaa8bfb120
        public void Start(){} // RVA: 0x7ffaaf895330
        public void RefreshDepthkitComponents(){} // RVA: 0x7ffaaf895470
        public void PlayDefaultVideo(){} // RVA: 0x7ffaaf8959c0
        public void SanitizeURL(){} // RVA: 0x7ffaaf895ab0
        public void get_DebugCategoryName(){} // RVA: 0x7ffaaf895bc0
        public void InitializeLogging(){} // RVA: 0x7ffaaf895c40
        public void ResolveURLs(){} // RVA: 0x7ffaaf895d30
        public void LoadURL(){} // RVA: 0x7ffaaf8976d0
        public void PlayURL(){} // RVA: 0x7ffaaf8977c0
        public void Pause(){} // RVA: 0x7ffaaf8978b0
        public void Play(){} // RVA: 0x7ffaaf897910
        public void PlayDelayCoroutine(){} // RVA: 0x7ffaaf897a90
        public void get_VideoWidth(){} // RVA: 0x7ffaaf897d30
        public void get_VideoHeight(){} // RVA: 0x7ffaaf897d70
        public void Stop(){} // RVA: 0x7ffaaf897db0
        public void OnPrepared(){} // RVA: 0x7ffaaf897df0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x7ffaaf898010
        public void OnError(){} // RVA: 0x7ffaaf8980b0
        public void OnStarted(){} // RVA: 0x7ffaaf898130
        public void OnLoopPointReached(){} // RVA: 0x7ffaaf898190
        public void .ctor(){} // RVA: 0x7ffaaf8981e0
        public void .cctor(){} // RVA: 0x7ffaaf8981f0
        public void <PlayDefaultVideo>g__PlayVideo|29_0(){} // RVA: 0x7ffaaf8987e0
        public void <LoadURL>g__PlayVideo|44_0(){} // RVA: 0x7ffaaf898850
        public void <PlayURL>g__PlayVideo|45_0(){} // RVA: 0x7ffaaf8988e0
        public void <>n__0(){} // RVA: 0x7ffaaf898950
        // ── Binary Analysis Named ──
        public void DoSetupFromRemoteJson(){} // RVA: 0x7ffaaf896560
        public void SetupVideoPlayer(){} // RVA: 0x7ffaaf897340
        public void GetDuration(){} // RVA: 0x7ffaaf897b30
        public void GetTime(){} // RVA: 0x7ffaaf897ca0
        public void SetTime(){} // RVA: 0x7ffaaf897ce0
    }

}