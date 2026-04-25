// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.AVPro
// Classes: 3
// Methods: 39

namespace VRC.SDK3.Video.Components.AVPro
{
    public class VRCAVProVideoPlayer : BaseVRCVideoPlayer
    {
        public System.Func`2<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer,VRC.SDK3.Video.Interfaces.AVPro.IAVProVideoPlayerInternal> Initialize;
        public bool VideoURL; // 0x38
        public VRC.SDKBase.VRCUrl AutoPlay; // 0x40
        public bool MaximumResolution; // 0x48
        public bool Initialized; // 0x49
        public int UseLowLatency; // 0x4C
        public bool Loop; // 0x50
        public VRC.SDK3.Video.Interfaces.AVPro.IAVProVideoPlayerInternal IsPlaying; // 0x58

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFD57417350
        public void set_Initialize(){} // RVA: 0x7FFD57417390
        public void get_VideoURL(){} // RVA: 0x7FFD4E3BE740
        public void get_AutoPlay(){} // RVA: 0x7FFD4E3F8D30
        public void get_MaximumResolution(){} // RVA: 0x7FFD4F34D3C0
        public void get_Initialized(){} // RVA: 0x7FFD4E5F95D0
        public void set_Initialized(){} // RVA: 0x7FFD4E5F95C0
        public void get_UseLowLatency(){} // RVA: 0x7FFD4E3FB8E0
        public void get_Loop(){} // RVA: 0x7FFD57417430
        public void set_Loop(){} // RVA: 0x7FFD57417480
        public void get_IsPlaying(){} // RVA: 0x7FFD574174E0
        public void get_IsReady(){} // RVA: 0x7FFD57417540
        public void OnValidate(){} // RVA: 0x7FFD574175A0
        public void Start(){} // RVA: 0x7FFD574175C0
        public void LoadURL(){} // RVA: 0x7FFD57417730
        public void PlayURL(){} // RVA: 0x7FFD57417790
        public void Play(){} // RVA: 0x7FFD574177F0
        public void Pause(){} // RVA: 0x7FFD57417850
        public void Stop(){} // RVA: 0x7FFD574178A0
        public void GetDuration(){} // RVA: 0x7FFD574178F0
        public void GetTime(){} // RVA: 0x7FFD57417950
        public void SetTime(){} // RVA: 0x7FFD574179B0
        public void get_VideoWidth(){} // RVA: 0x7FFD57417A20
        public void get_VideoHeight(){} // RVA: 0x7FFD57417A80
        public void .ctor(){} // RVA: 0x7FFD57417AE0
    }

    public class VRCAVProVideoScreen : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoScreen> Initialize;
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer VideoPlayer; // 0x20
        public int MaterialIndex; // 0x28
        public string TextureProperty; // 0x30
        public bool UseSharedMaterial; // 0x38

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFD57417B00
        public void set_Initialize(){} // RVA: 0x7FFD57417B40
        public void get_VideoPlayer(){} // RVA: 0x7FFD4E36F0C0
        public void get_MaterialIndex(){} // RVA: 0x7FFD4E70C4C0
        public void get_TextureProperty(){} // RVA: 0x7FFD4E5F95E0
        public void get_UseSharedMaterial(){} // RVA: 0x7FFD4E5F95D0
        public void Start(){} // RVA: 0x7FFD57417BE0
        public void .ctor(){} // RVA: 0x7FFD57417D00
    }

    public class VRCAVProVideoSpeaker : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.AVPro.VRCAVProVideoSpeaker> Initialize;
        public VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer VideoPlayer; // 0x20
        public 0x665C17B8 Mode; // 0x28

        // ── Methods ──
        public void get_Initialize(){} // RVA: 0x7FFD57417DD0
        public void set_Initialize(){} // RVA: 0x7FFD57417E10
        public void get_VideoPlayer(){} // RVA: 0x7FFD4E36F0C0
        public void get_Mode(){} // RVA: 0x7FFD4E70C4C0
        public void Start(){} // RVA: 0x7FFD57417EB0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}