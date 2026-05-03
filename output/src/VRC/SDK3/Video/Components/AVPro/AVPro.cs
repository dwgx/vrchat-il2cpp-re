// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.AVPro
// Classes: 3
// Methods: 39

namespace VRC.SDK3.Video.Components.AVPro
{
    public class VRCAVProVideoPlayer : BaseVRCVideoPlayer
    {
        public System.Func`2<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer,VRC.SDK3.Video.Interfaces.AVPro.IAVProVideoPlayerInternal> _initialize;
        public bool _initialized; // 0x38
        public VRC.SDKBase.VRCUrl videoURL; // 0x40
        public bool autoPlay; // 0x48
        public bool loop; // 0x49
        public int maximumResolution; // 0x4C
        public bool useLowLatency; // 0x50
        public VRC.SDK3.Video.Interfaces.AVPro.IAVProVideoPlayerInternal _playerInternal; // 0x58
        public object field_8; // 0x26
        public object field_9; // 0x27
        public object field_10; // 0x28

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFE8A45CB50
        public void set_Initialize(){} // RVA: 0x7FFE8A45CB90
        public void get_VideoURL(){} // RVA: 0x7FFE81178740
        public void get_AutoPlay(){} // RVA: 0x7FFE811B2D30
        public void get_MaximumResolution(){} // RVA: 0x7FFE821E0A40
        public void get_Initialized(){} // RVA: 0x7FFE812CF770
        public void set_Initialized(){} // RVA: 0x7FFE812D0010
        public void get_UseLowLatency(){} // RVA: 0x7FFE811B58E0
        public void get_Loop(){} // RVA: 0x7FFE8A45CC30
        public void set_Loop(){} // RVA: 0x7FFE8A45CC80
        public void get_IsPlaying(){} // RVA: 0x7FFE8A45CCE0
        public void get_IsReady(){} // RVA: 0x7FFE8A45CD40
        public void OnValidate(){} // RVA: 0x7FFE8A45CDA0
        public void Start(){} // RVA: 0x7FFE8A45CDC0
        public void LoadURL(){} // RVA: 0x7FFE8A45CF30
        public void PlayURL(){} // RVA: 0x7FFE8A45CF90
        public void Play(){} // RVA: 0x7FFE8A45CFF0
        public void Pause(){} // RVA: 0x7FFE8A45D050
        public void Stop(){} // RVA: 0x7FFE8A45D0A0
        public void GetDuration(){} // RVA: 0x7FFE8A45D0F0
        public void GetTime(){} // RVA: 0x7FFE8A45D150
        public void SetTime(){} // RVA: 0x7FFE8A45D1B0
        public void get_VideoWidth(){} // RVA: 0x7FFE8A45D220
        public void get_VideoHeight(){} // RVA: 0x7FFE8A45D280
        public void .ctor(){} // RVA: 0x7FFE8A45D2E0
    }

    public class VRCAVProVideoScreen : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoScreen> _initialize;
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer videoPlayer; // 0x20
        public int materialIndex; // 0x28
        public string textureProperty; // 0x30
        public bool useSharedMaterial; // 0x38

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFE8A45D300
        public void set_Initialize(){} // RVA: 0x7FFE8A45D340
        public void get_VideoPlayer(){} // RVA: 0x7FFE811290C0
        public void get_MaterialIndex(){} // RVA: 0x7FFE81549710
        public void get_TextureProperty(){} // RVA: 0x7FFE8144E200
        public void get_UseSharedMaterial(){} // RVA: 0x7FFE812CF770
        public void Start(){} // RVA: 0x7FFE8A45D3E0
        public void .ctor(){} // RVA: 0x7FFE8A45D500
    }

    public class VRCAVProVideoSpeaker : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoSpeaker> _initialize;
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer videoPlayer; // 0x20
        public 0x6665B2E4 mode; // 0x28

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFE8A45D5D0
        public void set_Initialize(){} // RVA: 0x7FFE8A45D610
        public void get_VideoPlayer(){} // RVA: 0x7FFE811290C0
        public void get_Mode(){} // RVA: 0x7FFE81549710
        public void Start(){} // RVA: 0x7FFE8A45D6B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}