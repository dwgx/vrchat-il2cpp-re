// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.AVPro
// Classes: 3
// Methods: 39

namespace VRC.SDK3.Video.Components.AVPro
{
    public class VRCAVProVideoPlayer : BaseVRCVideoPlayer
    {
        public object _initialize;
        public object _initialized;
        public object videoURL;
        public object autoPlay;
        public object loop;
        public object maximumResolution;
        public object useLowLatency;
        public object _playerInternal;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0xA6AA920
        public void set_Initialize(){} // RVA: 0xA6AA960
        public void get_VideoURL(){} // RVA: 0xBC1B30
        public void get_AutoPlay(){} // RVA: 0xBFDA40
        public void get_MaximumResolution(){} // RVA: 0x1D46130
        public void get_Initialized(){} // RVA: 0xD16660
        public void set_Initialized(){} // RVA: 0xD14C10
        public void get_UseLowLatency(){} // RVA: 0xC00EC0
        public void get_Loop(){} // RVA: 0xA6AAA00
        public void set_Loop(){} // RVA: 0xA6AAA50
        public void get_IsPlaying(){} // RVA: 0xA6AAAB0
        public void get_IsReady(){} // RVA: 0xA6AAB10
        public void OnValidate(){} // RVA: 0xA6AAB70
        public void Start(){} // RVA: 0xA6AAB90
        public void LoadURL(){} // RVA: 0xA6AAD00
        public void PlayURL(){} // RVA: 0xA6AAD60
        public void Play(){} // RVA: 0xA6AADC0
        public void Pause(){} // RVA: 0xA6AAE20
        public void Stop(){} // RVA: 0xA6AAE70
        public void GetDuration(){} // RVA: 0xA6AAEC0
        public void GetTime(){} // RVA: 0xA6AAF20
        public void SetTime(){} // RVA: 0xA6AAF80
        public void get_VideoWidth(){} // RVA: 0xA6AAFF0
        public void get_VideoHeight(){} // RVA: 0xA6AB050
        public void .ctor(){} // RVA: 0xA6AB0B0
    }

    public class VRCAVProVideoScreen : MonoBehaviour
    {
        public object _initialize;
        public object videoPlayer;
        public object materialIndex;
        public object textureProperty;
        public object useSharedMaterial;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0xA6AB0D0
        public void set_Initialize(){} // RVA: 0xA6AB110
        public void get_VideoPlayer(){} // RVA: 0xB700F0
        public void get_MaterialIndex(){} // RVA: 0x1065D50
        public void get_TextureProperty(){} // RVA: 0xD33E60
        public void get_UseSharedMaterial(){} // RVA: 0xD16660
        public void Start(){} // RVA: 0xA6AB1B0
        public void .ctor(){} // RVA: 0xA6AB2D0
    }

    public class VRCAVProVideoSpeaker : MonoBehaviour
    {
        public object _initialize;
        public object videoPlayer;
        public object mode;

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0xA6AB3A0
        public void set_Initialize(){} // RVA: 0xA6AB3E0
        public void get_VideoPlayer(){} // RVA: 0xB700F0
        public void get_Mode(){} // RVA: 0x1065D50
        public void Start(){} // RVA: 0xA6AB480
        public void .ctor(){} // RVA: 0xB43D60
    }

}