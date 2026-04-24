// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components.Video.VRCDepthkit
// Classes: 2
// Methods: 40

namespace VRC.SDK3.Components.Video.VRCDepthkit
{
    public class VRCDepthkitMetadata : Object
    {
        public string videoUrl; // 0x10
        public ÏÎÌÏÎÏÏÌÏ studioMeshData; // 0x18
        public ÌÍÍ studioLiteMeshData; // 0x20
        public 0x666395D8 studioLookData; // 0x28
        public 0x66639630 studioLiteLookData; // 0x30
        public string clipMetadataString; // 0x38
        public System.Version FormatVersion;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55291E70
    }

    public class VRCDepthkitVideo : BaseVRCVideoPlayer
    {
        public VRC.SDKBase.VRCUrl url; // 0x38
        public bool Player; // 0x40
        public bool IsPlaying; // 0x41
        public Depthkit.StudioLook IsReady; // 0x48
        public Depthkit.StudioLiteLook Loop; // 0x50
        public Depthkit.StudioMeshSource DebugCategoryName; // 0x58
        public Depthkit.StudioLiteMeshSource VideoWidth; // 0x60
        public Depthkit.Clip VideoHeight; // 0x68
        public string LOG_CATEGORY;
        public Depthkit.UnityVideoPlayer _player; // 0x70
        public UnityEngine.Video.VideoPlayer _unityPlayer; // 0x78
        public bool _pauseOnStart; // 0x80
        public UnityEngine.Coroutine _playDelayedCoroutine; // 0x88
        public UnityEngine.Coroutine _onVideoReadyDelayedCoroutine; // 0x90
        public System.Collections.Generic.HashSet`1<string> _allowedSchemes;
        public float MinimumDelayBetweenResolveRequests;
        public float _lastResolveRequest; // 0x8
        public System.Collections.Generic.HashSet`1<string> _schemesToHandleDirectly; // 0x10
        public System.Lazy`1<string> _debugCategoryName; // 0x18
        public System.Text.RegularExpressions.Regex GetUrlExtension; // 0x20
        public 0x66602840 _httpClient; // 0x28

        // ── Methods ──
        public void get_url(){} // RVA: 0x7FFD54D53730
        public void LogInfo(){} // RVA: 0x7FFD552926B0
        public void LogError(){} // RVA: 0x7FFD55292720
        public void get_Player(){} // RVA: 0x7FFD55292790
        public void get_IsPlaying(){} // RVA: 0x7FFD55292870
        public void get_IsReady(){} // RVA: 0x7FFD552928D0
        public void get_Loop(){} // RVA: 0x7FFD4E5F8A60
        public void set_Loop(){} // RVA: 0x7FFD4E5F8A10
        public void Start(){} // RVA: 0x7FFD55292910
        public void RefreshDepthkitComponents(){} // RVA: 0x7FFD55292A50
        public void PlayDefaultVideo(){} // RVA: 0x7FFD55292FA0
        public void SanitizeURL(){} // RVA: 0x7FFD55293090
        public void get_DebugCategoryName(){} // RVA: 0x7FFD552931A0
        public void InitializeLogging(){} // RVA: 0x7FFD55293220
        public void ResolveURLs(){} // RVA: 0x7FFD55293310
        public void DoSetupFromRemoteJson(){} // RVA: 0x7FFD55293B40
        public void SetupVideoPlayer(){} // RVA: 0x7FFD55294920
        public void LoadURL(){} // RVA: 0x7FFD55294CB0
        public void PlayURL(){} // RVA: 0x7FFD55294DA0
        public void Pause(){} // RVA: 0x7FFD55294E90
        public void Play(){} // RVA: 0x7FFD55294EF0
        public void PlayDelayCoroutine(){} // RVA: 0x7FFD55295070
        public void GetDuration(){} // RVA: 0x7FFD55295110
        public void GetTime(){} // RVA: 0x7FFD55295280
        public void SetTime(){} // RVA: 0x7FFD552952C0
        public void get_VideoWidth(){} // RVA: 0x7FFD55295310
        public void get_VideoHeight(){} // RVA: 0x7FFD55295350
        public void Stop(){} // RVA: 0x7FFD55295390
        public void OnPrepared(){} // RVA: 0x7FFD552953D0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x7FFD552955F0
        public void OnError(){} // RVA: 0x7FFD55295690
        public void OnStarted(){} // RVA: 0x7FFD55295710
        public void OnLoopPointReached(){} // RVA: 0x7FFD55295770
        public void .ctor(){} // RVA: 0x7FFD552957C0
        public void .cctor(){} // RVA: 0x7FFD552957D0
        public void <PlayDefaultVideo>g__PlayVideo|29_0(){} // RVA: 0x7FFD55295DC0
        public void <LoadURL>g__PlayVideo|44_0(){} // RVA: 0x7FFD55295E30
        public void <PlayURL>g__PlayVideo|45_0(){} // RVA: 0x7FFD55295EC0
        public void <>n__0(){} // RVA: 0x7FFD55295F30
    }

}