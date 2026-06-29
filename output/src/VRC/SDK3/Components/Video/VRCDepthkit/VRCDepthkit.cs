// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components.Video.VRCDepthkit
// Classes: 2
// Methods: 40

namespace VRC.SDK3.Components.Video.VRCDepthkit
{
    public class VRCDepthkitMetadata : Object
    {
        public object videoUrl;
        public object studioMeshData;
        public object studioLiteMeshData;
        public object studioLookData;
        public object studioLiteLookData;
        public object clipMetadataString;
        public object FormatVersion;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8326790
    }

    public class VRCDepthkitVideo : BaseVRCVideoPlayer
    {
        public object videoURL;
        public object autoPlay;
        public object loop;
        public object studioLook;
        public object studioLiteLook;
        public object studioMeshSource;
        public object studioLiteMeshSource;
        public object depthkitClip;
        public object LOG_CATEGORY;
        public object _player;
        public object _unityPlayer;
        public object _pauseOnStart;
        public object _playDelayedCoroutine;
        public object _onVideoReadyDelayedCoroutine;
        public object _allowedSchemes;
        public object MinimumDelayBetweenResolveRequests;
        public object _lastResolveRequest;
        public object _schemesToHandleDirectly;
        public object _debugCategoryName;
        public object GetUrlExtension;
        public object _httpClient;

        // ── Methods ──
        public void get_url(){} // RVA: 0x8326FD0
        public void LogInfo(){} // RVA: 0x8326FF0
        public void LogError(){} // RVA: 0x8327060
        public void get_Player(){} // RVA: 0x83270D0
        public void get_IsPlaying(){} // RVA: 0x83271B0
        public void get_IsReady(){} // RVA: 0x8327250
        public void get_Loop(){} // RVA: 0xEEA010
        public void set_Loop(){} // RVA: 0xEEA000
        public void Start(){} // RVA: 0x8327290
        public void RefreshDepthkitComponents(){} // RVA: 0x83273D0
        public void PlayDefaultVideo(){} // RVA: 0x8327920
        public void SanitizeURL(){} // RVA: 0x8327A10
        public void get_DebugCategoryName(){} // RVA: 0x8327B20
        public void InitializeLogging(){} // RVA: 0x8327BA0
        public void ResolveURLs(){} // RVA: 0x8327C90
        public void DoSetupFromRemoteJson(){} // RVA: 0x83284C0
        public void SetupVideoPlayer(){} // RVA: 0x83292B0
        public void LoadURL(){} // RVA: 0x83295D0
        public void PlayURL(){} // RVA: 0x83296C0
        public void Pause(){} // RVA: 0x83297B0
        public void Play(){} // RVA: 0x8329850
        public void PlayDelayCoroutine(){} // RVA: 0x83299D0
        public void GetDuration(){} // RVA: 0x8329A70
        public void GetTime(){} // RVA: 0x8329BA0
        public void SetTime(){} // RVA: 0x8329BE0
        public void get_VideoWidth(){} // RVA: 0x8329C30
        public void get_VideoHeight(){} // RVA: 0x8329C70
        public void Stop(){} // RVA: 0x8329CB0
        public void OnPrepared(){} // RVA: 0x8329CF0
        public void OnVideoReadyDelayCoroutine(){} // RVA: 0x8329F20
        public void OnError(){} // RVA: 0x8329FC0
        public void OnStarted(){} // RVA: 0x832A070
        public void OnLoopPointReached(){} // RVA: 0x832A0D0
        public void .ctor(){} // RVA: 0x832A120
        public void .cctor(){} // RVA: 0x832A130
        public void <PlayDefaultVideo>g__PlayVideo|29_0(){} // RVA: 0x832A720
        public void <LoadURL>g__PlayVideo|44_0(){} // RVA: 0x832A790
        public void <PlayURL>g__PlayVideo|45_0(){} // RVA: 0x832A820
        public void <>n__0(){} // RVA: 0x832A890
    }

}